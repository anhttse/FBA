using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBA.Extension
{
    public static class Common
    {
        public const string UserSession = "USER_SESSION";
    }
    public static class Targets
    {
        public static List<object> TargetList = new List<object>() { new{text = "Group", value =1}, new { text = "Home Page", value = 2 }, new { text = "Post", value = 3 } , new { text = "Friends", value = 4 }  };
    }
    public enum ReactionType
    {
        Like,
        Love,
        Haha,
        Wow,
        Sad,
        Angry
    }
}