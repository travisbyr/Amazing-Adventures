
namespace amazingAdventures
{
    partial class CharacterCreateForm
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
            this.cancelCharacterBtn = new System.Windows.Forms.Button();
            this.createCharacterBtn = new System.Windows.Forms.Button();
            this.Use = new System.Windows.Forms.Label();
            this.characterNameInput = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pickcolourBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cancelCharacterBtn
            // 
            this.cancelCharacterBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelCharacterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelCharacterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cancelCharacterBtn.Location = new System.Drawing.Point(70, 250);
            this.cancelCharacterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelCharacterBtn.Name = "cancelCharacterBtn";
            this.cancelCharacterBtn.Size = new System.Drawing.Size(139, 35);
            this.cancelCharacterBtn.TabIndex = 40;
            this.cancelCharacterBtn.Text = "Cancel";
            this.cancelCharacterBtn.UseVisualStyleBackColor = false;
            this.cancelCharacterBtn.Click += new System.EventHandler(this.cancelCharacterBtn_Click);
            // 
            // createCharacterBtn
            // 
            this.createCharacterBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.createCharacterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCharacterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.createCharacterBtn.Location = new System.Drawing.Point(277, 250);
            this.createCharacterBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createCharacterBtn.Name = "createCharacterBtn";
            this.createCharacterBtn.Size = new System.Drawing.Size(130, 35);
            this.createCharacterBtn.TabIndex = 41;
            this.createCharacterBtn.Text = "Create";
            this.createCharacterBtn.UseVisualStyleBackColor = false;
            this.createCharacterBtn.Click += new System.EventHandler(this.createCharacterBtn_click);
            // 
            // Use
            // 
            this.Use.AutoSize = true;
            this.Use.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Use.Location = new System.Drawing.Point(166, 92);
            this.Use.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Use.Name = "Use";
            this.Use.Size = new System.Drawing.Size(149, 24);
            this.Use.TabIndex = 38;
            this.Use.Text = "Character name:";
            // 
            // characterNameInput
            // 
            this.characterNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterNameInput.Location = new System.Drawing.Point(95, 118);
            this.characterNameInput.Margin = new System.Windows.Forms.Padding(2);
            this.characterNameInput.Name = "characterNameInput";
            this.characterNameInput.Size = new System.Drawing.Size(287, 29);
            this.characterNameInput.TabIndex = 37;
            // 
            // pickcolourBtn
            // 
            this.pickcolourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickcolourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.pickcolourBtn.Location = new System.Drawing.Point(250, 175);
            this.pickcolourBtn.Name = "pickcolourBtn";
            this.pickcolourBtn.Size = new System.Drawing.Size(132, 35);
            this.pickcolourBtn.TabIndex = 41;
            this.pickcolourBtn.Text = "Pick Colour";
            this.pickcolourBtn.UseVisualStyleBackColor = true;
            this.pickcolourBtn.Click += new System.EventHandler(this.pickColourBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(91, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Character colour:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(99, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 47);
            this.label1.TabIndex = 44;
            this.label1.Text = "Create Character";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-6, -8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(503, 70);
            this.flowLayoutPanel1.TabIndex = 45;
            // 
            // CharacterCreateForm
            // 
            this.AcceptButton = this.createCharacterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(492, 335);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickcolourBtn);
            this.Controls.Add(this.cancelCharacterBtn);
            this.Controls.Add(this.createCharacterBtn);
            this.Controls.Add(this.Use);
            this.Controls.Add(this.characterNameInput);
            this.MaximumSize = new System.Drawing.Size(508, 374);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(508, 374);
            this.Name = "CharacterCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Create Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelCharacterBtn;
        private System.Windows.Forms.Button createCharacterBtn;
        private System.Windows.Forms.Label Use;
        public System.Windows.Forms.TextBox characterNameInput;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button pickcolourBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}