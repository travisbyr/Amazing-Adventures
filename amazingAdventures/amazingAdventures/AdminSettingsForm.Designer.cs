
namespace amazingAdventures
{
    partial class AdminSettingsForm
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
            this.totalPlayersDGV = new System.Windows.Forms.DataGridView();
            this.refreshAdminFormBtn = new System.Windows.Forms.Button();
            this.adminFormCloseBtn = new System.Windows.Forms.Button();
            this.deletePlayerBtn = new System.Windows.Forms.Button();
            this.clearChatBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.currentGameList = new System.Windows.Forms.ListBox();
            this.addPlayerBtn = new System.Windows.Forms.Button();
            this.editPlayerBtn = new System.Windows.Forms.Button();
            this.deleteGameBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.totalPlayersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalPlayersDGV
            // 
            this.totalPlayersDGV.AllowUserToAddRows = false;
            this.totalPlayersDGV.AllowUserToDeleteRows = false;
            this.totalPlayersDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalPlayersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.totalPlayersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.totalPlayersDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.totalPlayersDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalPlayersDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalPlayersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.totalPlayersDGV.ColumnHeadersHeight = 33;
            this.totalPlayersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.totalPlayersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalPlayersDGV.GridColor = System.Drawing.SystemColors.Control;
            this.totalPlayersDGV.Location = new System.Drawing.Point(706, 114);
            this.totalPlayersDGV.Margin = new System.Windows.Forms.Padding(2);
            this.totalPlayersDGV.MultiSelect = false;
            this.totalPlayersDGV.Name = "totalPlayersDGV";
            this.totalPlayersDGV.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalPlayersDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.totalPlayersDGV.RowHeadersVisible = false;
            this.totalPlayersDGV.RowHeadersWidth = 82;
            this.totalPlayersDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.totalPlayersDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.totalPlayersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.totalPlayersDGV.Size = new System.Drawing.Size(283, 479);
            this.totalPlayersDGV.TabIndex = 32;
            // 
            // refreshAdminFormBtn
            // 
            this.refreshAdminFormBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.refreshAdminFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshAdminFormBtn.Font = new System.Drawing.Font("Arial", 17F);
            this.refreshAdminFormBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.refreshAdminFormBtn.Location = new System.Drawing.Point(388, 305);
            this.refreshAdminFormBtn.Name = "refreshAdminFormBtn";
            this.refreshAdminFormBtn.Size = new System.Drawing.Size(255, 60);
            this.refreshAdminFormBtn.TabIndex = 31;
            this.refreshAdminFormBtn.Text = "Refresh";
            this.refreshAdminFormBtn.UseVisualStyleBackColor = false;
            // 
            // adminFormCloseBtn
            // 
            this.adminFormCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adminFormCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminFormCloseBtn.Font = new System.Drawing.Font("Arial", 17F);
            this.adminFormCloseBtn.ForeColor = System.Drawing.Color.Black;
            this.adminFormCloseBtn.Location = new System.Drawing.Point(388, 623);
            this.adminFormCloseBtn.Name = "adminFormCloseBtn";
            this.adminFormCloseBtn.Size = new System.Drawing.Size(255, 60);
            this.adminFormCloseBtn.TabIndex = 28;
            this.adminFormCloseBtn.Text = "Return to Lobby";
            this.adminFormCloseBtn.UseVisualStyleBackColor = false;
            this.adminFormCloseBtn.Click += new System.EventHandler(this.adminFormCloseBtn_Click);
            // 
            // deletePlayerBtn
            // 
            this.deletePlayerBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.deletePlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePlayerBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.deletePlayerBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deletePlayerBtn.Location = new System.Drawing.Point(738, 657);
            this.deletePlayerBtn.Name = "deletePlayerBtn";
            this.deletePlayerBtn.Size = new System.Drawing.Size(226, 40);
            this.deletePlayerBtn.TabIndex = 27;
            this.deletePlayerBtn.Text = "Delete Player";
            this.deletePlayerBtn.UseVisualStyleBackColor = false;
            this.deletePlayerBtn.Click += new System.EventHandler(this.deletePlayerBtn_Click);
            // 
            // clearChatBtn
            // 
            this.clearChatBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.clearChatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearChatBtn.Font = new System.Drawing.Font("Arial", 17F);
            this.clearChatBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.clearChatBtn.Location = new System.Drawing.Point(388, 420);
            this.clearChatBtn.Name = "clearChatBtn";
            this.clearChatBtn.Size = new System.Drawing.Size(255, 60);
            this.clearChatBtn.TabIndex = 25;
            this.clearChatBtn.Text = "Clear Chat";
            this.clearChatBtn.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(45, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Active Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(810, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Player List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(335, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 48);
            this.label1.TabIndex = 21;
            this.label1.Text = "Administrator Settings";
            // 
            // currentGameList
            // 
            this.currentGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.currentGameList.FormattingEnabled = true;
            this.currentGameList.ItemHeight = 25;
            this.currentGameList.Location = new System.Drawing.Point(47, 114);
            this.currentGameList.Name = "currentGameList";
            this.currentGameList.Size = new System.Drawing.Size(283, 479);
            this.currentGameList.TabIndex = 20;
            // 
            // addPlayerBtn
            // 
            this.addPlayerBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerBtn.Font = new System.Drawing.Font("Arial", 17F);
            this.addPlayerBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addPlayerBtn.Location = new System.Drawing.Point(388, 194);
            this.addPlayerBtn.Name = "addPlayerBtn";
            this.addPlayerBtn.Size = new System.Drawing.Size(255, 60);
            this.addPlayerBtn.TabIndex = 33;
            this.addPlayerBtn.Text = "Add Player";
            this.addPlayerBtn.UseVisualStyleBackColor = false;
            this.addPlayerBtn.Click += new System.EventHandler(this.addPlayerBtn_Click);
            // 
            // editPlayerBtn
            // 
            this.editPlayerBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPlayerBtn.Font = new System.Drawing.Font("Arial", 15.75F);
            this.editPlayerBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.editPlayerBtn.Location = new System.Drawing.Point(738, 608);
            this.editPlayerBtn.Name = "editPlayerBtn";
            this.editPlayerBtn.Size = new System.Drawing.Size(226, 40);
            this.editPlayerBtn.TabIndex = 34;
            this.editPlayerBtn.Text = "Edit Player";
            this.editPlayerBtn.UseVisualStyleBackColor = false;
            this.editPlayerBtn.Click += new System.EventHandler(this.editPlayerBtn_Click);
            // 
            // deleteGameBtn
            // 
            this.deleteGameBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.deleteGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGameBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.deleteGameBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.deleteGameBtn.Location = new System.Drawing.Point(74, 608);
            this.deleteGameBtn.Name = "deleteGameBtn";
            this.deleteGameBtn.Size = new System.Drawing.Size(226, 40);
            this.deleteGameBtn.TabIndex = 35;
            this.deleteGameBtn.Text = "Delete Game";
            this.deleteGameBtn.UseVisualStyleBackColor = false;
            // 
            // AdminSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 716);
            this.ControlBox = false;
            this.Controls.Add(this.deleteGameBtn);
            this.Controls.Add(this.editPlayerBtn);
            this.Controls.Add(this.addPlayerBtn);
            this.Controls.Add(this.totalPlayersDGV);
            this.Controls.Add(this.refreshAdminFormBtn);
            this.Controls.Add(this.adminFormCloseBtn);
            this.Controls.Add(this.deletePlayerBtn);
            this.Controls.Add(this.clearChatBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentGameList);
            this.Name = "AdminSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Admin Settings";
            this.Load += new System.EventHandler(this.AdminSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalPlayersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView totalPlayersDGV;
        private System.Windows.Forms.Button refreshAdminFormBtn;
        private System.Windows.Forms.Button adminFormCloseBtn;
        private System.Windows.Forms.Button deletePlayerBtn;
        private System.Windows.Forms.Button clearChatBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox currentGameList;
        private System.Windows.Forms.Button addPlayerBtn;
        private System.Windows.Forms.Button editPlayerBtn;
        private System.Windows.Forms.Button deleteGameBtn;
    }
}