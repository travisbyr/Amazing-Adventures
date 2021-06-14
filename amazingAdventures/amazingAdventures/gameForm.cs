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
        ButtonEllipse buttonEllipse1 = new ButtonEllipse();
        public static int characterTile = 68;

        private static readonly GameForm _instance = new GameForm();

        public static GameForm Game => _instance;

        static GameForm() { }

        public GameForm()
        {
            InitializeComponent();
            characterSetup();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            moveUp();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            moveDown();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            moveLeft();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            moveRight();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                moveLeft();
                return true;
            }
            else if (keyData == Keys.Right)
            {
                moveRight();
                return true;
            }
            else if (keyData == Keys.Up)
            {
                moveUp();
                return true;
            }
            else if (keyData == Keys.Down)
            {
                moveDown();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void characterSetup()
        {
            pb68.Visible = false;

            int x = Main.M.GameIndex;
            DataAccess.checkCharacter(Main.M.Username, Main.M.GameIndex);

            DataAccess.getColour(Main.M.Username, x);
            buttonEllipse1.BackColor = ColorTranslator.FromHtml(DataAccess.message);
            buttonEllipse1.ForeColor = ColorTranslator.FromHtml(DataAccess.message);
            buttonEllipse1.FlatStyle = FlatStyle.Flat;
            buttonEllipse1.Location = new System.Drawing.Point(707, 470);
            buttonEllipse1.Name = "buttonEllipse1";
            buttonEllipse1.Size = new System.Drawing.Size(86, 86);
            buttonEllipse1.Invalidate();
            buttonEllipse1.Text = Main.M.CharacterName;
            buttonEllipse1.Enabled = false;
            buttonEllipse1.Font = new Font("Arial", 12);
            Controls.Add(buttonEllipse1);
            buttonEllipse1.BringToFront();

        }
        private void characterMove()
        {
            string x = "pb" + characterTile;                                              // gets picturebox name
            PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;        // targets control with the name from above
            pb.Visible = false;                                                           // changes the controls properties
            Point pt = pb.FindForm().PointToClient(pb.Parent.PointToScreen(pb.Location)); // gets control location
            Size locationOfMove = new Size(pt);                                           // converts to size
            buttonEllipse1.Location = new System.Drawing.Point(locationOfMove);           // moves character to tile
        }

        private void showPreviousTile(int tile)
        {
            string x = "pb" + tile; // gets picturebox name
            PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;
            pb.Visible = true;
        }

        private void moveUp()
        {
            characterTile = characterTile - 15;
            if (characterTile <= 134 && characterTile >= 1)
            {
                characterMove();
                showPreviousTile(characterTile + 15);
            }
            else
            {
                characterTile = characterTile + 15;
            }
        }
        private void moveDown()
        {
            characterTile = characterTile + 15;
            if (characterTile <= 134 && characterTile >= 1)
            {
                characterMove();
                showPreviousTile(characterTile - 15);
            }
            else
            {
                characterTile = characterTile - 15;
            }
        }
        private void moveLeft()
        {
            characterTile = characterTile - 1;
            if (characterTile <= 134 && characterTile >= 1)
            {
                characterMove();
                showPreviousTile(characterTile + 1);
            }
            else
            {
                characterTile = characterTile + 1;
            }
        }
        private void moveRight()
        {
            characterTile = characterTile + 1;
            if (characterTile <= 134 && characterTile >= 1)
            {
                characterMove();
                showPreviousTile(characterTile - 1);
            }
            else
            {
                characterTile = characterTile - 1;
            }
        }

    }
}
