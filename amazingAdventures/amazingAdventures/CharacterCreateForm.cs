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
    public partial class CharacterCreateForm : Form
    {
        public static string characterColour = "#000000";

        private static readonly CharacterCreateForm _instance = new CharacterCreateForm();

        public static CharacterCreateForm CreateForm => _instance;

        static CharacterCreateForm() { }

        public CharacterCreateForm()
        {
            InitializeComponent();
        }

        private void pickcolourBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color col = colorDialog1.Color;
                pickcolourBtn.BackColor = col;
                pickcolourBtn.FlatAppearance.BorderColor = col;

                string color = col.ToArgb().ToString("x");

                color = color.Substring(2, 6);

                characterColour = "#" + color;

            }
        }

        private void cancelCharacterBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void createCharacterBtn_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to create this character?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.characterJoinGame(Main.M.GameNumber, characterNameInput.Text, characterColour, Main.M.Username.ToString());
                GameForm.Game.characterSetup();
                GameForm.Game.Show();
                Hide();
            }
        }
    }
}
