using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBook
{
    public partial class CreateMeeting : Form
    {
        int index = -1;
        public CreateMeeting(int index = -1)
        {
            InitializeComponent();
            dateMeeting.MinDate = DateTime.Today;
            dateNotification.MaxDate = dateMeeting.Value;
            dateNotification.MinDate = DateTime.Today;

            if (index != -1)
            {
                this.index = index;
                dateMeeting.Text = ListMeetings.list_meetings[index].date_meeting;
                timeMeeting.Text = ListMeetings.list_meetings[index].time_meeting;
                dateNotification.Text = ListMeetings.list_meetings[index].date_notification;
                timeNotification.Text = ListMeetings.list_meetings[index].time_notification;
                nameMeeting.Text = ListMeetings.list_meetings[index].name;
                Comment.Text = ListMeetings.list_meetings[index].comment;

                bSave.Text = "Изменить";
                bCancel.Text = "Выйти";
            }
            else
                errorNameMeeting.SetError(nameMeeting, "Поле должно быть заполнено.");
        }

        private void dateMeeting_ValueChanged(object sender, EventArgs e)
            => dateNotification.MaxDate = dateMeeting.Value;

        private void timeMeeting_ValueChanged(object sender, EventArgs e)
        {
            if (dateMeeting.Value.Date == DateTime.Today &&
                timeMeeting.Value < DateTime.Now &&
                index == -1)
                timeMeeting.Value = DateTime.Now;
        }

        private void timeNotification_ValueChanged(object sender, EventArgs e)
        {
            if (dateMeeting.Value == dateNotification.Value &&
                timeNotification.Value > timeMeeting.Value)
                timeNotification.Value = timeMeeting.Value;
        }

        private void bCancel_Click(object sender, EventArgs e)
            => this.Close();

        private void bSave_Click(object sender, EventArgs e)
        {
            if (errorNameMeeting.GetError(nameMeeting) == "" &&
                index == -1)
            {
                ListMeetings.list_meetings.Add(new DatasMeeting( nameMeeting.Text, 
                    dateMeeting.Text, timeMeeting.Text, dateNotification.Text,
                    timeNotification.Text, Comment.Text));
                this.Close();
            }
            else if (errorNameMeeting.GetError(nameMeeting) == "" &&
                index != -1)
            {
                ListMeetings.list_meetings[index].date_meeting = dateMeeting.Text;
                ListMeetings.list_meetings[index].time_meeting = timeMeeting.Text;
                ListMeetings.list_meetings[index].date_notification = dateNotification.Text;
                ListMeetings.list_meetings[index].time_notification = timeNotification.Text;
                ListMeetings.list_meetings[index].name = nameMeeting.Text;
                ListMeetings.list_meetings[index].comment = Comment.Text;
                this.Close();
            }
        }

        private void nameMeeting_Validating(object sender, CancelEventArgs e)
        {
            if (nameMeeting.Text == "")
                errorNameMeeting.SetError(nameMeeting, 
                    "Поле должно быть заполнено.");
            else
                errorNameMeeting.Clear();
        }
    }
}
