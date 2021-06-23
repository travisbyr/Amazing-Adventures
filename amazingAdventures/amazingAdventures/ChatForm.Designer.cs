
namespace amazingAdventures
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.chatMessageListBox = new System.Windows.Forms.ListBox();
            this.chatTxtBox = new System.Windows.Forms.TextBox();
            this.chatCloseBtn = new System.Windows.Forms.Button();
            this.submitChatBtn = new System.Windows.Forms.Button();
            this.chatErrorLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // chatMessageListBox
            // 
            this.chatMessageListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chatMessageListBox.FormattingEnabled = true;
            this.chatMessageListBox.ItemHeight = 20;
            this.chatMessageListBox.Location = new System.Drawing.Point(25, 84);
            this.chatMessageListBox.Name = "chatMessageListBox";
            this.chatMessageListBox.Size = new System.Drawing.Size(919, 244);
            this.chatMessageListBox.TabIndex = 0;
            // 
            // chatTxtBox
            // 
            this.chatTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chatTxtBox.Location = new System.Drawing.Point(25, 341);
            this.chatTxtBox.Multiline = true;
            this.chatTxtBox.Name = "chatTxtBox";
            this.chatTxtBox.Size = new System.Drawing.Size(919, 38);
            this.chatTxtBox.TabIndex = 999;
            // 
            // chatCloseBtn
            // 
            this.chatCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chatCloseBtn.Location = new System.Drawing.Point(391, 402);
            this.chatCloseBtn.Name = "chatCloseBtn";
            this.chatCloseBtn.Size = new System.Drawing.Size(158, 40);
            this.chatCloseBtn.TabIndex = 10;
            this.chatCloseBtn.Text = "Close";
            this.chatCloseBtn.UseVisualStyleBackColor = true;
            this.chatCloseBtn.Click += new System.EventHandler(this.chatCloseBtn_Click);
            // 
            // submitChatBtn
            // 
            this.submitChatBtn.Location = new System.Drawing.Point(25, 385);
            this.submitChatBtn.Name = "submitChatBtn";
            this.submitChatBtn.Size = new System.Drawing.Size(75, 23);
            this.submitChatBtn.TabIndex = 11;
            this.submitChatBtn.Text = "Submit";
            this.submitChatBtn.UseVisualStyleBackColor = true;
            this.submitChatBtn.Click += new System.EventHandler(this.submitChatBtn_Click);
            // 
            // chatErrorLine
            // 
            this.chatErrorLine.AutoSize = true;
            this.chatErrorLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatErrorLine.ForeColor = System.Drawing.Color.Red;
            this.chatErrorLine.Location = new System.Drawing.Point(633, 414);
            this.chatErrorLine.MinimumSize = new System.Drawing.Size(263, 16);
            this.chatErrorLine.Name = "chatErrorLine";
            this.chatErrorLine.Size = new System.Drawing.Size(263, 16);
            this.chatErrorLine.TabIndex = 1000;
            this.chatErrorLine.Text = "Max length is 50 characters";
            this.chatErrorLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chatErrorLine.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(360, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 48);
            this.label1.TabIndex = 1001;
            this.label1.Text = "Global Chat";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-42, -8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1056, 70);
            this.flowLayoutPanel1.TabIndex = 1002;
            // 
            // ChatForm
            // 
            this.AcceptButton = this.submitChatBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 461);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.chatErrorLine);
            this.Controls.Add(this.submitChatBtn);
            this.Controls.Add(this.chatCloseBtn);
            this.Controls.Add(this.chatTxtBox);
            this.Controls.Add(this.chatMessageListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(988, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(988, 500);
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox chatTxtBox;
        private System.Windows.Forms.Button chatCloseBtn;
        private System.Windows.Forms.Button submitChatBtn;
        public System.Windows.Forms.Label chatErrorLine;
        public System.Windows.Forms.ListBox chatMessageListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}