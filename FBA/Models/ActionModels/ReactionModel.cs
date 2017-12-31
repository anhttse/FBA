using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBA.Models.ActionModels
{
    public class ReactionModel
    {
        public string Token { get; set; }
        public string Target { get; set; }
        public string Url { get; set; }
        public string ReactionType { get; set; }
    }
    public static class Targets
    {
        public static List<string> TargetList = new List<string>() {"Group","Home Page","Post","Friends"};
    }
}