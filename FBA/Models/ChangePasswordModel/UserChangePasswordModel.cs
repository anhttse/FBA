using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FBA.Models.RegisterModel;

namespace FBA.Models.ChangePasswordModel
{
    public class UserChangePasswordModel:UserRegisterModel
    {
        public string OldPassword { get; set; }
    }
}