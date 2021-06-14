
namespace AmazingAdventures
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Use = new System.Windows.Forms.Label();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usrnInvalidFirstLabel = new System.Windows.Forms.Label();
            this.usrnInvalidSecondLabel = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.usrnValidSecondLine = new System.Windows.Forms.Label();
            this.usrnValidFirstLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginBtn.Location = new System.Drawing.Point(147, 235);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(199, 35);
            this.loginBtn.TabIndex = 11;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(100, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password:";
            // 
            // Use
            // 
            this.Use.AutoSize = true;
            this.Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Use.Location = new System.Drawing.Point(100, 98);
            this.Use.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(102, 24);
            this.Use.TabIndex = 9;
            this.Use.Text = "Username:";
            // 
            // loginPassword
            // 
            this.loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginPassword.Location = new System.Drawing.Point(104, 189);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(287, 29);
            this.loginPassword.TabIndex = 8;
            // 
            // loginUsername
            // 
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.Location = new System.Drawing.Point(104, 124);
            this.loginUsername.Margin = new System.Windows.Forms.Padding(2);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(287, 29);
            this.loginUsername.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amazing Adventures";
            // 
            // usrnInvalidFirstLabel
            // 
            this.usrnInvalidFirstLabel.AutoSize = true;
            this.usrnInvalidFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usrnInvalidFirstLabel.ForeColor = System.Drawing.Color.Red;
            this.usrnInvalidFirstLabel.Location = new System.Drawing.Point(185, 284);
            this.usrnInvalidFirstLabel.MinimumSize = new System.Drawing.Size(128, 17);
            this.usrnInvalidFirstLabel.Name = "usrnInvalidFirstLabel";
            this.usrnInvalidFirstLabel.Size = new System.Drawing.Size(128, 17);
            this.usrnInvalidFirstLabel.TabIndex = 12;
            this.usrnInvalidFirstLabel.Text = "Incorrect Login";
            this.usrnInvalidFirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrnInvalidFirstLabel.Visible = false;
            // 
            // usrnInvalidSecondLabel
            // 
            this.usrnInvalidSecondLabel.AutoSize = true;
            this.usrnInvalidSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnInvalidSecondLabel.ForeColor = System.Drawing.Color.Red;
            this.usrnInvalidSecondLabel.Location = new System.Drawing.Point(86, 304);
            this.usrnInvalidSecondLabel.MinimumSize = new System.Drawing.Size(323, 16);
            this.usrnInvalidSecondLabel.Name = "usrnInvalidSecondLabel";
            this.usrnInvalidSecondLabel.Size = new System.Drawing.Size(323, 16);
            this.usrnInvalidSecondLabel.TabIndex = 13;
            this.usrnInvalidSecondLabel.Text = "Email and administrator to unlock this account";
            this.usrnInvalidSecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrnInvalidSecondLabel.Visible = false;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.registerBtn.Location = new System.Drawing.Point(147, 274);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(199, 35);
            this.registerBtn.TabIndex = 14;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Visible = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // usrnValidSecondLine
            // 
            this.usrnValidSecondLine.AutoSize = true;
            this.usrnValidSecondLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnValidSecondLine.ForeColor = System.Drawing.Color.Red;
            this.usrnValidSecondLine.Location = new System.Drawing.Point(121, 336);
            this.usrnValidSecondLine.MinimumSize = new System.Drawing.Size(263, 16);
            this.usrnValidSecondLine.Name = "usrnValidSecondLine";
            this.usrnValidSecondLine.Size = new System.Drawing.Size(263, 16);
            this.usrnValidSecondLine.TabIndex = 16;
            this.usrnValidSecondLine.Text = "Press \'Register\' to create an account";
            this.usrnValidSecondLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrnValidSecondLine.Visible = false;
            // 
            // usrnValidFirstLine
            // 
            this.usrnValidFirstLine.AutoSize = true;
            this.usrnValidFirstLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usrnValidFirstLine.ForeColor = System.Drawing.Color.Red;
            this.usrnValidFirstLine.Location = new System.Drawing.Point(174, 316);
            this.usrnValidFirstLine.MinimumSize = new System.Drawing.Size(165, 17);
            this.usrnValidFirstLine.Name = "usrnValidFirstLine";
            this.usrnValidFirstLine.Size = new System.Drawing.Size(165, 17);
            this.usrnValidFirstLine.TabIndex = 15;
            this.usrnValidFirstLine.Text = "New Username Detected";
            this.usrnValidFirstLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrnValidFirstLine.Visible = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(492, 372);
            this.Controls.Add(this.usrnValidSecondLine);
            this.Controls.Add(this.usrnValidFirstLine);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.usrnInvalidSecondLabel);
            this.Controls.Add(this.usrnInvalidFirstLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Use;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usrnInvalidFirstLabel;
        private System.Windows.Forms.Label usrnInvalidSecondLabel;
        public System.Windows.Forms.Button registerBtn;
        public System.Windows.Forms.Label usrnValidSecondLine;
        public System.Windows.Forms.Label usrnValidFirstLine;
    }
}

