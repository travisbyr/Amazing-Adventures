using System;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class AdminCreatePlayerForm : Form
    {
        private static readonly AdminCreatePlayerForm _instance = new AdminCreatePlayerForm();
        public static AdminCreatePlayerForm AdminCreate => _instance;
        static AdminCreatePlayerForm() { }

        public AdminCreatePlayerForm()
        {
            InitializeComponent();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to create this player?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.AccountCreate(createUsername.Text, createPassword.Text, createEmail.Text); // Create account
                MessageBox.Show("Player account is created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminSettingsForm.AdminSettings.updatePlayerList();
                AdminSettingsForm.AdminSettings.adminListGames();
                Hide();
            }
        }
    }
}
