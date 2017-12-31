using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FBA.Models.RegisterModel;

namespace FBA.Models.ChangePasswordModel
{
    public class UserChangePasswordModel:UserRegisterModel
    {
        [DataType(DataType.Password)]
        [Display(Name = "Old password")]
        public string OldPassword { get; set; }
    }
}