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

        private void newGameButton_Click(object sender, EventArgs e)
        {
            NewGameForm.NewGame.Show();
            NewGameForm.NewGame.gameNameInput.Text = "";
        }

        private void currentGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            Main.M.GameIndex = Main.M.GameListID[index];
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
            if (DataAccess.message == "gamesAvaliable")
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

        private void listPlayers()
        {
            DataAccess.showPlayerList();
            foreach (string a in Main.M.PlayerList.ToArray())
            {
                onlinePlayersList.Items.Add(a);
            }
        }

        private void joinGameButton_Click(object sender, EventArgs e)
        {
            DataAccess.checkCharacter(Main.M.Username, Main.M.GameIndex);
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
            DataAccess.characterRejoins(Main.M.Username, Main.M.GameIndex);
            GameForm.Game.Show();
            Hide();
        }
        
        private void createCharacter()
        {
            CharacterCreateForm.CreateForm.Show();
        }

    }
}
