using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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

        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGameForm.NewGame.Show();
            NewGameForm.NewGame.gameNameInput.Text = "";
        }

        private void currentGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            if (index != -1)
            {
                Main.M.GameNumber = Main.M.GameListID[index];
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            ChatForm.Chat.Show();
        }

        public void listGames()
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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm.Login.Show();
        }
        private void joinGameButton_Click(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            if (index != -1)
            {
                joinGame();
            }
        }
        private void currentGameList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            joinGame();
        }

        private void joinGame()
        {
            DataAccess.checkCharacter(Main.M.Username, Main.M.GameNumber);
            if (DataAccess.Message == "characterIsMade")
            {   // Join game using existing character
                DataAccess.characterRejoins(Main.M.Username, Main.M.GameNumber);
                GameForm.Game.characterSetup();
                GameForm.Game.Show();
                Hide();
            }
            else
            {   // Create character
                CharacterCreateForm.CreateForm.Show();
            }
        }
        private void adminAbility()
        {
            DataAccess.checkAdmin(Main.M.Username);
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
            DataAccess.viewOnlinePlayers();
            onlinePlayersDGV.DataSource = Leaderboard.LeaderboardList;
            onlinePlayersDGV.Columns["GameNumber"].Visible = false;
            onlinePlayersDGV.Columns["Username"].Visible = false;
            onlinePlayersDGV.Columns["Message"].Visible = false;
            onlinePlayersDGV.Columns["CharacterName"].Visible = false;
            onlinePlayersDGV.Columns["CharacterScore"].Visible = false;
            onlinePlayersDGV.Columns["LeaderboardGame"].Visible = false;
            onlinePlayersDGV.Columns["Highscore"].Width = 100;
            onlinePlayersDGV.ClearSelection();

            foreach (Leaderboard item in Leaderboard.LeaderboardList)
            {
                if (Main.M.Username.ToLower() == item.Player.ToLower())
                {
                    lobbyHighScore.Text = item.Highscore + " Points";
                }
            }
            adminAbility();
            listGames();
        } // talk about why I didnt do diagonal movements

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Hide();
            PlayerSettingsForm.PlayerSettings.settingsUsername.Text = "dwadwa";
            PlayerSettingsForm.PlayerSettings.Show();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            Hide();
            AdminSettingsForm.AdminSettings.updatePlayerList();
            AdminSettingsForm.AdminSettings.adminListGames();
            AdminSettingsForm.AdminSettings.Show();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            listGames();
            viewPlayersOnline();
        }
    }
}
