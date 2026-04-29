namespace CSCI455_EMR
{
    partial class nurseForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.searchPLabel = new System.Windows.Forms.Label();
            this.searchPatientBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.pInfoLabel = new System.Windows.Forms.Label();
            this.pInfoBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vitalsTBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prescBox = new System.Windows.Forms.TextBox();
            this.prescLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentsBox = new System.Windows.Forms.TextBox();
            this.upVisitsLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.welcomeLabel.Location = new System.Drawing.Point(378, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(245, 37);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome Nurse";
            // 
            // searchPLabel
            // 
            this.searchPLabel.AutoSize = true;
            this.searchPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchPLabel.Location = new System.Drawing.Point(25, 90);
            this.searchPLabel.Name = "searchPLabel";
            this.searchPLabel.Size = new System.Drawing.Size(233, 29);
            this.searchPLabel.TabIndex = 2;
            this.searchPLabel.Text = "Enter Patient Name: ";
            // 
            // searchPatientBox
            // 
            this.searchPatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchPatientBox.Location = new System.Drawing.Point(264, 87);
            this.searchPatientBox.Name = "searchPatientBox";
            this.searchPatientBox.Size = new System.Drawing.Size(359, 35);
            this.searchPatientBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchButton.Location = new System.Drawing.Point(646, 83);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 42);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // pInfoLabel
            // 
            this.pInfoLabel.AutoSize = true;
            this.pInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pInfoLabel.Location = new System.Drawing.Point(133, 140);
            this.pInfoLabel.Name = "pInfoLabel";
            this.pInfoLabel.Size = new System.Drawing.Size(212, 29);
            this.pInfoLabel.TabIndex = 5;
            this.pInfoLabel.Text = "Patient Information";
            // 
            // pInfoBox
            // 
            this.pInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pInfoBox.Location = new System.Drawing.Point(45, 172);
            this.pInfoBox.Multiline = true;
            this.pInfoBox.Name = "pInfoBox";
            this.pInfoBox.ReadOnly = true;
            this.pInfoBox.Size = new System.Drawing.Size(376, 251);
            this.pInfoBox.TabIndex = 6;
            this.pInfoBox.Text = "Name: \r\n\r\nEmail:\r\n\r\nAddress:\r\n\r\nDate of Birth:\r\n\r\nEmergency Contact:\r\n\r\nAllergies" +
    ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(600, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Patient Vitals";
            // 
            // vitalsTBox
            // 
            this.vitalsTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vitalsTBox.Location = new System.Drawing.Point(492, 172);
            this.vitalsTBox.Multiline = true;
            this.vitalsTBox.Name = "vitalsTBox";
            this.vitalsTBox.ReadOnly = true;
            this.vitalsTBox.Size = new System.Drawing.Size(376, 76);
            this.vitalsTBox.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(486, 313);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(376, 76);
            this.textBox3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(641, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Notes";
            // 
            // prescBox
            // 
            this.prescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.prescBox.Location = new System.Drawing.Point(492, 440);
            this.prescBox.Multiline = true;
            this.prescBox.Name = "prescBox";
            this.prescBox.ReadOnly = true;
            this.prescBox.Size = new System.Drawing.Size(376, 76);
            this.prescBox.TabIndex = 12;
            // 
            // prescLabel
            // 
            this.prescLabel.AutoSize = true;
            this.prescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.prescLabel.Location = new System.Drawing.Point(600, 408);
            this.prescLabel.Name = "prescLabel";
            this.prescLabel.Size = new System.Drawing.Size(154, 29);
            this.prescLabel.TabIndex = 11;
            this.prescLabel.Text = "Prescriptions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(280, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 35;
            // 
            // appointmentsBox
            // 
            this.appointmentsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appointmentsBox.Location = new System.Drawing.Point(30, 463);
            this.appointmentsBox.Multiline = true;
            this.appointmentsBox.Name = "appointmentsBox";
            this.appointmentsBox.ReadOnly = true;
            this.appointmentsBox.Size = new System.Drawing.Size(376, 172);
            this.appointmentsBox.TabIndex = 34;
            // 
            // upVisitsLabel
            // 
            this.upVisitsLabel.AutoSize = true;
            this.upVisitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.upVisitsLabel.Location = new System.Drawing.Point(78, 431);
            this.upVisitsLabel.Name = "upVisitsLabel";
            this.upVisitsLabel.Size = new System.Drawing.Size(276, 29);
            this.upVisitsLabel.TabIndex = 33;
            this.upVisitsLabel.Text = "Upcoming Appointments";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logOutButton.Location = new System.Drawing.Point(879, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 28);
            this.logOutButton.TabIndex = 39;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // nurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 650);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appointmentsBox);
            this.Controls.Add(this.upVisitsLabel);
            this.Controls.Add(this.prescBox);
            this.Controls.Add(this.prescLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vitalsTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pInfoBox);
            this.Controls.Add(this.pInfoLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPatientBox);
            this.Controls.Add(this.searchPLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "nurseForm";
            this.Text = "Nurse View";
            this.Load += new System.EventHandler(this.nurseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label searchPLabel;
        private System.Windows.Forms.TextBox searchPatientBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label pInfoLabel;
        private System.Windows.Forms.TextBox pInfoBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vitalsTBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox prescBox;
        private System.Windows.Forms.Label prescLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox appointmentsBox;
        private System.Windows.Forms.Label upVisitsLabel;
        private System.Windows.Forms.Button logOutButton;
    }
}