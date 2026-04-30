namespace CSCI455_EMR
{
    partial class newAppointmentForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(343, 30);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeLabel.Location = new System.Drawing.Point(12, 81);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(62, 25);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "Time:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.typeLabel.Location = new System.Drawing.Point(12, 131);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(63, 25);
            this.typeLabel.TabIndex = 5;
            this.typeLabel.Text = "Type:";
            // 
            // timeBox
            // 
            this.timeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Items.AddRange(new object[] {
            "8:00AM",
            "8:30AM",
            "9:00AM",
            "9:30AM",
            "10:00AM",
            "10:30AM",
            "11:00AM",
            "11:30AM",
            "12:00PM",
            "1:00PM",
            "1:30PM",
            "2:00PM",
            "2:30PM",
            "3:00PM",
            "3:30PM",
            "4:00PM",
            "4:30PM",
            "5:00PM",
            "5:30PM",
            "6:00PM"});
            this.timeBox.Location = new System.Drawing.Point(80, 78);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(160, 33);
            this.timeBox.TabIndex = 6;
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Annual",
            "Flu/Cold",
            "Heart"});
            this.typeBox.Location = new System.Drawing.Point(80, 131);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(160, 33);
            this.typeBox.TabIndex = 7;
            // 
            // scheduleButton
            // 
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.scheduleButton.Location = new System.Drawing.Point(97, 186);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(107, 36);
            this.scheduleButton.TabIndex = 8;
            this.scheduleButton.Text = "Schedule";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // newAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 287);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "newAppointmentForm";
            this.Text = "New Appointment";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox timeBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Button scheduleButton;
    }
}