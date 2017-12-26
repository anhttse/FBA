using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FBA.Models.RegisterModel
{
    public class UserRegisterModel:User
    {
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        //public string ErrorMessage { get; set; }
        
    }
}