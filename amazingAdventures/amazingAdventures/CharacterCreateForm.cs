using System;
using System.Drawing;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class CharacterCreateForm : Form
    {
        public static string characterColour = "#32CD32"; // Character default colour

        private static readonly CharacterCreateForm _instance = new CharacterCreateForm();
        public static CharacterCreateForm CreateForm => _instance;
        static CharacterCreateForm() { }

        public CharacterCreateForm()
        {
            InitializeComponent();
        }
        private void pickColourBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color col = colorDialog1.Color; // Create colour from picker
                pickcolourBtn.BackColor = col;
                pickcolourBtn.FlatAppearance.BorderColor = col;
                string color = col.ToArgb().ToString("x"); // Change colour to hex
                color = color.Substring(2, 6);
                characterColour = "#" + color;
            }
        }
        private void cancelCharacterBtn_Click(object sender, EventArgs e)
        {
            Hide();
            LobbyForm.Lobby.Show();
        }
        private void createCharacterBtn_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to create this character?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.CharacterJoinGame(Main.M.GameNumber, characterNameInput.Text, characterColour, Main.M.Username.ToString());
                GameForm.Game.characterSetup();
                GameForm.Game.Show();
                Hide();
            }
        }
    }
}
