using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBook
{
    public partial class ListMeetings : Form
    {
        int count_docs = 0;
        internal static List<DatasMeeting> list_meetings = new List<DatasMeeting>();
        public ListMeetings()
        {
            InitializeComponent();

            Graphics graphics = Graphics.FromImage(pictureLMeeting.Image);
            graphics.DrawString("№         Дата встречи" +
                "                 Дата оповещения" +
                "         Название", new Font("Calibri", 15, FontStyle.Bold), Brushes.White, 0, 18);
            timerCheck.Enabled = true;
            timerCheck.Start();
        }

        private void bAddMeeting_Click(object sender, EventArgs e)
        {
            CreateMeeting createMeeting = new CreateMeeting();
            createMeeting.ShowDialog();
            new_lMeeting();
        }
        private void new_lMeeting()
        {
            lMeetings.Items.Clear();
            int index = 1;
            foreach (var item in list_meetings)
            {
                lMeetings.Items.Add($"{index}.\t {item.date_meeting} {item.time_meeting}" +
                    $"\t {item.date_notification} {item.time_notification}\t {item.name}");
                index++;
            }
        }

        private void bGoToMeeting_Click(object sender, EventArgs e)
        {
            if (lMeetings.SelectedIndex != -1)
            {
                CreateMeeting create = new CreateMeeting(lMeetings.SelectedIndex);
                create.ShowDialog();
                lMeetings.Items[lMeetings.SelectedIndex] = 
                    $"{lMeetings.SelectedIndex + 1}." +
                    $"\t {list_meetings[lMeetings.SelectedIndex].date_meeting}" +
                    $" {list_meetings[lMeetings.SelectedIndex].time_meeting}" +
                    $"\t {list_meetings[lMeetings.SelectedIndex].date_notification}" +
                    $" {list_meetings[lMeetings.SelectedIndex].time_notification}" +
                    $"\t {list_meetings[lMeetings.SelectedIndex].name}";
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (lMeetings.SelectedIndex != -1)
            {
                int index = lMeetings.SelectedIndex;
                lMeetings.Items.RemoveAt(index);
                list_meetings.RemoveAt(index); 
                new_lMeeting();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string[] new_list = new string[lMeetings.Items.Count + 1];
            new_list[0] = 
                "№         Дата встречи" +
                "            Дата оповещения" +
                "         Название";
            if(lMeetings.Items.Count > 0)
                for (int i = 1; i < new_list.Length; i++)
                    new_list[i] = (string)lMeetings.Items[i - 1];
            File.WriteAllLines($@"SaveDocs\\Meetings_{count_docs}.txt", new_list);
            
            count_docs++;
        }

        private void timerCheck_Tick(object sender, EventArgs e)
        {
            foreach (var item in list_meetings)
            {
                string date_time_check = item.date_notification + $" {item.time_notification}";
                if (date_time_check == Convert.ToString(DateTime.Now))
                    MessageBox.Show($"Ваша встреча под названием: '{item.name}' " +
                        $"ожидается {item.date_meeting} в {item.time_meeting}");
            }
        }
    }
}
