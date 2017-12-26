using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace FBA.Models
{
    public class User
    {
        [Required]
        [DataType(DataType.Password)]
        [StringLength(150,ErrorMessage = "The {0} must be at least {2} characters.",MinimumLength = 6)]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}