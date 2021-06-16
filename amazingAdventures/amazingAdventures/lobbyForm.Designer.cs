
namespace AmazingAdventures
{
    partial class LobbyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyForm));
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentGameList
            // 
            this.currentGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.currentGameList.FormattingEnabled = true;
            this.currentGameList.ItemHeight = 25;
            this.currentGameList.Location = new System.Drawing.Point(49, 107);
            this.currentGameList.Name = "currentGameList";
            this.currentGameList.Size = new System.Drawing.Size(283, 479);
            this.currentGameList.TabIndex = 0;
            this.currentGameList.SelectedIndexChanged += new System.EventHandler(this.currentGameList_SelectedIndexChanged);
            this.currentGameList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.currentGameList_MouseDoubleClick);
            // 
            // onlinePlayersList
            // 
            this.onlinePlayersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.onlinePlayersList.FormattingEnabled = true;
            this.onlinePlayersList.ItemHeight = 25;
            this.onlinePlayersList.Location = new System.Drawing.Point(708, 107);
            this.onlinePlayersList.Name = "onlinePlayersList";
            this.onlinePlayersList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.onlinePlayersList.Size = new System.Drawing.Size(283, 479);
            this.onlinePlayersList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amazing Adventures - Lobby";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(828, 65);
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
            this.label3.Location = new System.Drawing.Point(47, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Current Games";
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.newGameButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F);
            this.newGameButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newGameButton.Location = new System.Drawing.Point(390, 247);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(255, 60);
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // chatButton
            // 
            this.chatButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chatButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F);
            this.chatButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.chatButton.Location = new System.Drawing.Point(390, 342);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(255, 60);
            this.chatButton.TabIndex = 11;
            this.chatButton.Text = "Chat";
            this.chatButton.UseVisualStyleBackColor = false;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.settingsButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F);
            this.settingsButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.settingsButton.Location = new System.Drawing.Point(390, 444);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(255, 60);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // joinGameButton
            // 
            this.joinGameButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.joinGameButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F);
            this.joinGameButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.joinGameButton.Location = new System.Drawing.Point(90, 623);
            this.joinGameButton.Name = "joinGameButton";
            this.joinGameButton.Size = new System.Drawing.Size(192, 60);
            this.joinGameButton.TabIndex = 13;
            this.joinGameButton.Text = "Join";
            this.joinGameButton.UseVisualStyleBackColor = false;
            this.joinGameButton.Click += new System.EventHandler(this.joinGameButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logoutButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F);
            this.logoutButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.logoutButton.Location = new System.Drawing.Point(762, 623);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(192, 60);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.adminButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F);
            this.adminButton.ForeColor = System.Drawing.Color.Red;
            this.adminButton.Location = new System.Drawing.Point(390, 623);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(255, 60);
            this.adminButton.TabIndex = 15;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Highest Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(431, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "Travis: 15 items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label100";
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1040, 716);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1056, 755);
            this.MinimumSize = new System.Drawing.Size(1056, 755);
            this.Name = "LobbyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        public System.Windows.Forms.ListBox currentGameList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}