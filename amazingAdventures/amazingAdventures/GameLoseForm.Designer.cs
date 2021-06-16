
namespace amazingAdventures
{
    partial class GameLoseForm
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
            this.usrnValidSecondLine = new System.Windows.Forms.Label();
            this.secondLoseTxt = new System.Windows.Forms.Label();
            this.closeFrmBtn = new System.Windows.Forms.Button();
            this.tryAgainBtn = new System.Windows.Forms.Button();
            this.firstLoseTxt = new System.Windows.Forms.Label();
            this.pointsEndLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usrnValidSecondLine
            // 
            this.usrnValidSecondLine.AutoSize = true;
            this.usrnValidSecondLine.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold);
            this.usrnValidSecondLine.ForeColor = System.Drawing.Color.Black;
            this.usrnValidSecondLine.Location = new System.Drawing.Point(7, 24);
            this.usrnValidSecondLine.MinimumSize = new System.Drawing.Size(263, 16);
            this.usrnValidSecondLine.Name = "usrnValidSecondLine";
            this.usrnValidSecondLine.Size = new System.Drawing.Size(263, 24);
            this.usrnValidSecondLine.TabIndex = 27;
            this.usrnValidSecondLine.Text = "Your score was:";
            this.usrnValidSecondLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usrnValidSecondLine.Visible = false;
            // 
            // secondLoseTxt
            // 
            this.secondLoseTxt.AutoSize = true;
            this.secondLoseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.secondLoseTxt.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.secondLoseTxt.Location = new System.Drawing.Point(135, 91);
            this.secondLoseTxt.MinimumSize = new System.Drawing.Size(165, 17);
            this.secondLoseTxt.Name = "secondLoseTxt";
            this.secondLoseTxt.Size = new System.Drawing.Size(198, 17);
            this.secondLoseTxt.TabIndex = 26;
            this.secondLoseTxt.Text = "Sadly the trap has beaten you";
            this.secondLoseTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.secondLoseTxt.Visible = false;
            // 
            // closeFrmBtn
            // 
            this.closeFrmBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeFrmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFrmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.closeFrmBtn.Location = new System.Drawing.Point(257, 271);
            this.closeFrmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeFrmBtn.Name = "closeFrmBtn";
            this.closeFrmBtn.Size = new System.Drawing.Size(199, 35);
            this.closeFrmBtn.TabIndex = 25;
            this.closeFrmBtn.Text = "Close";
            this.closeFrmBtn.UseVisualStyleBackColor = false;
            this.closeFrmBtn.Visible = false;
            // 
            // tryAgainBtn
            // 
            this.tryAgainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tryAgainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tryAgainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tryAgainBtn.Location = new System.Drawing.Point(38, 271);
            this.tryAgainBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tryAgainBtn.Name = "tryAgainBtn";
            this.tryAgainBtn.Size = new System.Drawing.Size(199, 35);
            this.tryAgainBtn.TabIndex = 22;
            this.tryAgainBtn.Text = "Try Again";
            this.tryAgainBtn.UseVisualStyleBackColor = false;
            // 
            // firstLoseTxt
            // 
            this.firstLoseTxt.AutoSize = true;
            this.firstLoseTxt.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLoseTxt.Location = new System.Drawing.Point(59, 41);
            this.firstLoseTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstLoseTxt.Name = "firstLoseTxt";
            this.firstLoseTxt.Size = new System.Drawing.Size(374, 47);
            this.firstLoseTxt.TabIndex = 17;
            this.firstLoseTxt.Text = "Well that lasted long...";
            this.firstLoseTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointsEndLabel
            // 
            this.pointsEndLabel.AutoSize = true;
            this.pointsEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pointsEndLabel.ForeColor = System.Drawing.Color.Black;
            this.pointsEndLabel.Location = new System.Drawing.Point(58, 56);
            this.pointsEndLabel.MinimumSize = new System.Drawing.Size(165, 17);
            this.pointsEndLabel.Name = "pointsEndLabel";
            this.pointsEndLabel.Size = new System.Drawing.Size(165, 20);
            this.pointsEndLabel.TabIndex = 28;
            this.pointsEndLabel.Text = "15 points";
            this.pointsEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pointsEndLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usrnValidSecondLine);
            this.panel1.Controls.Add(this.pointsEndLabel);
            this.panel1.Location = new System.Drawing.Point(100, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 110);
            this.panel1.TabIndex = 29;
            // 
            // GameLoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(492, 372);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.secondLoseTxt);
            this.Controls.Add(this.closeFrmBtn);
            this.Controls.Add(this.tryAgainBtn);
            this.Controls.Add(this.firstLoseTxt);
            this.Name = "GameLoseForm";
            this.Text = "Amazing Adventures - End";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label usrnValidSecondLine;
        public System.Windows.Forms.Label secondLoseTxt;
        public System.Windows.Forms.Button closeFrmBtn;
        private System.Windows.Forms.Button tryAgainBtn;
        private System.Windows.Forms.Label firstLoseTxt;
        public System.Windows.Forms.Label pointsEndLabel;
        private System.Windows.Forms.Panel panel1;
    }
}