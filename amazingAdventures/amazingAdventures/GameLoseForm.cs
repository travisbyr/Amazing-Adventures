using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazingAdventures
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
            LobbyForm.Lobby.updateLeaderboard();
            LobbyForm.Lobby.Show();
        }
        public void updatePoints()
        {
            DataAccess.getCharacterScore(Main.M.Username, Main.M.GameNumber);
            pointsEndLabel.Text = GameForm.Game.points + " Points";
        }
    }
}
