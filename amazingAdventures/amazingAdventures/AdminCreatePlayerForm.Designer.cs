
namespace amazingAdventures
{
    partial class AdminCreatePlayerForm
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.usrnInvalidFirstLabel = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Use = new System.Windows.Forms.Label();
            this.createPassword = new System.Windows.Forms.TextBox();
            this.createUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.closeBtn.Location = new System.Drawing.Point(146, 269);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(199, 35);
            this.closeBtn.TabIndex = 52;
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
            this.usrnInvalidFirstLabel.Location = new System.Drawing.Point(184, 278);
            this.usrnInvalidFirstLabel.MinimumSize = new System.Drawing.Size(128, 17);
            this.usrnInvalidFirstLabel.Name = "usrnInvalidFirstLabel";
            this.usrnInvalidFirstLabel.Size = new System.Drawing.Size(128, 17);
            this.usrnInvalidFirstLabel.TabIndex = 51;
            this.usrnInvalidFirstLabel.Text = "Incorrect Login";
            this.usrnInvalidFirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrnInvalidFirstLabel.Visible = false;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createBtn.Location = new System.Drawing.Point(146, 228);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(199, 35);
            this.createBtn.TabIndex = 50;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(101, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Password:";
            // 
            // Use
            // 
            this.Use.AutoSize = true;
            this.Use.BackColor = System.Drawing.Color.Transparent;
            this.Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Use.ForeColor = System.Drawing.Color.Black;
            this.Use.Location = new System.Drawing.Point(101, 77);
            this.Use.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(102, 24);
            this.Use.TabIndex = 46;
            this.Use.Text = "Username:";
            // 
            // createPassword
            // 
            this.createPassword.BackColor = System.Drawing.Color.White;
            this.createPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createPassword.ForeColor = System.Drawing.Color.Black;
            this.createPassword.Location = new System.Drawing.Point(105, 168);
            this.createPassword.Margin = new System.Windows.Forms.Padding(2);
            this.createPassword.Name = "createPassword";
            this.createPassword.PasswordChar = '*';
            this.createPassword.Size = new System.Drawing.Size(287, 29);
            this.createPassword.TabIndex = 45;
            // 
            // createUsername
            // 
            this.createUsername.BackColor = System.Drawing.Color.White;
            this.createUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createUsername.ForeColor = System.Drawing.Color.Black;
            this.createUsername.Location = new System.Drawing.Point(105, 103);
            this.createUsername.Margin = new System.Windows.Forms.Padding(2);
            this.createUsername.Name = "createUsername";
            this.createUsername.Size = new System.Drawing.Size(287, 29);
            this.createUsername.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(135, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.MaximumSize = new System.Drawing.Size(231, 47);
            this.label1.MinimumSize = new System.Drawing.Size(231, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 47);
            this.label1.TabIndex = 53;
            this.label1.Text = "Create Player";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-6, -8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(503, 70);
            this.flowLayoutPanel1.TabIndex = 54;
            // 
            // AdminCreatePlayerForm
            // 
            this.AcceptButton = this.createBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 341);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.usrnInvalidFirstLabel);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.createPassword);
            this.Controls.Add(this.createUsername);
            this.MaximumSize = new System.Drawing.Size(508, 380);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(508, 380);
            this.Name = "AdminCreatePlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Create Player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label usrnInvalidFirstLabel;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Use;
        private System.Windows.Forms.TextBox createPassword;
        private System.Windows.Forms.TextBox createUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}