
namespace amazingAdventures
{
    partial class NewGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGameForm));
            this.Use = new System.Windows.Forms.Label();
            this.gameNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createGameBtn = new System.Windows.Forms.Button();
            this.cancelGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Use
            // 
            this.Use.AutoSize = true;
            this.Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Use.Location = new System.Drawing.Point(217, 95);
            this.Use.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(66, 24);
            this.Use.TabIndex = 33;
            this.Use.Text = "Name:";
            // 
            // gameNameInput
            // 
            this.gameNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameInput.Location = new System.Drawing.Point(104, 121);
            this.gameNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.gameNameInput.Name = "gameNameInput";
            this.gameNameInput.Size = new System.Drawing.Size(287, 29);
            this.gameNameInput.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(177, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "New Game";
            // 
            // createGameBtn
            // 
            this.createGameBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createGameBtn.Location = new System.Drawing.Point(288, 202);
            this.createGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createGameBtn.Name = "createGameBtn";
            this.createGameBtn.Size = new System.Drawing.Size(130, 35);
            this.createGameBtn.TabIndex = 34;
            this.createGameBtn.Text = "Create";
            this.createGameBtn.UseVisualStyleBackColor = false;
            this.createGameBtn.Click += new System.EventHandler(this.createGameBtn_Click);
            // 
            // cancelGameBtn
            // 
            this.cancelGameBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cancelGameBtn.Location = new System.Drawing.Point(69, 202);
            this.cancelGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelGameBtn.Name = "cancelGameBtn";
            this.cancelGameBtn.Size = new System.Drawing.Size(139, 35);
            this.cancelGameBtn.TabIndex = 35;
            this.cancelGameBtn.Text = "Cancel";
            this.cancelGameBtn.UseVisualStyleBackColor = false;
            this.cancelGameBtn.Click += new System.EventHandler(this.cancelGameBtn_Click);
            // 
            // NewGameForm
            // 
            this.AcceptButton = this.createGameBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(492, 303);
            this.ControlBox = false;
            this.Controls.Add(this.cancelGameBtn);
            this.Controls.Add(this.createGameBtn);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.gameNameInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adeventures - New Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Use;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createGameBtn;
        private System.Windows.Forms.Button cancelGameBtn;
        public System.Windows.Forms.TextBox gameNameInput;
    }
}