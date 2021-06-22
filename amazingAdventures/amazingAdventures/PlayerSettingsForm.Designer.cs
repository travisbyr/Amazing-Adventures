
namespace amazingAdventures
{
    partial class PlayerSettingsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.settingsEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Use = new System.Windows.Forms.Label();
            this.settingsPassword = new System.Windows.Forms.TextBox();
            this.settingsUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.usrnInvalidFirstLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(102, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Email:";
            // 
            // settingsEmail
            // 
            this.settingsEmail.BackColor = System.Drawing.Color.White;
            this.settingsEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsEmail.ForeColor = System.Drawing.Color.Black;
            this.settingsEmail.Location = new System.Drawing.Point(106, 237);
            this.settingsEmail.Margin = new System.Windows.Forms.Padding(2);
            this.settingsEmail.Name = "settingsEmail";
            this.settingsEmail.Size = new System.Drawing.Size(287, 29);
            this.settingsEmail.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(102, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Password:";
            // 
            // Use
            // 
            this.Use.AutoSize = true;
            this.Use.BackColor = System.Drawing.Color.Transparent;
            this.Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Use.ForeColor = System.Drawing.Color.Black;
            this.Use.Location = new System.Drawing.Point(102, 82);
            this.Use.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(102, 24);
            this.Use.TabIndex = 33;
            this.Use.Text = "Username:";
            // 
            // settingsPassword
            // 
            this.settingsPassword.BackColor = System.Drawing.Color.White;
            this.settingsPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsPassword.ForeColor = System.Drawing.Color.Black;
            this.settingsPassword.Location = new System.Drawing.Point(106, 173);
            this.settingsPassword.Margin = new System.Windows.Forms.Padding(2);
            this.settingsPassword.Name = "settingsPassword";
            this.settingsPassword.PasswordChar = '*';
            this.settingsPassword.Size = new System.Drawing.Size(287, 29);
            this.settingsPassword.TabIndex = 32;
            // 
            // settingsUsername
            // 
            this.settingsUsername.BackColor = System.Drawing.Color.White;
            this.settingsUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsUsername.Enabled = false;
            this.settingsUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.settingsUsername.ForeColor = System.Drawing.Color.Black;
            this.settingsUsername.Location = new System.Drawing.Point(106, 108);
            this.settingsUsername.Margin = new System.Windows.Forms.Padding(2);
            this.settingsUsername.Name = "settingsUsername";
            this.settingsUsername.Size = new System.Drawing.Size(287, 29);
            this.settingsUsername.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 47);
            this.label1.TabIndex = 30;
            this.label1.Text = "Settings";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.closeBtn.Location = new System.Drawing.Point(147, 323);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(199, 35);
            this.closeBtn.TabIndex = 42;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // usrnInvalidFirstLabel
            // 
            this.usrnInvalidFirstLabel.AutoSize = true;
            this.usrnInvalidFirstLabel.BackColor = System.Drawing.Color.Transparent;
            this.usrnInvalidFirstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.usrnInvalidFirstLabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.usrnInvalidFirstLabel.Location = new System.Drawing.Point(185, 332);
            this.usrnInvalidFirstLabel.MinimumSize = new System.Drawing.Size(128, 17);
            this.usrnInvalidFirstLabel.Name = "usrnInvalidFirstLabel";
            this.usrnInvalidFirstLabel.Size = new System.Drawing.Size(128, 17);
            this.usrnInvalidFirstLabel.TabIndex = 41;
            this.usrnInvalidFirstLabel.Text = "Incorrect Login";
            this.usrnInvalidFirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrnInvalidFirstLabel.Visible = false;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.saveBtn.Location = new System.Drawing.Point(147, 282);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(199, 35);
            this.saveBtn.TabIndex = 40;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // PlayerSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 372);
            this.ControlBox = false;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.usrnInvalidFirstLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.settingsEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.settingsPassword);
            this.Controls.Add(this.settingsUsername);
            this.Controls.Add(this.label1);
            this.Name = "PlayerSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Player Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox settingsEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Use;
        private System.Windows.Forms.TextBox settingsPassword;
        private System.Windows.Forms.TextBox settingsUsername;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label usrnInvalidFirstLabel;
        private System.Windows.Forms.Button saveBtn;
    }
}