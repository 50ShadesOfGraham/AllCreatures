using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class ReportCreator
    {
        private static Report report = null;

        public static Report GetReport( string reportUser, string reason, DateTime dateTime, string description,int reportID)
        {
            if (report != null)
            {
                return report;
            }
            else
            {
                return new Report(reportUser,reason,dateTime,description,reportID);
            }
        }
        public static void SetUser(Report areport)
        {
            report = areport;
        }
    }
}
