
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
            this.closeBtn = new System.Windows.Forms.Button();
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
            this.usrnValidSecondLine.ForeColor = System.Drawing.Color.LawnGreen;
            this.usrnValidSecondLine.Location = new System.Drawing.Point(-58, 31);
            this.usrnValidSecondLine.MinimumSize = new System.Drawing.Size(263, 16);
            this.usrnValidSecondLine.Name = "usrnValidSecondLine";
            this.usrnValidSecondLine.Size = new System.Drawing.Size(263, 24);
            this.usrnValidSecondLine.TabIndex = 27;
            this.usrnValidSecondLine.Text = "Your score was:";
            this.usrnValidSecondLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondLoseTxt
            // 
            this.secondLoseTxt.AutoSize = true;
            this.secondLoseTxt.BackColor = System.Drawing.Color.Transparent;
            this.secondLoseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.secondLoseTxt.ForeColor = System.Drawing.Color.PaleGreen;
            this.secondLoseTxt.Location = new System.Drawing.Point(161, 91);
            this.secondLoseTxt.MinimumSize = new System.Drawing.Size(165, 17);
            this.secondLoseTxt.Name = "secondLoseTxt";
            this.secondLoseTxt.Size = new System.Drawing.Size(165, 22);
            this.secondLoseTxt.TabIndex = 26;
            this.secondLoseTxt.Text = "You hit a trap!";
            this.secondLoseTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.closeBtn.Location = new System.Drawing.Point(144, 277);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(199, 35);
            this.closeBtn.TabIndex = 22;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // firstLoseTxt
            // 
            this.firstLoseTxt.AutoSize = true;
            this.firstLoseTxt.BackColor = System.Drawing.Color.Transparent;
            this.firstLoseTxt.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLoseTxt.ForeColor = System.Drawing.Color.PaleGreen;
            this.firstLoseTxt.Location = new System.Drawing.Point(67, 41);
            this.firstLoseTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstLoseTxt.Name = "firstLoseTxt";
            this.firstLoseTxt.Size = new System.Drawing.Size(353, 47);
            this.firstLoseTxt.TabIndex = 17;
            this.firstLoseTxt.Text = "Better luck next time";
            this.firstLoseTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointsEndLabel
            // 
            this.pointsEndLabel.AutoSize = true;
            this.pointsEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pointsEndLabel.ForeColor = System.Drawing.Color.Lime;
            this.pointsEndLabel.Location = new System.Drawing.Point(-11, 67);
            this.pointsEndLabel.MinimumSize = new System.Drawing.Size(165, 17);
            this.pointsEndLabel.Name = "pointsEndLabel";
            this.pointsEndLabel.Size = new System.Drawing.Size(165, 20);
            this.pointsEndLabel.TabIndex = 28;
            this.pointsEndLabel.Text = "15 points";
            this.pointsEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.usrnValidSecondLine);
            this.panel1.Controls.Add(this.pointsEndLabel);
            this.panel1.Location = new System.Drawing.Point(171, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 115);
            this.panel1.TabIndex = 29;
            // 
            // GameLoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::amazingAdventures.Properties.Resources.jungle2;
            this.ClientSize = new System.Drawing.Size(492, 357);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.secondLoseTxt);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.firstLoseTxt);
            this.Name = "GameLoseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - End";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label usrnValidSecondLine;
        public System.Windows.Forms.Label secondLoseTxt;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label firstLoseTxt;
        public System.Windows.Forms.Label pointsEndLabel;
        private System.Windows.Forms.Panel panel1;
    }
}