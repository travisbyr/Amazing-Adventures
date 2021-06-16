
namespace AmazingAdventures
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
            this.label1 = new System.Windows.Forms.Label();
            this.chatTxtBox = new System.Windows.Forms.TextBox();
            this.chatCloseBtn = new System.Windows.Forms.Button();
            this.submitChatBtn = new System.Windows.Forms.Button();
            this.chatErrorLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chatMessageListBox
            // 
            this.chatMessageListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chatMessageListBox.FormattingEnabled = true;
            this.chatMessageListBox.ItemHeight = 20;
            this.chatMessageListBox.Location = new System.Drawing.Point(25, 63);
            this.chatMessageListBox.Name = "chatMessageListBox";
            this.chatMessageListBox.Size = new System.Drawing.Size(919, 244);
            this.chatMessageListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Amazing Adventures - Chat";
            // 
            // chatTxtBox
            // 
            this.chatTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.chatTxtBox.Location = new System.Drawing.Point(25, 320);
            this.chatTxtBox.Multiline = true;
            this.chatTxtBox.Name = "chatTxtBox";
            this.chatTxtBox.Size = new System.Drawing.Size(919, 38);
            this.chatTxtBox.TabIndex = 999;
            // 
            // chatCloseBtn
            // 
            this.chatCloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chatCloseBtn.Location = new System.Drawing.Point(391, 382);
            this.chatCloseBtn.Name = "chatCloseBtn";
            this.chatCloseBtn.Size = new System.Drawing.Size(158, 40);
            this.chatCloseBtn.TabIndex = 10;
            this.chatCloseBtn.Text = "Close Chat";
            this.chatCloseBtn.UseVisualStyleBackColor = true;
            this.chatCloseBtn.Click += new System.EventHandler(this.chatCloseBtn_Click);
            // 
            // submitChatBtn
            // 
            this.submitChatBtn.Location = new System.Drawing.Point(25, 364);
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
            this.chatErrorLine.Location = new System.Drawing.Point(633, 393);
            this.chatErrorLine.MinimumSize = new System.Drawing.Size(263, 16);
            this.chatErrorLine.Name = "chatErrorLine";
            this.chatErrorLine.Size = new System.Drawing.Size(263, 16);
            this.chatErrorLine.TabIndex = 1000;
            this.chatErrorLine.Text = "Max length is 50 characters";
            this.chatErrorLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chatErrorLine.Visible = false;
            // 
            // ChatForm
            // 
            this.AcceptButton = this.submitChatBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 445);
            this.ControlBox = false;
            this.Controls.Add(this.chatErrorLine);
            this.Controls.Add(this.submitChatBtn);
            this.Controls.Add(this.chatCloseBtn);
            this.Controls.Add(this.chatTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chatMessageListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(988, 484);
            this.MinimumSize = new System.Drawing.Size(988, 484);
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chatTxtBox;
        private System.Windows.Forms.Button chatCloseBtn;
        private System.Windows.Forms.Button submitChatBtn;
        public System.Windows.Forms.Label chatErrorLine;
        public System.Windows.Forms.ListBox chatMessageListBox;
    }
}