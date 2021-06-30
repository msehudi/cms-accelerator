using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app.Models;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk.Query;
using System.Security;

namespace app.Controllers
{
    public class TestController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public TestController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var serviceUri = new Uri("https://requestresponseaccel.api.crm3.dynamics.com/api/data/v9.2/");
            string clientId = "ec4c0a7f-27e7-4cf4-bbc1-ce28695d5906";
            // string userName = "QLabIntegration@quartechlab.com";
            string userName = "requesreqponseapi@quartechlab.com";
            var redirectUri = new Uri("https://localhost:5001");
            // var password = convertToSecureString("1ntegr@teM3_74");
            var password = convertToSecureString("ReqResAPI@QuartchLab21!");
            // var clientSecret = "1ba01694-a64c-46fd-9e18-2e7c48631f5f";
            var clientSecret = "2XWZ_9nS5j7H4-~._iGcJp8INBn4_MFyoI";

            // var connectionString = @$"Url=https://{environment}.dynamics.com;AuthType=ClientSecret;ClientId={clientId};ClientSecret={clientSecret};RequireNewInstance=true";
            using var serviceClient = new ServiceClient(serviceUri, clientId, clientSecret, true);

            // var serviceClient = new ServiceClient(userName, password, serviceUri, true, clientId, redirectUri);
            var accountsCollection = await serviceClient.RetrieveMultipleAsync(new QueryExpression("account")
            {
                ColumnSet = new ColumnSet("name"),
                TopCount = 10
            });

            Console.WriteLine(string.Join("\n", accountsCollection.Entities
            .Select(x => $"{x.GetAttributeValue<string>("name")}, {x.Id}")));

            return Ok(2);
        }

        public SecureString convertToSecureString(string strPassword)
        {
            var secureStr = new SecureString();
            if (strPassword.Length > 0)
            {
                foreach (var c in strPassword.ToCharArray()) secureStr.AppendChar(c);
            }
            return secureStr;
        }
    }
}
