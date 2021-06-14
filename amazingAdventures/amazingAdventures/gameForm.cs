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
    public partial class GameForm : Form
    {

        private static readonly GameForm _instance = new GameForm();

        public static GameForm Game => _instance;

        static GameForm() { }

        public GameForm()
        {
            //panel.BackColor = ColorTranslator.FromHtml("#ffff99");
            InitializeComponent();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
