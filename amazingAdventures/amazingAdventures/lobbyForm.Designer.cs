
namespace amazingAdventures
{
    partial class lobbyForm
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
            this.currentGameList = new System.Windows.Forms.ListBox();
            this.onlinePlayersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.chatButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.joinGameButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentGameList
            // 
            this.currentGameList.FormattingEnabled = true;
            this.currentGameList.Location = new System.Drawing.Point(88, 120);
            this.currentGameList.Name = "currentGameList";
            this.currentGameList.Size = new System.Drawing.Size(313, 628);
            this.currentGameList.TabIndex = 0;
            // 
            // onlinePlayersList
            // 
            this.onlinePlayersList.FormattingEnabled = true;
            this.onlinePlayersList.Location = new System.Drawing.Point(799, 120);
            this.onlinePlayersList.Name = "onlinePlayersList";
            this.onlinePlayersList.Size = new System.Drawing.Size(313, 628);
            this.onlinePlayersList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amazing Adventures - Lobby";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(942, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Online Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(83, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current Games";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newGameButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 25F);
            this.newGameButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newGameButton.Location = new System.Drawing.Point(492, 184);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(215, 78);
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "NEW GAME";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // chatButton
            // 
            this.chatButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chatButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 25F);
            this.chatButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chatButton.Location = new System.Drawing.Point(492, 324);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(215, 78);
            this.chatButton.TabIndex = 11;
            this.chatButton.Text = "CHAT";
            this.chatButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 25F);
            this.settingsButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.settingsButton.Location = new System.Drawing.Point(492, 466);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(215, 78);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.Text = "SETTINGS";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // joinGameButton
            // 
            this.joinGameButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.joinGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.joinGameButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.joinGameButton.Location = new System.Drawing.Point(144, 780);
            this.joinGameButton.Name = "joinGameButton";
            this.joinGameButton.Size = new System.Drawing.Size(192, 60);
            this.joinGameButton.TabIndex = 13;
            this.joinGameButton.Text = "Join";
            this.joinGameButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.logoutButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.logoutButton.Location = new System.Drawing.Point(862, 780);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(192, 60);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.adminButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 25F);
            this.adminButton.ForeColor = System.Drawing.Color.Red;
            this.adminButton.Location = new System.Drawing.Point(492, 606);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(215, 78);
            this.adminButton.TabIndex = 15;
            this.adminButton.Text = "ADMIN";
            this.adminButton.UseVisualStyleBackColor = false;
            // 
            // lobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1198, 896);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.joinGameButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onlinePlayersList);
            this.Controls.Add(this.currentGameList);
            this.Name = "lobbyForm";
            this.Text = "Amazing Adventures - Lobby";
            this.Load += new System.EventHandler(this.lobbyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox currentGameList;
        private System.Windows.Forms.ListBox onlinePlayersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button chatButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button joinGameButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button adminButton;
    }
}