using System;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class GameLoseForm : Form
    {
        private static readonly GameLoseForm _instance = new GameLoseForm();
        public static GameLoseForm GameLose => _instance;
        static GameLoseForm() { }

        public GameLoseForm()
        {
            InitializeComponent();

        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Hide();
            LobbyForm.Lobby.viewPlayersOnline();
            LobbyForm.Lobby.Show();
        }
    }
}
