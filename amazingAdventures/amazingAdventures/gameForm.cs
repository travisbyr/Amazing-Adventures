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
    public partial class GameForm : Form
    {
        ButtonEllipse playerMarker = new ButtonEllipse();
        public int prePreTile;
        public int preTile;
        public int curTile = 68;

        private static readonly GameForm _instance = new GameForm();

        public static GameForm Game => _instance;

        static GameForm() { }

        public GameForm()
        {
            InitializeComponent();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            string x = "pb" + curTile;
            PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;
            pb.Visible = true;
            playerMarker.Visible = false;

            DataAccess.characterQuits(curTile, Main.M.Username, Main.M.GameNumber);
            Hide();
            LobbyForm.Lobby.Show();
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

        public void characterSetup() // Creating an eclipse that will show the players current location
        {
            curTile = 68;
            pb68.Visible = false;
            playerMarker.Visible = true;
            int x = Main.M.GameNumber;
            DataAccess.checkCharacter(Main.M.Username, Main.M.GameNumber);

            DataAccess.getColour(Main.M.Username, x);
            playerMarker.BackColor = ColorTranslator.FromHtml(DataAccess.message);
            playerMarker.ForeColor = ColorTranslator.FromHtml(DataAccess.message);
            playerMarker.FlatStyle = FlatStyle.Flat;
            playerMarker.Location = new System.Drawing.Point(707, 470);
            playerMarker.Name = "buttonEllipse1";
            playerMarker.Size = new System.Drawing.Size(86, 86);
            playerMarker.Invalidate();
            playerMarker.Text = Main.M.CharacterName;
            playerMarker.Enabled = false;
            playerMarker.Font = new Font("Arial", 12);
            Controls.Add(playerMarker);
            playerMarker.BringToFront();

        }
        private void characterCheckLocation()
        {

            if (preTile == 15 && curTile == 16 ||
                preTile == 30 && curTile == 31 ||
                preTile == 45 && curTile == 46 ||
                preTile == 60 && curTile == 61 ||
                preTile == 75 && curTile == 76 ||
                preTile == 90 && curTile == 91 ||
                preTile == 105 && curTile == 106 ||
                preTile == 120 && curTile == 121 ||
                preTile == 135 && curTile == 136)
            {
                curTile = curTile - 15;
               DataAccess.checkCharacterLocation(curTile, Main.M.Username, Main.M.GameNumber);
                if (DataAccess.message == "invalidMove")
                {
                    curTile = preTile;
                    preTile = prePreTile;
                    gameLOneErrorLbl.Visible = true;
                    gameLTwoErrorLbl.Visible = true;
                }
                else if (DataAccess.message == "succMove")
                {
                    characterMove();
                    gameLOneErrorLbl.Visible = false;
                    gameLTwoErrorLbl.Visible = false;
                }
            }

            else if (preTile == 1 && curTile == 0 ||
                preTile == 16 && curTile == 15 ||
                preTile == 31 && curTile == 30 ||
                preTile == 46 && curTile == 45 ||
                preTile == 61 && curTile == 60 ||
                preTile == 76 && curTile == 75 ||
                preTile == 91 && curTile == 90 ||
                preTile == 106 && curTile == 105 ||
                preTile == 121 && curTile == 120)
            {
                curTile = curTile + 15;
                DataAccess.checkCharacterLocation(curTile, Main.M.Username, Main.M.GameNumber);
                if (DataAccess.message == "invalidMove")
                {
                    curTile = preTile;
                    preTile = prePreTile;
                    gameLOneErrorLbl.Visible = true;
                    gameLTwoErrorLbl.Visible = true;
                }
                else if (DataAccess.message == "succMove")
                {
                    characterMove();
                    gameLOneErrorLbl.Visible = false;
                    gameLTwoErrorLbl.Visible = false;
                }
            }

            else if (preTile == 121 && curTile == 136 ||
                preTile == 122 && curTile == 137 ||
                preTile == 123 && curTile == 138 ||
                preTile == 124 && curTile == 139 ||
                preTile == 125 && curTile == 140 ||
                preTile == 126 && curTile == 141 ||
                preTile == 127 && curTile == 142 ||
                preTile == 128 && curTile == 143 ||
                preTile == 129 && curTile == 144 ||
                preTile == 130 && curTile == 145 ||
                preTile == 131 && curTile == 146 ||
                preTile == 132 && curTile == 147 ||
                preTile == 133 && curTile == 148 ||
                preTile == 134 && curTile == 149 ||
                preTile == 135 && curTile == 150)
            {
                curTile = curTile - 135;
                DataAccess.checkCharacterLocation(curTile, Main.M.Username, Main.M.GameNumber);
                if (DataAccess.message == "invalidMove")
                {
                    curTile = preTile;
                    preTile = prePreTile;
                    gameLOneErrorLbl.Visible = true;
                    gameLTwoErrorLbl.Visible = true;
                }
                else if (DataAccess.message == "succMove")
                {
                    characterMove();
                    gameLOneErrorLbl.Visible = false;
                    gameLTwoErrorLbl.Visible = false;
                }
            }

           else if (preTile == 1 && curTile == -14 ||
                preTile == 2 && curTile == -13 ||
                preTile == 3 && curTile == -12 ||
                preTile == 4 && curTile == -11 ||
                preTile == 5 && curTile == -10 ||
                preTile == 6 && curTile == -9 ||
                preTile == 7 && curTile == -8 ||
                preTile == 8 && curTile == -7 ||
                preTile == 9 && curTile == -6 ||
                preTile == 10 && curTile == -5 ||
                preTile == 11 && curTile == -4 ||
                preTile == 12 && curTile == -3 ||
                preTile == 13 && curTile == -2 ||
                preTile == 14 && curTile == -1 ||
                preTile == 15 && curTile == 0)
            {
                curTile = curTile + 135;
                DataAccess.checkCharacterLocation(curTile, Main.M.Username, Main.M.GameNumber);
                if (DataAccess.message == "invalidMove")
                {
                    curTile = preTile;
                    preTile = prePreTile;
                    gameLOneErrorLbl.Visible = true;
                    gameLTwoErrorLbl.Visible = true;
                }
                else if (DataAccess.message == "succMove")
                {
                    characterMove();
                    gameLOneErrorLbl.Visible = false;
                    gameLTwoErrorLbl.Visible = false;
                }
            } 
            else
            {
                DataAccess.checkCharacterLocation(curTile, Main.M.Username, Main.M.GameNumber);
                if (DataAccess.message == "invalidMove")
                {
                    curTile = preTile;
                    preTile = prePreTile;
                    gameLOneErrorLbl.Visible = true;
                    gameLTwoErrorLbl.Visible = true;
                }
                else if (DataAccess.message == "succMove")
                {
                    characterMove();
                    gameLOneErrorLbl.Visible = false;
                    gameLTwoErrorLbl.Visible = false;
                }
            }
        }

        private void characterMove()
        {
            string x = "pb" + curTile;                                                    // gets picturebox name
            PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;        // targets control with the name from above
            pb.Visible = false;                                                           // changes the controls properties
            Point pt = pb.FindForm().PointToClient(pb.Parent.PointToScreen(pb.Location)); // gets control location
            Size locationOfMove = new Size(pt);                                           // converts to size
            playerMarker.Location = new System.Drawing.Point(locationOfMove);             // moves character to tile
            showPreviousTile(preTile);
        }
        private void showPreviousTile(int tile)
        {
            string x = "pb" + tile; // gets picturebox name
            PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;
            pb.Visible = true;
        }

        private void moveUp()
        {
            prePreTile = preTile;
            preTile = curTile;
            curTile = curTile - 15;
            characterCheckLocation();
        }
        private void moveDown()
        {
            prePreTile = preTile;
            preTile = curTile;
            curTile = curTile + 15;
            characterCheckLocation();
        }
        private void moveLeft()
        {
            prePreTile = preTile;
            preTile = curTile;
            curTile = curTile - 1;
            characterCheckLocation();
        }
        private void moveRight()
        {
            prePreTile = preTile;
            preTile = curTile;
            curTile = curTile + 1;
            characterCheckLocation();
        }

    }
}
