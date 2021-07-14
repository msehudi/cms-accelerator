using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CMS_API.Models;
using System.Security.Claims;

namespace CMS_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public AuthController(ILogger<AuthController> logger,
                              SignInManager<ApplicationUser> signInManager,
                              UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost("register")]
        // [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.Email);

                if (user == null)
                {
                    user = new ApplicationUser
                    {
                        UserName = model.Email,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                    };
                    var result = await userManager.CreateAsync(user, model.Password);
                }
            }
            return null;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.UserName);

                if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
                {
                    var identity = new ClaimsIdentity("Identity.Application");
                    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
                    identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));

                    var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, true, lockoutOnFailure: true);
                    if (result.Succeeded)
                    {
                        return LocalRedirect("~/my-profile");
                    }
                }
            }
            return BadRequest("Login probably failed");
        }


        [HttpGet("current-user")]
        public Task<ApplicationUser> GetCurentUser() {
            var user = userManager.FindByNameAsync(signInManager.Context.User.Identity.Name);
            return user;
        }

    }
}
