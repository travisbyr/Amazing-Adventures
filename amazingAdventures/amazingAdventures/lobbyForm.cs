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
    public partial class LobbyForm : Form
    {
        public static string username;
        public static int gameIndex;

        private static readonly LobbyForm _instance = new LobbyForm();

        public static LobbyForm Lobby => _instance;

        static LobbyForm() { }

        public LobbyForm()
        {
            InitializeComponent();
            listGames();
            listPlayers();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGameForm.NewGame.Show();
            NewGameForm.NewGame.gameNameInput.Text = "";
        }

        private void currentGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameIndex = currentGameList.SelectedIndex;
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
            DataAccess.gameListName.Clear();
            DataAccess.gameListID.Clear();
            DataAccess.gamesList();
            if (DataAccess.message == "gamesAvaliable")
            {
                foreach (string a in DataAccess.gameListName.ToArray())
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

        private void listPlayers()
        {
            DataAccess.showPlayerList();
            foreach (string a in DataAccess.playerList.ToArray())
            {
                onlinePlayersList.Items.Add(a);
            }
        }

        private void joinGameButton_Click(object sender, EventArgs e)
        {
            DataAccess.checkCharacter(LoginForm.username, gameIndex);
            if (DataAccess.message == "characterIsMade")
            {
                joinGame();
            } 
            else
            {
                createCharacter();
            }
        }

        private void joinGame()
        {
            DataAccess.characterRejoins(LoginForm.username, gameIndex);
            GameForm.Game.Show();
            Hide();
        }

        private void createCharacter()
        {
            CharacterCreateForm.CreateForm.Show();
        }

    }
}
