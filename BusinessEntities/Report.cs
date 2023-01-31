using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Report 
    {
        private int reportId;
        private string reportUser;
        private string reason;
        private string description;
        private DateTime dateTime;
        

        public int ReportId
        {
            get { return reportId; }
            set { reportId = value; }
        }
        public string ReportUser
        {
            get { return reportUser; }
            set { reportUser = value; }
        }
        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Report(string reportUser, string reason, DateTime dateTime, string description, int reportId)
        {
            this.reportUser = reportUser;
            this.reportId = reportId;
            this.reason = reason;
            this.description = description;
            this.dateTime = dateTime;
            
        }
    }
}
