namespace CSCI455_EMR
{
    partial class doctorForm
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
            this.prescBox = new System.Windows.Forms.TextBox();
            this.prescLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vitalsTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pInfoBox = new System.Windows.Forms.TextBox();
            this.pInfoLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchPatientBox = new System.Windows.Forms.TextBox();
            this.searchPLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.documentsList = new System.Windows.Forms.ListBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.appointmentsBox = new System.Windows.Forms.TextBox();
            this.upVisitsLabel = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prescBox
            // 
            this.prescBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.prescBox.Location = new System.Drawing.Point(13, 559);
            this.prescBox.Multiline = true;
            this.prescBox.Name = "prescBox";
            this.prescBox.ReadOnly = true;
            this.prescBox.Size = new System.Drawing.Size(376, 76);
            this.prescBox.TabIndex = 24;
            // 
            // prescLabel
            // 
            this.prescLabel.AutoSize = true;
            this.prescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.prescLabel.Location = new System.Drawing.Point(127, 527);
            this.prescLabel.Name = "prescLabel";
            this.prescLabel.Size = new System.Drawing.Size(154, 29);
            this.prescLabel.TabIndex = 23;
            this.prescLabel.Text = "Prescriptions";
            // 
            // notesBox
            // 
            this.notesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.notesBox.Location = new System.Drawing.Point(9, 671);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.ReadOnly = true;
            this.notesBox.Size = new System.Drawing.Size(376, 76);
            this.notesBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.Location = new System.Drawing.Point(164, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Notes";
            // 
            // vitalsTBox
            // 
            this.vitalsTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vitalsTBox.Location = new System.Drawing.Point(9, 436);
            this.vitalsTBox.Multiline = true;
            this.vitalsTBox.Name = "vitalsTBox";
            this.vitalsTBox.ReadOnly = true;
            this.vitalsTBox.Size = new System.Drawing.Size(376, 76);
            this.vitalsTBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(117, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Patient Vitals";
            // 
            // pInfoBox
            // 
            this.pInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pInfoBox.Location = new System.Drawing.Point(13, 150);
            this.pInfoBox.Multiline = true;
            this.pInfoBox.Name = "pInfoBox";
            this.pInfoBox.ReadOnly = true;
            this.pInfoBox.Size = new System.Drawing.Size(376, 251);
            this.pInfoBox.TabIndex = 18;
            this.pInfoBox.Text = "Name: \r\n\r\nEmail:\r\n\r\nAddress:\r\n\r\nDate of Birth:\r\n\r\nEmergency Contact:";
            // 
            // pInfoLabel
            // 
            this.pInfoLabel.AutoSize = true;
            this.pInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pInfoLabel.Location = new System.Drawing.Point(101, 118);
            this.pInfoLabel.Name = "pInfoLabel";
            this.pInfoLabel.Size = new System.Drawing.Size(212, 29);
            this.pInfoLabel.TabIndex = 17;
            this.pInfoLabel.Text = "Patient Information";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchButton.Location = new System.Drawing.Point(616, 63);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 42);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchPatientBox
            // 
            this.searchPatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchPatientBox.Location = new System.Drawing.Point(251, 67);
            this.searchPatientBox.Name = "searchPatientBox";
            this.searchPatientBox.Size = new System.Drawing.Size(359, 35);
            this.searchPatientBox.TabIndex = 15;
            // 
            // searchPLabel
            // 
            this.searchPLabel.AutoSize = true;
            this.searchPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchPLabel.Location = new System.Drawing.Point(12, 70);
            this.searchPLabel.Name = "searchPLabel";
            this.searchPLabel.Size = new System.Drawing.Size(233, 29);
            this.searchPLabel.TabIndex = 14;
            this.searchPLabel.Text = "Enter Patient Name: ";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.welcomeLabel.Location = new System.Drawing.Point(437, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(254, 37);
            this.welcomeLabel.TabIndex = 13;
            this.welcomeLabel.Text = "Welcome Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(660, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Patient Records";
            // 
            // documentsList
            // 
            this.documentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.documentsList.FormattingEnabled = true;
            this.documentsList.ItemHeight = 20;
            this.documentsList.Location = new System.Drawing.Point(560, 150);
            this.documentsList.Name = "documentsList";
            this.documentsList.Size = new System.Drawing.Size(393, 244);
            this.documentsList.TabIndex = 37;
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.downloadButton.Location = new System.Drawing.Point(560, 400);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(80, 25);
            this.downloadButton.TabIndex = 38;
            this.downloadButton.Text = "View File";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(651, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 25);
            this.button1.TabIndex = 39;
            this.button1.Text = "Download File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(765, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 25);
            this.button2.TabIndex = 40;
            this.button2.Text = "Upload File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(879, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 25);
            this.button3.TabIndex = 41;
            this.button3.Text = "New File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(810, 596);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 44;
            // 
            // appointmentsBox
            // 
            this.appointmentsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appointmentsBox.Location = new System.Drawing.Point(560, 478);
            this.appointmentsBox.Multiline = true;
            this.appointmentsBox.Name = "appointmentsBox";
            this.appointmentsBox.ReadOnly = true;
            this.appointmentsBox.Size = new System.Drawing.Size(393, 172);
            this.appointmentsBox.TabIndex = 43;
            this.appointmentsBox.Text = "3/31/26 - 11:00am - Example Appointment";
            // 
            // upVisitsLabel
            // 
            this.upVisitsLabel.AutoSize = true;
            this.upVisitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.upVisitsLabel.Location = new System.Drawing.Point(608, 446);
            this.upVisitsLabel.Name = "upVisitsLabel";
            this.upVisitsLabel.Size = new System.Drawing.Size(276, 29);
            this.upVisitsLabel.TabIndex = 42;
            this.upVisitsLabel.Text = "Upcoming Appointments";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logOutButton.Location = new System.Drawing.Point(941, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 28);
            this.logOutButton.TabIndex = 45;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // doctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 785);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.appointmentsBox);
            this.Controls.Add(this.upVisitsLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.documentsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prescBox);
            this.Controls.Add(this.prescLabel);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vitalsTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pInfoBox);
            this.Controls.Add(this.pInfoLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchPatientBox);
            this.Controls.Add(this.searchPLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "doctorForm";
            this.Text = "Doctor View";
            this.Load += new System.EventHandler(this.doctorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prescBox;
        private System.Windows.Forms.Label prescLabel;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vitalsTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pInfoBox;
        private System.Windows.Forms.Label pInfoLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchPatientBox;
        private System.Windows.Forms.Label searchPLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox documentsList;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox appointmentsBox;
        private System.Windows.Forms.Label upVisitsLabel;
        private System.Windows.Forms.Button logOutButton;
    }
}