using System;
using System.Linq;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class LobbyForm : Form
    {
        public static string username;
        private static readonly LobbyForm _instance = new LobbyForm();
        public static LobbyForm Lobby => _instance;
        static LobbyForm() { }

        public LobbyForm()
        {
            InitializeComponent();
            viewPlayersOnline();
        }
        private void createGameBtn_Click(object sender, EventArgs e)
        {
            NewGameForm.NewGame.Show();
            NewGameForm.NewGame.gameNameInput.Text = "";
        }
        private void currentGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            if (index != -1) // if item is not selected
            {
                Main.M.GameNumber = Main.M.GameListID[index];
            }
        }
        private void chatBtn_Click(object sender, EventArgs e)
        {
            ChatForm.Chat.Show();
        }
        public void listGames()
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
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            DataAccess.AccountLogout(Main.M.Username);
            LoginForm.Login.Show();
        }
        private void joinGameBtn_Click(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            if (index != -1) // if item is selected
            {
                joinGame();
            }
        }
        private void currentGameList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            if (index != -1) // if item is selected
            {
                joinGame();
            }
        }
        private void joinGame()
        {
            DataAccess.CheckCharacter(Main.M.Username, Main.M.GameNumber);
            if (DataAccess.Message == "characterIsMade") // Join game using existing character
            {   DataAccess.CharacterRejoins(Main.M.Username, Main.M.GameNumber);
                GameForm.Game.characterSetup();
                GameForm.Game.Show();
                Hide();
            }
            else   // Create character
            {   Hide();
                CharacterCreateForm.CreateForm.Show();
            }
        }
        private void checkAdminAbility()
        {
            DataAccess.CheckAdmin(Main.M.Username);
            if(DataAccess.Message == "isAdmin")
            {
                adminButton.Visible = true;
            } 
            else if (DataAccess.Message == "notAdmin")
            {
                adminButton.Visible = false;
            }
        }
        public void viewPlayersOnline()
        {
            onlinePlayersDGV.DataSource = null;
            Leaderboard.LeaderboardList.Clear();
            DataAccess.ViewOnlinePlayers();
            onlinePlayersDGV.DataSource = Leaderboard.LeaderboardList;
            onlinePlayersDGV.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false);
            onlinePlayersDGV.Columns["Player"].Visible = true;
            onlinePlayersDGV.Columns["Highscore"].Visible = true;
            onlinePlayersDGV.Columns["Highscore"].Width = 100;
            onlinePlayersDGV.ClearSelection();

            foreach (Leaderboard item in Leaderboard.LeaderboardList)
            {
                if (Main.M.Username.ToLower() == item.Player.ToLower()) // If item is the players username
                {
                    lobbyHighScore.Text = item.Highscore + " Points";
                }
            }
            checkAdminAbility();
            listGames();
        } // talk about why I didnt do diagonal movements
        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            PlayerSettingsForm.PlayerSettings.settingsUsername.Text = Main.M.Username;
            PlayerSettingsForm.PlayerSettings.Show();
        }
        private void adminBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AdminSettingsForm.AdminSettings.updatePlayerList();
            AdminSettingsForm.AdminSettings.adminListGames();
            AdminSettingsForm.AdminSettings.Show();
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            listGames();
            viewPlayersOnline();
        }
    }
}
