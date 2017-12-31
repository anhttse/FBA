using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FBA.Extension
{
    public static class Notifications
    {
        private static IDictionary<String, String> _notificationKey = new Dictionary<String, String>
        {
            { "Error",      "App.Notifications.Error" },
            { "Warning",    "App.Notifications.Warning" },
            { "Success",    "App.Notifications.Success" },
            { "Info",       "App.Notifications.Info" }
        };

        public static void AddNotification(this ControllerBase controller, String message, String notificationType)
        {
            var notificationKey = GetNotificationKeyByType(notificationType);
            ICollection<String> messages = controller.TempData[notificationKey] as ICollection<String>;

            if (messages == null)
            {
                controller.TempData[notificationKey] = (messages = new HashSet<String>());
            }

            messages.Add(message);
        }

        public static IEnumerable<String> GetNotifications(this HtmlHelper htmlHelper, String notificationType)
        {
            var notificationKey = GetNotificationKeyByType(notificationType);
            return htmlHelper.ViewContext.Controller.TempData[notificationKey] as ICollection<String> ?? null;
        }

        private static string GetNotificationKeyByType(string notificationType)
        {
            try
            {
                return _notificationKey[notificationType];
            }
            catch (IndexOutOfRangeException e)
            {
                ArgumentException exception = new ArgumentException("Key is invalid", nameof(notificationType), e);
                throw exception;
            }
        }

    }
    public static class NotificationType
    {
        public const string ERROR = "Error";
        public const string WARNING = "Warning";
        public const string SUCCESS = "Success";
        public const string INFO = "Info";

    }
}