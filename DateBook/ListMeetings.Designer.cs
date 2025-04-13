namespace DateBook
{
    partial class ListMeetings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListMeetings));
            this.lMeetings = new System.Windows.Forms.ListBox();
            this.bAddMeeting = new System.Windows.Forms.Button();
            this.bGoToMeeting = new System.Windows.Forms.Button();
            this.pictureLMeeting = new System.Windows.Forms.PictureBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLMeeting)).BeginInit();
            this.SuspendLayout();
            // 
            // lMeetings
            // 
            this.lMeetings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lMeetings.FormattingEnabled = true;
            this.lMeetings.ItemHeight = 16;
            this.lMeetings.Location = new System.Drawing.Point(1, 83);
            this.lMeetings.Name = "lMeetings";
            this.lMeetings.Size = new System.Drawing.Size(754, 464);
            this.lMeetings.TabIndex = 12;
            // 
            // bAddMeeting
            // 
            this.bAddMeeting.BackColor = System.Drawing.Color.Green;
            this.bAddMeeting.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddMeeting.ForeColor = System.Drawing.SystemColors.Window;
            this.bAddMeeting.Location = new System.Drawing.Point(606, 491);
            this.bAddMeeting.Name = "bAddMeeting";
            this.bAddMeeting.Size = new System.Drawing.Size(117, 49);
            this.bAddMeeting.TabIndex = 13;
            this.bAddMeeting.Text = "Добавить";
            this.bAddMeeting.UseVisualStyleBackColor = false;
            this.bAddMeeting.Click += new System.EventHandler(this.bAddMeeting_Click);
            // 
            // bGoToMeeting
            // 
            this.bGoToMeeting.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bGoToMeeting.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bGoToMeeting.ForeColor = System.Drawing.SystemColors.Window;
            this.bGoToMeeting.Location = new System.Drawing.Point(34, 491);
            this.bGoToMeeting.Name = "bGoToMeeting";
            this.bGoToMeeting.Size = new System.Drawing.Size(117, 49);
            this.bGoToMeeting.TabIndex = 14;
            this.bGoToMeeting.Text = "Перейти";
            this.bGoToMeeting.UseVisualStyleBackColor = false;
            this.bGoToMeeting.Click += new System.EventHandler(this.bGoToMeeting_Click);
            // 
            // pictureLMeeting
            // 
            this.pictureLMeeting.Image = ((System.Drawing.Image)(resources.GetObject("pictureLMeeting.Image")));
            this.pictureLMeeting.Location = new System.Drawing.Point(1, 0);
            this.pictureLMeeting.Name = "pictureLMeeting";
            this.pictureLMeeting.Size = new System.Drawing.Size(754, 67);
            this.pictureLMeeting.TabIndex = 15;
            this.pictureLMeeting.TabStop = false;
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Red;
            this.bDelete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.bDelete.Location = new System.Drawing.Point(483, 491);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(117, 49);
            this.bDelete.TabIndex = 18;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bSave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.ForeColor = System.Drawing.SystemColors.Window;
            this.bSave.Location = new System.Drawing.Point(157, 491);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(117, 49);
            this.bSave.TabIndex = 19;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Interval = 1000;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // ListMeetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(755, 552);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.pictureLMeeting);
            this.Controls.Add(this.bGoToMeeting);
            this.Controls.Add(this.bAddMeeting);
            this.Controls.Add(this.lMeetings);
            this.Name = "ListMeetings";
            this.Text = "Список встреч";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLMeeting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lMeetings;
        private System.Windows.Forms.Button bAddMeeting;
        private System.Windows.Forms.Button bGoToMeeting;
        private System.Windows.Forms.PictureBox pictureLMeeting;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Timer timerCheck;
    }
}