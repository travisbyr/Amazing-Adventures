
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
            this.createGameBtn = new System.Windows.Forms.Button();
            this.cancelGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(137, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 47);
            this.label1.TabIndex = 46;
            this.label1.Text = "Create Game";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-6, -8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(503, 70);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // NewGameForm
            // 
            this.AcceptButton = this.createGameBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(492, 303);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cancelGameBtn);
            this.Controls.Add(this.createGameBtn);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.gameNameInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(508, 342);
            this.MinimumSize = new System.Drawing.Size(508, 342);
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adeventures - New Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Use;
        private System.Windows.Forms.Button createGameBtn;
        private System.Windows.Forms.Button cancelGameBtn;
        public System.Windows.Forms.TextBox gameNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}