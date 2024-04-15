namespace CourseInformation
{
    partial class Form1
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
            selectCourseNumberLabel = new Label();
            courseNumberListBox = new ListBox();
            getCourseInfo = new Button();
            courseInformationGroupBox = new GroupBox();
            roomNumberLabel = new Label();
            instructorLabel = new Label();
            meetingTimeLabel = new Label();
            meetingTimeTextLabel = new Label();
            instructorTextLabel = new Label();
            roomNumberTextLabel = new Label();
            courseInformationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // selectCourseNumberLabel
            // 
            selectCourseNumberLabel.AutoSize = true;
            selectCourseNumberLabel.Location = new Point(83, 26);
            selectCourseNumberLabel.Name = "selectCourseNumberLabel";
            selectCourseNumberLabel.Size = new Size(136, 15);
            selectCourseNumberLabel.TabIndex = 0;
            selectCourseNumberLabel.Text = "Select A Course Number";
            // 
            // courseNumberListBox
            // 
            courseNumberListBox.FormattingEnabled = true;
            courseNumberListBox.ItemHeight = 15;
            courseNumberListBox.Items.AddRange(new object[] { "CS101", "CS102", "CS103", "NT110", "CM241" });
            courseNumberListBox.Location = new Point(83, 65);
            courseNumberListBox.Name = "courseNumberListBox";
            courseNumberListBox.Size = new Size(136, 139);
            courseNumberListBox.TabIndex = 1;
            // 
            // getCourseInfo
            // 
            getCourseInfo.Location = new Point(83, 223);
            getCourseInfo.Name = "getCourseInfo";
            getCourseInfo.Size = new Size(136, 23);
            getCourseInfo.TabIndex = 2;
            getCourseInfo.Text = "Get Course Info";
            getCourseInfo.UseVisualStyleBackColor = true;
            getCourseInfo.Click += getCourseInfo_Click;
            // 
            // courseInformationGroupBox
            // 
            courseInformationGroupBox.Controls.Add(roomNumberLabel);
            courseInformationGroupBox.Controls.Add(instructorLabel);
            courseInformationGroupBox.Controls.Add(meetingTimeLabel);
            courseInformationGroupBox.Controls.Add(meetingTimeTextLabel);
            courseInformationGroupBox.Controls.Add(instructorTextLabel);
            courseInformationGroupBox.Controls.Add(roomNumberTextLabel);
            courseInformationGroupBox.Location = new Point(12, 265);
            courseInformationGroupBox.Name = "courseInformationGroupBox";
            courseInformationGroupBox.Size = new Size(272, 173);
            courseInformationGroupBox.TabIndex = 3;
            courseInformationGroupBox.TabStop = false;
            courseInformationGroupBox.Text = "Course Information";
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.BorderStyle = BorderStyle.FixedSingle;
            roomNumberLabel.Location = new Point(155, 28);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new Size(100, 23);
            roomNumberLabel.TabIndex = 5;
            // 
            // instructorLabel
            // 
            instructorLabel.BackColor = SystemColors.Control;
            instructorLabel.BorderStyle = BorderStyle.FixedSingle;
            instructorLabel.Location = new Point(153, 73);
            instructorLabel.Name = "instructorLabel";
            instructorLabel.Size = new Size(102, 25);
            instructorLabel.TabIndex = 4;
            instructorLabel.Click += label1_Click;
            // 
            // meetingTimeLabel
            // 
            meetingTimeLabel.BorderStyle = BorderStyle.FixedSingle;
            meetingTimeLabel.Location = new Point(153, 120);
            meetingTimeLabel.Name = "meetingTimeLabel";
            meetingTimeLabel.Size = new Size(100, 23);
            meetingTimeLabel.TabIndex = 3;
            // 
            // meetingTimeTextLabel
            // 
            meetingTimeTextLabel.AutoSize = true;
            meetingTimeTextLabel.Location = new Point(6, 128);
            meetingTimeTextLabel.Name = "meetingTimeTextLabel";
            meetingTimeTextLabel.Size = new Size(83, 15);
            meetingTimeTextLabel.TabIndex = 2;
            meetingTimeTextLabel.Text = "Meeting Time:";
            // 
            // instructorTextLabel
            // 
            instructorTextLabel.AutoSize = true;
            instructorTextLabel.Location = new Point(6, 83);
            instructorTextLabel.Name = "instructorTextLabel";
            instructorTextLabel.Size = new Size(61, 15);
            instructorTextLabel.TabIndex = 1;
            instructorTextLabel.Text = "Instructor:";
            // 
            // roomNumberTextLabel
            // 
            roomNumberTextLabel.AutoSize = true;
            roomNumberTextLabel.Location = new Point(6, 36);
            roomNumberTextLabel.Name = "roomNumberTextLabel";
            roomNumberTextLabel.Size = new Size(89, 15);
            roomNumberTextLabel.TabIndex = 0;
            roomNumberTextLabel.Text = "Room Number:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 450);
            Controls.Add(courseInformationGroupBox);
            Controls.Add(getCourseInfo);
            Controls.Add(courseNumberListBox);
            Controls.Add(selectCourseNumberLabel);
            Name = "Form1";
            Text = "Course Information";
            courseInformationGroupBox.ResumeLayout(false);
            courseInformationGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectCourseNumberLabel;
        private ListBox courseNumberListBox;
        private Button getCourseInfo;
        private GroupBox courseInformationGroupBox;
        private Label instructorLabel;
        private Label meetingTimeLabel;
        private Label meetingTimeTextLabel;
        private Label instructorTextLabel;
        private Label roomNumberTextLabel;
        private Label roomNumberLabel;
    }
}
