
namespace AmazingAdventures
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.rgsrSecondLine = new System.Windows.Forms.Label();
            this.rgsrFirstLine = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Use = new System.Windows.Forms.Label();
            this.registerPassword = new System.Windows.Forms.TextBox();
            this.registerEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.registerUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rgsrSecondLine
            // 
            this.rgsrSecondLine.AutoSize = true;
            this.rgsrSecondLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgsrSecondLine.ForeColor = System.Drawing.Color.Red;
            this.rgsrSecondLine.Location = new System.Drawing.Point(122, 358);
            this.rgsrSecondLine.MinimumSize = new System.Drawing.Size(241, 16);
            this.rgsrSecondLine.Name = "rgsrSecondLine";
            this.rgsrSecondLine.Size = new System.Drawing.Size(241, 16);
            this.rgsrSecondLine.TabIndex = 27;
            this.rgsrSecondLine.Text = "Please enter a different username";
            this.rgsrSecondLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rgsrSecondLine.Visible = false;
            // 
            // rgsrFirstLine
            // 
            this.rgsrFirstLine.AutoSize = true;
            this.rgsrFirstLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rgsrFirstLine.ForeColor = System.Drawing.Color.Red;
            this.rgsrFirstLine.Location = new System.Drawing.Point(189, 338);
            this.rgsrFirstLine.MinimumSize = new System.Drawing.Size(117, 17);
            this.rgsrFirstLine.Name = "rgsrFirstLine";
            this.rgsrFirstLine.Size = new System.Drawing.Size(117, 17);
            this.rgsrFirstLine.TabIndex = 26;
            this.rgsrFirstLine.Text = "Invalid Username";
            this.rgsrFirstLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rgsrFirstLine.Visible = false;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.registerBtn.Location = new System.Drawing.Point(147, 296);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(199, 35);
            this.registerBtn.TabIndex = 25;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(100, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password:";
            // 
            // Use
            // 
            this.Use.AutoSize = true;
            this.Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Use.Location = new System.Drawing.Point(100, 95);
            this.Use.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(62, 24);
            this.Use.TabIndex = 20;
            this.Use.Text = "Email:";
            // 
            // registerPassword
            // 
            this.registerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.registerPassword.Location = new System.Drawing.Point(104, 186);
            this.registerPassword.Margin = new System.Windows.Forms.Padding(2);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.PasswordChar = '*';
            this.registerPassword.Size = new System.Drawing.Size(287, 29);
            this.registerPassword.TabIndex = 19;
            // 
            // registerEmail
            // 
            this.registerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerEmail.Location = new System.Drawing.Point(104, 121);
            this.registerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(287, 29);
            this.registerEmail.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 47);
            this.label1.TabIndex = 17;
            this.label1.Text = "Amazing Adventures";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(100, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Username:";
            // 
            // registerUsername
            // 
            this.registerUsername.Enabled = false;
            this.registerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUsername.Location = new System.Drawing.Point(104, 250);
            this.registerUsername.Margin = new System.Windows.Forms.Padding(2);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(287, 29);
            this.registerUsername.TabIndex = 28;
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.registerBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(492, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.rgsrSecondLine);
            this.Controls.Add(this.rgsrFirstLine);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.registerEmail);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rgsrSecondLine;
        private System.Windows.Forms.Label rgsrFirstLine;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Use;
        private System.Windows.Forms.TextBox registerPassword;
        private System.Windows.Forms.TextBox registerEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registerUsername;
    }
}