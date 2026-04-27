namespace CSCI455_EMR
{
    partial class loginForm
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
            this.passwordTBox = new System.Windows.Forms.TextBox();
            this.usernameTBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.registerTitleLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordTBox
            // 
            this.passwordTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.passwordTBox.Location = new System.Drawing.Point(326, 173);
            this.passwordTBox.Name = "passwordTBox";
            this.passwordTBox.Size = new System.Drawing.Size(279, 35);
            this.passwordTBox.TabIndex = 20;
            // 
            // usernameTBox
            // 
            this.usernameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.usernameTBox.Location = new System.Drawing.Point(326, 129);
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.Size = new System.Drawing.Size(279, 35);
            this.usernameTBox.TabIndex = 19;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.passwordLabel.Location = new System.Drawing.Point(194, 173);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(126, 29);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.usernameLabel.Location = new System.Drawing.Point(190, 132);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(130, 29);
            this.usernameLabel.TabIndex = 17;
            this.usernameLabel.Text = "Username:";
            // 
            // registerTitleLabel
            // 
            this.registerTitleLabel.AutoSize = true;
            this.registerTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.registerTitleLabel.Location = new System.Drawing.Point(211, 9);
            this.registerTitleLabel.Name = "registerTitleLabel";
            this.registerTitleLabel.Size = new System.Drawing.Size(378, 37);
            this.registerTitleLabel.TabIndex = 21;
            this.registerTitleLabel.Text = "Welcome to EMR System";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loginButton.Location = new System.Drawing.Point(398, 226);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(105, 42);
            this.loginButton.TabIndex = 24;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // newUserButton
            // 
            this.newUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.newUserButton.Location = new System.Drawing.Point(654, 396);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(134, 42);
            this.newUserButton.TabIndex = 25;
            this.newUserButton.Text = "New User";
            this.newUserButton.UseVisualStyleBackColor = true;
            this.newUserButton.Click += new System.EventHandler(this.newUserButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerTitleLabel);
            this.Controls.Add(this.passwordTBox);
            this.Controls.Add(this.usernameTBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Name = "loginForm";
            this.Text = "EMR Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTBox;
        private System.Windows.Forms.TextBox usernameTBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label registerTitleLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button newUserButton;
    }
}

