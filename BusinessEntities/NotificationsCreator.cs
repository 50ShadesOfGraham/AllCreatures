using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class NotificationsCreator
    {
        private static Notifications notifcation = null;
        
        public static Notifications GetNotification(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail)
        {
            if (notifcation != null)
            {
                return notifcation;
            }
            else
            {
                return new Notifications(notificationid,message,title,messagetime,messageread,useremail);
            }
        }
        public static void SetUser(Notifications aNotification)
        {
            notifcation = aNotification;
        }
    }
}
