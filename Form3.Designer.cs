namespace CSCI455_EMR
{
    partial class patientForm
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
            this.patientLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.pastBox = new System.Windows.Forms.TextBox();
            this.pastLabel = new System.Windows.Forms.Label();
            this.appointmentsBox = new System.Windows.Forms.TextBox();
            this.upVisitsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.documentsList = new System.Windows.Forms.ListBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.patientLabel.Location = new System.Drawing.Point(204, 9);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(371, 37);
            this.patientLabel.TabIndex = 1;
            this.patientLabel.Text = "Welcome [Patient Name]";
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uploadButton.Location = new System.Drawing.Point(696, 413);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(92, 25);
            this.uploadButton.TabIndex = 27;
            this.uploadButton.Text = "Upload File";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // pastBox
            // 
            this.pastBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pastBox.Location = new System.Drawing.Point(12, 300);
            this.pastBox.Multiline = true;
            this.pastBox.Name = "pastBox";
            this.pastBox.ReadOnly = true;
            this.pastBox.Size = new System.Drawing.Size(376, 138);
            this.pastBox.TabIndex = 31;
            // 
            // pastLabel
            // 
            this.pastLabel.AutoSize = true;
            this.pastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.pastLabel.Location = new System.Drawing.Point(60, 268);
            this.pastLabel.Name = "pastLabel";
            this.pastLabel.Size = new System.Drawing.Size(260, 29);
            this.pastLabel.TabIndex = 30;
            this.pastLabel.Text = "Previous Appointments";
            // 
            // appointmentsBox
            // 
            this.appointmentsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appointmentsBox.Location = new System.Drawing.Point(12, 93);
            this.appointmentsBox.Multiline = true;
            this.appointmentsBox.Name = "appointmentsBox";
            this.appointmentsBox.ReadOnly = true;
            this.appointmentsBox.Size = new System.Drawing.Size(376, 172);
            this.appointmentsBox.TabIndex = 29;
            // 
            // upVisitsLabel
            // 
            this.upVisitsLabel.AutoSize = true;
            this.upVisitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.upVisitsLabel.Location = new System.Drawing.Point(60, 61);
            this.upVisitsLabel.Name = "upVisitsLabel";
            this.upVisitsLabel.Size = new System.Drawing.Size(276, 29);
            this.upVisitsLabel.TabIndex = 28;
            this.upVisitsLabel.Text = "Upcoming Appointments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(262, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 32;
            // 
            // scheduleButton
            // 
            this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.scheduleButton.Location = new System.Drawing.Point(464, 61);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(267, 42);
            this.scheduleButton.TabIndex = 33;
            this.scheduleButton.Text = "Schedule Appointment";
            this.scheduleButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(394, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Document Search:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(542, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 26);
            this.textBox1.TabIndex = 35;
            // 
            // documentsList
            // 
            this.documentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.documentsList.FormattingEnabled = true;
            this.documentsList.ItemHeight = 20;
            this.documentsList.Location = new System.Drawing.Point(398, 185);
            this.documentsList.Name = "documentsList";
            this.documentsList.Size = new System.Drawing.Size(390, 204);
            this.documentsList.TabIndex = 36;
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.downloadButton.Location = new System.Drawing.Point(398, 395);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(108, 25);
            this.downloadButton.TabIndex = 37;
            this.downloadButton.Text = "Download File";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logOutButton.Location = new System.Drawing.Point(713, 10);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 28);
            this.logOutButton.TabIndex = 38;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // patientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.documentsList);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pastBox);
            this.Controls.Add(this.pastLabel);
            this.Controls.Add(this.appointmentsBox);
            this.Controls.Add(this.upVisitsLabel);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.patientLabel);
            this.Name = "patientForm";
            this.Text = "Patient View";
            this.Load += new System.EventHandler(this.patientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.TextBox pastBox;
        private System.Windows.Forms.Label pastLabel;
        private System.Windows.Forms.TextBox appointmentsBox;
        private System.Windows.Forms.Label upVisitsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox documentsList;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button logOutButton;
    }
}