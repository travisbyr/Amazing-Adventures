using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class AdminSettingsForm : Form
    {
        public string user;
        int i;
        private static readonly AdminSettingsForm _instance = new AdminSettingsForm();
        public static AdminSettingsForm AdminSettings => _instance;
        static AdminSettingsForm() { }
        public AdminSettingsForm()
        {
            InitializeComponent();
        }

        private void adminFormCloseBtn_Click(object sender, EventArgs e)
        {
            LobbyForm.Lobby.listGames();
            LobbyForm.Lobby.viewPlayersOnline();
            LobbyForm.Lobby.Show();
            Hide();
        }
        private void editPlayerBtn_Click(object sender, EventArgs e)
        {
            int x = totalPlayersDGV.CurrentCell.RowIndex;
            Leaderboard a = (Leaderboard)totalPlayersDGV.Rows[x].DataBoundItem;
            user = a.Player;
            DataAccess.GetPlayerInfo(a.Player);

            if (a.Player.ToLower() != Main.M.Username.ToLower()) // Explain in report why you cant edit yourself, because of admin access, hacks etc, check there own highscore, corruption of data
            {

                AdminEditPlayerForm.AdminEdit.manageUsername.Text = a.Player;
                AdminEditPlayerForm.AdminEdit.manageEmail.Text = Main.M.GetPEmail;
                AdminEditPlayerForm.AdminEdit.managePassword.Text = Main.M.GetPPassword;
                AdminEditPlayerForm.AdminEdit.manageHighscore.Text = Main.M.GetPHighscore;
                if (Main.M.GetPIsAdmin == "True")
                {
                    AdminEditPlayerForm.AdminEdit.manageAdmin.Checked = true;
                    Main.M.GetPIsAdmin = "False";
                }

                if (Main.M.GetPLocked == "True")
                {
                    AdminEditPlayerForm.AdminEdit.manageLocked.Checked = true;
                    Main.M.GetPLocked = "False";
                }

                AdminEditPlayerForm.AdminEdit.Show();
            }
        }
        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            AdminCreatePlayerForm.AdminCreate.Show();
        }
        private void deletePlayerBtn_Click(object sender, EventArgs e)
        {
            int x = totalPlayersDGV.CurrentCell.RowIndex;
            Leaderboard a = (Leaderboard)totalPlayersDGV.Rows[x].DataBoundItem;
            if (a.Player.ToLower() != Main.M.Username.ToLower()) // Explain in report why you cant edit yourself, because of admin access, hacks etc.
            {
                if (a.Player == Main.M.Username)
                {
                    MessageBox.Show("You cannot delete yourself", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this player?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataAccess.AdminDeletePlayer(user);
                        MessageBox.Show("Player has been deleted", "Player Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updatePlayerList();
                        adminListGames();
                    }
                }
            }
        }
        private void clearChatBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to reset the global chat?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.AdminClearGlobalChat();
                MessageBox.Show("Global chat has been reset", "Chat Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void adminListGames()
        {
            currentGameList.Items.Clear();
            Main.M.GameListName.Clear();
            Main.M.GameListID.Clear();
            DataAccess.GamesList();
            if (DataAccess.Message == "gamesAvaliable")
            {
                foreach (string a in Main.M.GameListName.ToArray())
                {
                    currentGameList.Items.Add(a);
                }
            }
        }
        private void deleteGameBtn_Click(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            if (index != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this game?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DataAccess.AdminCloseGame(i);
                    adminListGames();
                }
            }
        }
        private void currentGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            if (index != -1)
            {
                i = Main.M.GameListID[index];
            }
        }
        public void updatePlayerList()
        {
            DataAccess.ListOfPlayers();

            totalPlayersDGV.DataSource = null;
            Leaderboard.PlayerList.Clear();
            DataAccess.ListOfPlayers();
            totalPlayersDGV.DataSource = Leaderboard.PlayerList;
            totalPlayersDGV.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            totalPlayersDGV.Columns["Player"].Visible = true;
            totalPlayersDGV.ClearSelection();

        }
    }
}
