namespace DateBook
{
    partial class CreateMeeting
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateMeeting));
            this.label1 = new System.Windows.Forms.Label();
            this.dateMeeting = new System.Windows.Forms.DateTimePicker();
            this.dateNotification = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameMeeting = new System.Windows.Forms.TextBox();
            this.Comment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeMeeting = new System.Windows.Forms.DateTimePicker();
            this.timeNotification = new System.Windows.Forms.DateTimePicker();
            this.errorNameMeeting = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameMeeting)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата встречи";
            // 
            // dateMeeting
            // 
            this.dateMeeting.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateMeeting.Location = new System.Drawing.Point(12, 128);
            this.dateMeeting.MinDate = new System.DateTime(2024, 4, 28, 0, 0, 0, 0);
            this.dateMeeting.Name = "dateMeeting";
            this.dateMeeting.Size = new System.Drawing.Size(184, 22);
            this.dateMeeting.TabIndex = 1;
            this.dateMeeting.Value = new System.DateTime(2024, 4, 28, 0, 0, 0, 0);
            this.dateMeeting.ValueChanged += new System.EventHandler(this.dateMeeting_ValueChanged);
            // 
            // dateNotification
            // 
            this.dateNotification.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNotification.Location = new System.Drawing.Point(12, 186);
            this.dateNotification.MinDate = new System.DateTime(2024, 4, 28, 0, 0, 0, 0);
            this.dateNotification.Name = "dateNotification";
            this.dateNotification.Size = new System.Drawing.Size(184, 22);
            this.dateNotification.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата оповещения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Название встречи";
            // 
            // nameMeeting
            // 
            this.nameMeeting.Location = new System.Drawing.Point(12, 244);
            this.nameMeeting.MaxLength = 30;
            this.nameMeeting.Name = "nameMeeting";
            this.nameMeeting.Size = new System.Drawing.Size(346, 22);
            this.nameMeeting.TabIndex = 5;
            this.nameMeeting.Validating += new System.ComponentModel.CancelEventHandler(this.nameMeeting_Validating);
            // 
            // Comment
            // 
            this.Comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Comment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comment.Location = new System.Drawing.Point(0, 0);
            this.Comment.Multiline = true;
            this.Comment.Name = "Comment";
            this.Comment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Comment.Size = new System.Drawing.Size(405, 137);
            this.Comment.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Комментарий";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Comment);
            this.panel1.Location = new System.Drawing.Point(12, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 141);
            this.panel1.TabIndex = 8;
            // 
            // bSave
            // 
            this.bSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bSave.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.ForeColor = System.Drawing.SystemColors.Window;
            this.bSave.Location = new System.Drawing.Point(12, 482);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(117, 49);
            this.bSave.TabIndex = 9;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bCancel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.bCancel.Location = new System.Drawing.Point(135, 482);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(117, 49);
            this.bCancel.TabIndex = 10;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 80);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(223, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Время оповещения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(223, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Время встречи";
            // 
            // timeMeeting
            // 
            this.timeMeeting.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeMeeting.Location = new System.Drawing.Point(226, 131);
            this.timeMeeting.Name = "timeMeeting";
            this.timeMeeting.ShowUpDown = true;
            this.timeMeeting.Size = new System.Drawing.Size(200, 22);
            this.timeMeeting.TabIndex = 15;
            this.timeMeeting.ValueChanged += new System.EventHandler(this.timeMeeting_ValueChanged);
            // 
            // timeNotification
            // 
            this.timeNotification.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeNotification.Location = new System.Drawing.Point(226, 188);
            this.timeNotification.Name = "timeNotification";
            this.timeNotification.ShowUpDown = true;
            this.timeNotification.Size = new System.Drawing.Size(200, 22);
            this.timeNotification.TabIndex = 16;
            this.timeNotification.ValueChanged += new System.EventHandler(this.timeNotification_ValueChanged);
            // 
            // errorNameMeeting
            // 
            this.errorNameMeeting.ContainerControl = this;
            // 
            // CreateMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 559);
            this.Controls.Add(this.timeNotification);
            this.Controls.Add(this.timeMeeting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameMeeting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateNotification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateMeeting);
            this.Controls.Add(this.label1);
            this.Name = "CreateMeeting";
            this.Text = "Создание встречи";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNameMeeting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateMeeting;
        private System.Windows.Forms.DateTimePicker dateNotification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameMeeting;
        private System.Windows.Forms.TextBox Comment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timeMeeting;
        private System.Windows.Forms.DateTimePicker timeNotification;
        private System.Windows.Forms.ErrorProvider errorNameMeeting;
    }
}

