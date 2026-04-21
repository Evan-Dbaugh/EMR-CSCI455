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
            this.registerTitleLabel = new System.Windows.Forms.Label();
            this.pInfoBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.documentsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchButton.Location = new System.Drawing.Point(639, 83);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(105, 42);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchUserBox
            // 
            this.searchUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.searchUserBox.Location = new System.Drawing.Point(163, 87);
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
            this.searchULabel.Size = new System.Drawing.Size(139, 29);
            this.searchULabel.TabIndex = 6;
            this.searchULabel.Text = "Enter User: ";
            // 
            // registerTitleLabel
            // 
            this.registerTitleLabel.AutoSize = true;
            this.registerTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.registerTitleLabel.Location = new System.Drawing.Point(313, 9);
            this.registerTitleLabel.Name = "registerTitleLabel";
            this.registerTitleLabel.Size = new System.Drawing.Size(202, 37);
            this.registerTitleLabel.TabIndex = 5;
            this.registerTitleLabel.Text = "Admin Portal";
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
            this.pInfoBox.Text = "Name: \r\n\r\nEmail:\r\n\r\nAddress:\r\n\r\nRole:\r\n\r\nPermissions:\r\n";
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(767, 421);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 25);
            this.button3.TabIndex = 47;
            this.button3.Text = "New File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(653, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 25);
            this.button2.TabIndex = 46;
            this.button2.Text = "Upload File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(539, 421);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 25);
            this.button4.TabIndex = 45;
            this.button4.Text = "Download File";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.downloadButton.Location = new System.Drawing.Point(448, 421);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(80, 25);
            this.downloadButton.TabIndex = 44;
            this.downloadButton.Text = "View File";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // documentsList
            // 
            this.documentsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.documentsList.FormattingEnabled = true;
            this.documentsList.ItemHeight = 20;
            this.documentsList.Items.AddRange(new object[] {
            "Document 1",
            "Document 2",
            "Document 3",
            "Document 4"});
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
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 507);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.documentsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pInfoBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchUserBox);
            this.Controls.Add(this.searchULabel);
            this.Controls.Add(this.registerTitleLabel);
            this.Name = "adminForm";
            this.Text = "Admin View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchUserBox;
        private System.Windows.Forms.Label searchULabel;
        private System.Windows.Forms.Label registerTitleLabel;
        private System.Windows.Forms.TextBox pInfoBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.ListBox documentsList;
        private System.Windows.Forms.Label label1;
    }
}