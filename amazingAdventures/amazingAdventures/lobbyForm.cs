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

        private static readonly LobbyForm _instance = new LobbyForm();

        public static LobbyForm Lobby => _instance;

        static LobbyForm() { }

        public LobbyForm()
        {
            InitializeComponent();
            listGames();
            listPlayers();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGameForm.NewGame.Show();
            NewGameForm.NewGame.gameNameInput.Text = "";
        }

        private void lobbyForm_Load(object sender, EventArgs e)
        {

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
            DataAccess.checkCharacter(LoginForm.username);
            if (DataAccess.message == "characterIsMade")
            {
                createCharacter();
            } else
            {
                joinGame();
            }
        }

        private void joinGame()
        {
            //DataAccess.characterJoinGame();
        }

        private void createCharacter()
        {
            //DataAccess.characterJoinGame();
        }
    }
}
