using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FBA.Extension;

namespace FBA.Models.ActionModels
{
    public class ReactionModel
    {
        public string Token { get; set; }
        public string Target { get; set; }
        public string Url { get; set; }
        [Display(Name = "Reaction")]
        public ReactionType ReactionType { get; set; }
       
    }

}