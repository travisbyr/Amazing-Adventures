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
            //panel.BackColor = ColorTranslator.FromHtml("#ffff99");
            InitializeComponent();
            characterSetup();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            showPreviousTile();
            characterTile = characterTile - 15;
            characterMove();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            showPreviousTile();
            characterTile = characterTile + 15;
            characterMove();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            showPreviousTile();
            characterTile = characterTile - 1;
            characterMove();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            showPreviousTile();
            characterTile = characterTile + 1;
            characterMove();
        }

        private void characterSetup()
        {
            pb68.Visible = false;
            buttonEllipse1.Location = new System.Drawing.Point(707, 470);
            buttonEllipse1.Name = "buttonEllipse1";
            buttonEllipse1.Size = new System.Drawing.Size(86, 86);
            buttonEllipse1.Invalidate();
            buttonEllipse1.Text = "buttonEllipse1";
            buttonEllipse1.Enabled = false;
            buttonEllipse1.UseVisualStyleBackColor = true;
            Controls.Add(buttonEllipse1);
            buttonEllipse1.BringToFront();

        }
        private void characterMove()
        {
            string x = "pb" + characterTile; // gets picturebox name
            PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox; // targets control with the name from above
            pb.Visible = false; // changes the controls properties
            Point pt = pb.FindForm().PointToClient(pb.Parent.PointToScreen(pb.Location)); // gets control location
            Size locationOfMove = new Size(pt); // converts to size
            buttonEllipse1.Location = new System.Drawing.Point(locationOfMove); // moves character to tile
        }

        private void showPreviousTile()
        {
            string x = "pb" + characterTile; // gets picturebox name
            PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;
            pb.Visible = true;
        }
    }
}
