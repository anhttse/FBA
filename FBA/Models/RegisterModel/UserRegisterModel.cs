using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBA.Models.RegisterModel
{
    public class UserRegisterModel:User
    {
        public string ConfirmPassword { get; set; }
    }
}