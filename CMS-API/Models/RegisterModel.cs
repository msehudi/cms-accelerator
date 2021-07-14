using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_API.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // [DataType(DataType.Password)]
        public string Password { get; set; }
        // [DataType(DataType.Password)]        
        public string ConfirmPassword { get; set; }
    }
}
