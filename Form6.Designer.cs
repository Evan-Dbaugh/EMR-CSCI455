namespace CSCI455_EMR
{
    partial class adminForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchUserBox = new System.Windows.Forms.TextBox();
            this.searchULabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.pInfoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.viewFileButton = new System.Windows.Forms.Button();
            this.documentsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchButton.Location = new System.Drawing.Point(663, 80);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 42);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchUserBox
            // 
            this.searchUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchUserBox.Location = new System.Drawing.Point(204, 87);
            this.searchUserBox.Name = "searchUserBox";
            this.searchUserBox.Size = new System.Drawing.Size(453, 35);
            this.searchUserBox.TabIndex = 7;
            // 
            // searchULabel
            // 
            this.searchULabel.AutoSize = true;
            this.searchULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchULabel.Location = new System.Drawing.Point(18, 90);
            this.searchULabel.Name = "searchULabel";
            this.searchULabel.Size = new System.Drawing.Size(199, 29);
            this.searchULabel.TabIndex = 6;
            this.searchULabel.Text = "Enter Username: ";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.welcomeLabel.Location = new System.Drawing.Point(313, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(202, 37);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Admin Portal";
            // 
            // pInfoBox
            // 
            this.pInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pInfoBox.Location = new System.Drawing.Point(23, 152);
            this.pInfoBox.Multiline = true;
            this.pInfoBox.Name = "pInfoBox";
            this.pInfoBox.ReadOnly = true;
            this.pInfoBox.Size = new System.Drawing.Size(376, 198);
            this.pInfoBox.TabIndex = 9;
            this.pInfoBox.Text = "Name: \r\n\r\nEmail:\r\n\r\nAddress:\r\n\r\nRole:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(23, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uploadButton.Location = new System.Drawing.Point(696, 421);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(108, 25);
            this.uploadButton.TabIndex = 46;
            this.uploadButton.Text = "Upload File";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.downloadButton.Location = new System.Drawing.Point(582, 421);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(108, 25);
            this.downloadButton.TabIndex = 45;
            this.downloadButton.Text = "Download File";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // viewFileButton
            // 
            this.viewFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.viewFileButton.Location = new System.Drawing.Point(491, 421);
            this.viewFileButton.Name = "viewFileButton";
            this.viewFileButton.Size = new System.Drawing.Size(80, 25);
            this.viewFileButton.TabIndex = 44;
            this.viewFileButton.Text = "View File";
            this.viewFileButton.UseVisualStyleBackColor = true;
            this.viewFileButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // documentsList
            // 
            this.documentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.documentsList.FormattingEnabled = true;
            this.documentsList.ItemHeight = 20;
            this.documentsList.Location = new System.Drawing.Point(448, 171);
            this.documentsList.Name = "documentsList";
            this.documentsList.Size = new System.Drawing.Size(393, 244);
            this.documentsList.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(607, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Records";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logOutButton.Location = new System.Drawing.Point(790, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 28);
            this.logOutButton.TabIndex = 48;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 507);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.viewFileButton);
            this.Controls.Add(this.documentsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pInfoBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchUserBox);
            this.Controls.Add(this.searchULabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "adminForm";
            this.Text = "Admin View";
            this.Load += new System.EventHandler(this.adminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchUserBox;
        private System.Windows.Forms.Label searchULabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.TextBox pInfoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button viewFileButton;
        private System.Windows.Forms.ListBox documentsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutButton;
    }
}