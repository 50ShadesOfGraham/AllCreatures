using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Notifications
    {
        #region Instance Properties
        private string notificationid;
        private string message;
        private string title;
        private DateTime messagetime;
        private bool messageread;
        private string useremail;
        #endregion
        #region Instance Properties
        public string NotificationID
        {
            get { return notificationid; }
            set { notificationid = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public DateTime Messagetime
        {
            get { return messagetime; }
            set { messagetime = value; }
        }
        public bool MessageRead
        {
            get { return messageread; }
            set { messageread = value; }
        }
        public string UserEmail
        {
            get { return useremail; }
            set { useremail = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        #endregion
        #region Constructors
        public Notifications()
        {
            throw new System.NotImplementedException();
        }
        public Notifications(string notificationid, string message, string title, DateTime messagetime, bool messageread, string useremail)
        {
            this.notificationid = notificationid;
            Message = message;
            this.title = title;
            Messagetime = messagetime;
            this.messageread = messageread;
            this.useremail = useremail;
        }
        #endregion
    }
}
