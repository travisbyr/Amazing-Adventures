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
        int i;
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
            LobbyForm.Lobby.listGames();
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

        private void clearChatBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to reset the global chat?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.clearGlobalChat();
                MessageBox.Show("Global chat has been reset", "Chat Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void adminListGames()
        {
            currentGameList.Items.Clear();
            Main.M.GameListName.Clear();
            Main.M.GameListID.Clear();
            DataAccess.gamesList();
            if (DataAccess.Message == "gamesAvaliable")
            {
                foreach (string a in Main.M.GameListName.ToArray())
                {
                    currentGameList.Items.Add(a);
                }
            }
        }

        private void deleteGameBtn_Click(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            if (index != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete this game?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DataAccess.adminCloseGame(i);
                    adminListGames();
                }
            }
        }

        private void currentGameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = currentGameList.SelectedIndex;
            i = Main.M.GameListID[index];
        }
    }
}
