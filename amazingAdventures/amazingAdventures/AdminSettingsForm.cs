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
        int i;
        private static readonly AdminSettingsForm _instance = new AdminSettingsForm();
        public static AdminSettingsForm AdminSettings => _instance;
        static AdminSettingsForm() { }
        public AdminSettingsForm()
        {
            InitializeComponent();
        }

        private void AdminSettingsForm_Load(object sender, EventArgs e)
        {

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
            AdminEditPlayerForm.AdminEdit.Show();
        }

        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            AdminCreatePlayerForm.AdminCreate.Show();
        }

        private void deletePlayerBtn_Click(object sender, EventArgs e)
        {
            int x = totalPlayersDGV.CurrentCell.RowIndex;
            Leaderboard a = (Leaderboard)totalPlayersDGV.Rows[x].DataBoundItem;
            string user = a.Player;
            if (a.Player == Main.M.Username)
            {
                MessageBox.Show("You cannot delete yourself", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this player?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DataAccess.adminDeletePlayer(user);
                    MessageBox.Show("Player has been deleted", "Player Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updatePlayerList();
                    adminListGames();
                }
            }
        }

        private void clearChatBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to reset the global chat?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.clearGlobalChat();
                MessageBox.Show("Global chat has been reset", "Chat Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void adminListGames()
        {
            currentGameList.Items.Clear();
            Main.M.GameListName.Clear();
            Main.M.GameListID.Clear();
            DataAccess.gamesList();
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
                    DataAccess.adminCloseGame(i);
                    adminListGames();
                }
            }
        }

        private void currentGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            i = Main.M.GameListID[index];
        }

        public void updatePlayerList()
        {
            DataAccess.listOfPlayers();

            totalPlayersDGV.DataSource = null;
            Leaderboard.PlayerList.Clear();
            DataAccess.listOfPlayers();
            totalPlayersDGV.DataSource = Leaderboard.PlayerList;
            totalPlayersDGV.Columns["Highscore"].Visible = false;
            totalPlayersDGV.Columns["GameNumber"].Visible = false;
            totalPlayersDGV.Columns["Username"].Visible = false;
            totalPlayersDGV.Columns["Message"].Visible = false;
            totalPlayersDGV.Columns["CharacterName"].Visible = false;
            totalPlayersDGV.Columns["CharacterScore"].Visible = false;
            totalPlayersDGV.Columns["LeaderboardGame"].Visible = false;
            totalPlayersDGV.ClearSelection();

        }
    }
}
