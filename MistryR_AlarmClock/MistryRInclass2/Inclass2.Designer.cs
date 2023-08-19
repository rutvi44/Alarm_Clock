namespace MistryRInclass2
{
    partial class Inclass2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inclass2));
            timeLabel = new Label();
            secondsLabel = new Label();
            pmLabel = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            buttonAlarmOn = new Button();
            buttonAlarmOff = new Button();
            statusLabel = new Label();
            label4 = new Label();
            dateTimePicker = new DateTimePicker();
            timer = new System.Windows.Forms.Timer(components);
            dateLabel = new Label();
            dayLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("MV Boli", 55F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.Location = new Point(634, 97);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(307, 144);
            timeLabel.TabIndex = 0;
            timeLabel.Text = "Time";
            timeLabel.Click += timeLabel_Click;
            // 
            // secondsLabel
            // 
            secondsLabel.AutoSize = true;
            secondsLabel.Font = new Font("MV Boli", 22F, FontStyle.Regular, GraphicsUnit.Point);
            secondsLabel.Location = new Point(1006, 64);
            secondsLabel.Name = "secondsLabel";
            secondsLabel.Size = new Size(182, 58);
            secondsLabel.TabIndex = 1;
            secondsLabel.Text = "Seconds";
            secondsLabel.Click += label2_Click;
            // 
            // pmLabel
            // 
            pmLabel.AutoSize = true;
            pmLabel.Font = new Font("MV Boli", 22F, FontStyle.Regular, GraphicsUnit.Point);
            pmLabel.Location = new Point(1011, 183);
            pmLabel.Name = "pmLabel";
            pmLabel.Size = new Size(189, 58);
            pmLabel.TabIndex = 2;
            pmLabel.Text = "AM/PM";
            pmLabel.Click += pmLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(966, 244);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(598, 424);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(989, 674);
            label1.Name = "label1";
            label1.Size = new Size(211, 31);
            label1.TabIndex = 4;
            label1.Text = "Day of the Week";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 282);
            label2.Name = "label2";
            label2.Size = new Size(146, 31);
            label2.TabIndex = 6;
            label2.Text = "Alarm Time";
            label2.Click += label2_Click_1;
            // 
            // buttonAlarmOn
            // 
            buttonAlarmOn.BackColor = Color.MediumTurquoise;
            buttonAlarmOn.Location = new Point(90, 413);
            buttonAlarmOn.Name = "buttonAlarmOn";
            buttonAlarmOn.Size = new Size(119, 70);
            buttonAlarmOn.TabIndex = 7;
            buttonAlarmOn.Text = "Alarm ON";
            buttonAlarmOn.UseVisualStyleBackColor = false;
            buttonAlarmOn.Click += buttonAlarmOn_Click;
            // 
            // buttonAlarmOff
            // 
            buttonAlarmOff.BackColor = Color.MediumTurquoise;
            buttonAlarmOff.Location = new Point(297, 413);
            buttonAlarmOff.Name = "buttonAlarmOff";
            buttonAlarmOff.Size = new Size(122, 73);
            buttonAlarmOff.TabIndex = 8;
            buttonAlarmOff.Text = "Alarm OFF";
            buttonAlarmOff.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonAlarmOff.UseVisualStyleBackColor = false;
            buttonAlarmOff.Click += buttonAlarmOff_Click;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(118, 544);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(168, 31);
            statusLabel.TabIndex = 9;
            statusLabel.Text = "Alarm Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 687);
            label4.Name = "label4";
            label4.Size = new Size(68, 31);
            label4.TabIndex = 10;
            label4.Text = "Date";
            label4.Click += label4_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.Location = new Point(103, 336);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(300, 46);
            dateTimePicker.TabIndex = 12;
            dateTimePicker.ValueChanged += dateTimePicker_ValueChanged;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(103, 754);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(79, 31);
            dateLabel.TabIndex = 13;
            dateLabel.Text = "label3";
            dateLabel.Click += dateLabel_Click;
            // 
            // dayLabel
            // 
            dayLabel.AutoSize = true;
            dayLabel.Location = new Point(1014, 742);
            dayLabel.Name = "dayLabel";
            dayLabel.Size = new Size(79, 31);
            dayLabel.TabIndex = 14;
            dayLabel.Text = "label3";
            // 
            // Inclass2
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1660, 878);
            Controls.Add(dayLabel);
            Controls.Add(dateLabel);
            Controls.Add(dateTimePicker);
            Controls.Add(label4);
            Controls.Add(statusLabel);
            Controls.Add(buttonAlarmOff);
            Controls.Add(buttonAlarmOn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pmLabel);
            Controls.Add(secondsLabel);
            Controls.Add(timeLabel);
            Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Inclass2";
            Text = "inclass2";
            FormClosing += Inclass2_FormClosing;
            Load += Inclass2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label secondsLabel;
        private Label pmLabel;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button buttonAlarmOn;
        private Button buttonAlarmOff;
        private Label statusLabel;
        private Label label4;
        private DateTimePicker dateTimePicker;
        private System.Windows.Forms.Timer timer;
        private Label dateLabel;
        private Label dayLabel;
    }
}