
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalPlayersDGV = new System.Windows.Forms.DataGridView();
            this.adminFormCloseBtn = new System.Windows.Forms.Button();
            this.deletePlayerBtn = new System.Windows.Forms.Button();
            this.clearChatBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentGameList = new System.Windows.Forms.ListBox();
            this.addPlayerBtn = new System.Windows.Forms.Button();
            this.editPlayerBtn = new System.Windows.Forms.Button();
            this.deleteGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.totalPlayersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // totalPlayersDGV
            // 
            this.totalPlayersDGV.AllowUserToAddRows = false;
            this.totalPlayersDGV.AllowUserToDeleteRows = false;
            this.totalPlayersDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            this.totalPlayersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.totalPlayersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.totalPlayersDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.totalPlayersDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.totalPlayersDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalPlayersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.totalPlayersDGV.ColumnHeadersHeight = 33;
            this.totalPlayersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.totalPlayersDGV.ColumnHeadersVisible = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.totalPlayersDGV.DefaultCellStyle = dataGridViewCellStyle13;
            this.totalPlayersDGV.GridColor = System.Drawing.SystemColors.Control;
            this.totalPlayersDGV.Location = new System.Drawing.Point(708, 112);
            this.totalPlayersDGV.Margin = new System.Windows.Forms.Padding(2);
            this.totalPlayersDGV.MultiSelect = false;
            this.totalPlayersDGV.Name = "totalPlayersDGV";
            this.totalPlayersDGV.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.totalPlayersDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.totalPlayersDGV.RowHeadersVisible = false;
            this.totalPlayersDGV.RowHeadersWidth = 82;
            this.totalPlayersDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.totalPlayersDGV.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.totalPlayersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.totalPlayersDGV.Size = new System.Drawing.Size(283, 479);
            this.totalPlayersDGV.TabIndex = 41;
            // 
            // adminFormCloseBtn
            // 
            this.adminFormCloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adminFormCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminFormCloseBtn.Font = new System.Drawing.Font("Arial", 17F);
            this.adminFormCloseBtn.ForeColor = System.Drawing.Color.Black;
            this.adminFormCloseBtn.Location = new System.Drawing.Point(390, 628);
            this.adminFormCloseBtn.Name = "adminFormCloseBtn";
            this.adminFormCloseBtn.Size = new System.Drawing.Size(255, 60);
            this.adminFormCloseBtn.TabIndex = 36;
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
            this.deletePlayerBtn.Location = new System.Drawing.Point(740, 606);
            this.deletePlayerBtn.Name = "deletePlayerBtn";
            this.deletePlayerBtn.Size = new System.Drawing.Size(226, 40);
            this.deletePlayerBtn.TabIndex = 38;
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
            this.clearChatBtn.Location = new System.Drawing.Point(390, 360);
            this.clearChatBtn.Name = "clearChatBtn";
            this.clearChatBtn.Size = new System.Drawing.Size(255, 60);
            this.clearChatBtn.TabIndex = 34;
            this.clearChatBtn.Text = "Clear Chat";
            this.clearChatBtn.UseVisualStyleBackColor = false;
            this.clearChatBtn.Click += new System.EventHandler(this.clearChatBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(47, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 43);
            this.label3.TabIndex = 23;
            this.label3.Text = "Active Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(784, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 43);
            this.label2.TabIndex = 22;
            this.label2.Text = "Total Player List";
            // 
            // currentGameList
            // 
            this.currentGameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.currentGameList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.currentGameList.FormattingEnabled = true;
            this.currentGameList.ItemHeight = 25;
            this.currentGameList.Location = new System.Drawing.Point(49, 112);
            this.currentGameList.Name = "currentGameList";
            this.currentGameList.Size = new System.Drawing.Size(283, 477);
            this.currentGameList.TabIndex = 40;
            this.currentGameList.SelectedIndexChanged += new System.EventHandler(this.currentGameList_SelectedIndexChanged);
            // 
            // addPlayerBtn
            // 
            this.addPlayerBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.addPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPlayerBtn.Font = new System.Drawing.Font("Arial", 17F);
            this.addPlayerBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addPlayerBtn.Location = new System.Drawing.Point(390, 241);
            this.addPlayerBtn.Name = "addPlayerBtn";
            this.addPlayerBtn.Size = new System.Drawing.Size(255, 60);
            this.addPlayerBtn.TabIndex = 33;
            this.addPlayerBtn.Text = "Add Player";
            this.addPlayerBtn.UseVisualStyleBackColor = false;
            this.addPlayerBtn.Click += new System.EventHandler(this.addPlayerBtn_Click);
            // 
            // editPlayerBtn
            // 
            this.editPlayerBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.editPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPlayerBtn.Font = new System.Drawing.Font("Arial", 15.75F);
            this.editPlayerBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.editPlayerBtn.Location = new System.Drawing.Point(740, 655);
            this.editPlayerBtn.Name = "editPlayerBtn";
            this.editPlayerBtn.Size = new System.Drawing.Size(226, 40);
            this.editPlayerBtn.TabIndex = 39;
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
            this.deleteGameBtn.Location = new System.Drawing.Point(76, 606);
            this.deleteGameBtn.Name = "deleteGameBtn";
            this.deleteGameBtn.Size = new System.Drawing.Size(226, 40);
            this.deleteGameBtn.TabIndex = 37;
            this.deleteGameBtn.Text = "Delete Game";
            this.deleteGameBtn.UseVisualStyleBackColor = false;
            this.deleteGameBtn.Click += new System.EventHandler(this.deleteGameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(337, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 48);
            this.label1.TabIndex = 36;
            this.label1.Text = "Administrator Settings";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-6, -8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1056, 70);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // AdminSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 716);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.deleteGameBtn);
            this.Controls.Add(this.editPlayerBtn);
            this.Controls.Add(this.addPlayerBtn);
            this.Controls.Add(this.totalPlayersDGV);
            this.Controls.Add(this.adminFormCloseBtn);
            this.Controls.Add(this.deletePlayerBtn);
            this.Controls.Add(this.clearChatBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentGameList);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1056, 755);
            this.MinimumSize = new System.Drawing.Size(1056, 755);
            this.Name = "AdminSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amazing Adventures - Admin Settings";
            ((System.ComponentModel.ISupportInitialize)(this.totalPlayersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView totalPlayersDGV;
        private System.Windows.Forms.Button adminFormCloseBtn;
        private System.Windows.Forms.Button deletePlayerBtn;
        private System.Windows.Forms.Button clearChatBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox currentGameList;
        private System.Windows.Forms.Button addPlayerBtn;
        private System.Windows.Forms.Button editPlayerBtn;
        private System.Windows.Forms.Button deleteGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}