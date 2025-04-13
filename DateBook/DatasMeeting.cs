using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateBook
{
    internal class DatasMeeting
    {
        public string name { set;  get; }
        public string date_meeting { set; get; }
        public string time_meeting { set; get; }
        public string date_notification { set; get; }
        public string time_notification { set; get; }
        public string comment { set; get; }

        public DatasMeeting(string name, string date_meeting,
            string time_meeting, string date_notification,
            string time_notification, string comment)
        {
            this.name = name;
            this.date_meeting = date_meeting;
            this.time_meeting = time_meeting;
            this.date_notification = date_notification;
            this.time_notification = time_notification;
            this.comment = comment;
        }
    }
}
