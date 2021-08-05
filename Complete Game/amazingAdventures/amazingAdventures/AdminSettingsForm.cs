using System;
using System.Linq;
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
            int x = totalPlayersDGV.CurrentCell.RowIndex; // Get selected row
            Leaderboard a = (Leaderboard)totalPlayersDGV.Rows[x].DataBoundItem; // Get selected row object from list
            user = a.Player;
            DataAccess.GetPlayerInfo(a.Player); // get selected object name

            if (a.Player.ToLower() != Main.M.Username.ToLower()) // If selected player is not itself
            {
                AdminEditPlayerForm.AdminEdit.manageUsername.Text = a.Player;
                AdminEditPlayerForm.AdminEdit.manageEmail.Text = Main.M.GetPEmail; // Set values on form
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
            if (a.Player.ToLower() != Main.M.Username.ToLower())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this player?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DataAccess.DeletePlayer(user);
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
                DataAccess.AdminClearGlobalChat();
                MessageBox.Show("Global chat has been reset", "Chat Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void adminListGames()
        {
            currentGameList.Items.Clear();
            Main.M.GameListName.Clear();
            Main.M.GameListID.Clear(); // Clear lists and listbox
            DataAccess.GamesList();
            if (DataAccess.Message == "gamesAvaliable")
            {
                foreach (string a in Main.M.GameListName.ToArray())
                {
                    currentGameList.Items.Add(a); // Add items to gamelist 
                }
            }
        }
        private void deleteGameBtn_Click(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            if (index != -1) // If selected index is not null but is valid
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
            if (index != -1) // If selected index is valid and not null
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
