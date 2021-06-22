
namespace amazingAdventures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LobbyForm));
            this.currentGameList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.chatButton = new System.Windows.Forms.Button();
            this.joinGameButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lobbyHighScore = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.onlinePlayersDGV = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.onlinePlayersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // currentGameList
            // 
            this.currentGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.currentGameList.FormattingEnabled = true;
            this.currentGameList.ItemHeight = 25;
            this.currentGameList.Location = new System.Drawing.Point(49, 112);
            this.currentGameList.Name = "currentGameList";
            this.currentGameList.Size = new System.Drawing.Size(283, 479);
            this.currentGameList.TabIndex = 0;
            this.currentGameList.SelectedIndexChanged += new System.EventHandler(this.currentGameList_SelectedIndexChanged);
            this.currentGameList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.currentGameList_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(275, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amazing Adventures - Lobby";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(810, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "Online Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(46, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "Avaliable Games";
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F);
            this.newGameButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.newGameButton.Location = new System.Drawing.Point(390, 265);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(255, 60);
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // chatButton
            // 
            this.chatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chatButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F);
            this.chatButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.chatButton.Location = new System.Drawing.Point(390, 356);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(255, 60);
            this.chatButton.TabIndex = 11;
            this.chatButton.Text = "Chat";
            this.chatButton.UseVisualStyleBackColor = false;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // joinGameButton
            // 
            this.joinGameButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.joinGameButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 16F);
            this.joinGameButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.joinGameButton.Location = new System.Drawing.Point(90, 628);
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
            this.logoutButton.Location = new System.Drawing.Point(762, 628);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(192, 60);
            this.logoutButton.TabIndex = 14;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.LightSalmon;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F);
            this.adminButton.ForeColor = System.Drawing.Color.Black;
            this.adminButton.Location = new System.Drawing.Point(390, 628);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(255, 60);
            this.adminButton.TabIndex = 15;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 47);
            this.label4.TabIndex = 16;
            this.label4.Text = "Highscore";
            // 
            // lobbyHighScore
            // 
            this.lobbyHighScore.AutoSize = true;
            this.lobbyHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lobbyHighScore.Location = new System.Drawing.Point(472, 187);
            this.lobbyHighScore.Name = "lobbyHighScore";
            this.lobbyHighScore.Size = new System.Drawing.Size(91, 26);
            this.lobbyHighScore.TabIndex = 17;
            this.lobbyHighScore.Text = "0 Points";
            this.lobbyHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 20F);
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.settingsBtn.Location = new System.Drawing.Point(390, 449);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(255, 60);
            this.settingsBtn.TabIndex = 18;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // onlinePlayersDGV
            // 
            this.onlinePlayersDGV.AllowUserToAddRows = false;
            this.onlinePlayersDGV.AllowUserToDeleteRows = false;
            this.onlinePlayersDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.onlinePlayersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.onlinePlayersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.onlinePlayersDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.onlinePlayersDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onlinePlayersDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.onlinePlayersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.onlinePlayersDGV.ColumnHeadersHeight = 33;
            this.onlinePlayersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.onlinePlayersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.onlinePlayersDGV.GridColor = System.Drawing.SystemColors.Control;
            this.onlinePlayersDGV.Location = new System.Drawing.Point(708, 112);
            this.onlinePlayersDGV.Margin = new System.Windows.Forms.Padding(2);
            this.onlinePlayersDGV.MultiSelect = false;
            this.onlinePlayersDGV.Name = "onlinePlayersDGV";
            this.onlinePlayersDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.onlinePlayersDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.onlinePlayersDGV.RowHeadersVisible = false;
            this.onlinePlayersDGV.RowHeadersWidth = 82;
            this.onlinePlayersDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.onlinePlayersDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.onlinePlayersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.onlinePlayersDGV.Size = new System.Drawing.Size(283, 479);
            this.onlinePlayersDGV.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-6, -8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1056, 70);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1040, 716);
            this.ControlBox = false;
            this.Controls.Add(this.onlinePlayersDGV);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.lobbyHighScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.joinGameButton);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentGameList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1056, 755);
            this.MinimumSize = new System.Drawing.Size(1056, 755);
            this.Name = "LobbyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Lobby";
            ((System.ComponentModel.ISupportInitialize)(this.onlinePlayersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button chatButton;
        private System.Windows.Forms.Button joinGameButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button adminButton;
        public System.Windows.Forms.ListBox currentGameList;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lobbyHighScore;
        private System.Windows.Forms.Button settingsBtn;
        public System.Windows.Forms.DataGridView onlinePlayersDGV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}