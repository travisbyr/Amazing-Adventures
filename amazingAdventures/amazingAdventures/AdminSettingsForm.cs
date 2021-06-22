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
    public partial class AdminSettingsForm : Form
    {
        private static readonly AdminSettingsForm _instance = new AdminSettingsForm();
        public static AdminSettingsForm AdminSettings => _instance;
        static AdminSettingsForm() { }
        public AdminSettingsForm()
        {
            InitializeComponent();
        }

        private void AdminSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void adminFormCloseBtn_Click(object sender, EventArgs e)
        {
            LobbyForm.Lobby.Show();
            Hide();
        }

        private void editPlayerBtn_Click(object sender, EventArgs e)
        {
            AdminEditPlayerForm.AdminEdit.Show();
        }

        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            AdminCreatePlayerForm.AdminCreate.Show();
        }

        private void deletePlayerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
