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
    public partial class NewGameForm : Form
    {

        private static readonly NewGameForm _instance = new NewGameForm();

        public static NewGameForm NewGame => _instance;

        static NewGameForm() { }

        public NewGameForm()
        {
            InitializeComponent();
        }

        private void cancelGameBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void createGameBtn_Click(object sender, EventArgs e)
        {
            createGame();
        }

        private void createGame()
        {
            DataAccess.gameCreation(LoginForm.Login.username, gameNameInput.Text);
            if (DataAccess.message == "gameAlreadyCreated")
            {
                DialogResult result = MessageBox.Show("You have already created a game.\nWould you like to delete it and make a new one?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    DataAccess.gameClose(LoginForm.Login.username);
                    LobbyForm.Lobby.listGames();
                    Hide();
                }
                else if (result == DialogResult.No)
                {
                    Hide();
                }
            }

            LobbyForm.Lobby.listGames();
            Hide();
        }
    }
}
