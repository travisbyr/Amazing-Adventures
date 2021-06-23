
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.firstLoseTxt = new System.Windows.Forms.Label();
            this.secondLoseTxt = new System.Windows.Forms.Label();
            this.pointsEndLabel = new System.Windows.Forms.Label();
            this.usrnValidSecondLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.firstLoseTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.firstLoseTxt.Location = new System.Drawing.Point(67, 41);
            this.firstLoseTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstLoseTxt.Name = "firstLoseTxt";
            this.firstLoseTxt.Size = new System.Drawing.Size(353, 47);
            this.firstLoseTxt.TabIndex = 17;
            this.firstLoseTxt.Text = "Better luck next time";
            this.firstLoseTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondLoseTxt
            // 
            this.secondLoseTxt.AutoSize = true;
            this.secondLoseTxt.BackColor = System.Drawing.Color.Transparent;
            this.secondLoseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.secondLoseTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.secondLoseTxt.Location = new System.Drawing.Point(155, 91);
            this.secondLoseTxt.MinimumSize = new System.Drawing.Size(165, 17);
            this.secondLoseTxt.Name = "secondLoseTxt";
            this.secondLoseTxt.Size = new System.Drawing.Size(167, 22);
            this.secondLoseTxt.TabIndex = 26;
            this.secondLoseTxt.Text = "You stood on a trap";
            this.secondLoseTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointsEndLabel
            // 
            this.pointsEndLabel.AutoSize = true;
            this.pointsEndLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pointsEndLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pointsEndLabel.Location = new System.Drawing.Point(163, 189);
            this.pointsEndLabel.MinimumSize = new System.Drawing.Size(165, 17);
            this.pointsEndLabel.Name = "pointsEndLabel";
            this.pointsEndLabel.Size = new System.Drawing.Size(165, 25);
            this.pointsEndLabel.TabIndex = 28;
            this.pointsEndLabel.Text = "15 points";
            this.pointsEndLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usrnValidSecondLine
            // 
            this.usrnValidSecondLine.AutoSize = true;
            this.usrnValidSecondLine.BackColor = System.Drawing.Color.Transparent;
            this.usrnValidSecondLine.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.usrnValidSecondLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usrnValidSecondLine.Location = new System.Drawing.Point(116, 153);
            this.usrnValidSecondLine.MinimumSize = new System.Drawing.Size(263, 16);
            this.usrnValidSecondLine.Name = "usrnValidSecondLine";
            this.usrnValidSecondLine.Size = new System.Drawing.Size(263, 29);
            this.usrnValidSecondLine.TabIndex = 27;
            this.usrnValidSecondLine.Text = "Your score was:";
            this.usrnValidSecondLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameLoseForm
            // 
            this.AcceptButton = this.closeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::amazingAdventures.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(492, 357);
            this.ControlBox = false;
            this.Controls.Add(this.usrnValidSecondLine);
            this.Controls.Add(this.pointsEndLabel);
            this.Controls.Add(this.secondLoseTxt);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.firstLoseTxt);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(508, 396);
            this.MinimumSize = new System.Drawing.Size(508, 396);
            this.Name = "GameLoseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - End";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label firstLoseTxt;
        public System.Windows.Forms.Label secondLoseTxt;
        public System.Windows.Forms.Label pointsEndLabel;
        public System.Windows.Forms.Label usrnValidSecondLine;
    }
}