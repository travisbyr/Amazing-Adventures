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
    public partial class AdminEditPlayerForm : Form
    {
        private static readonly AdminEditPlayerForm _instance = new AdminEditPlayerForm();
        public static AdminEditPlayerForm AdminEdit => _instance;
        static AdminEditPlayerForm() { }
        public AdminEditPlayerForm()
        {
            InitializeComponent();
        }

        private void manageCloseBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void manageSaveBtn_Click(object sender, EventArgs e)
        {
            bool Lock = false;
            bool Admin = false;

            DialogResult dialogResult = MessageBox.Show("Are you sure you would edit this player?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (manageLocked.Checked == true)
                {
                    Lock = true;
                }
                if (manageAdmin.Checked == true)
                {
                    Lock = true;
                }
                DataAccess.UpdatePlayerInfo(AdminSettingsForm.AdminSettings.user, 
                                            manageUsername.Text,
                                            managePassword.Text,
                                            manageEmail.Text,
                                            Int32.Parse(manageHighscore.Text),
                                            Admin,
                                            Lock);
                MessageBox.Show("Player details have been edited", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                AdminSettingsForm.AdminSettings.adminListGames();
                AdminSettingsForm.AdminSettings.updatePlayerList();
            }
        }
    }
}
