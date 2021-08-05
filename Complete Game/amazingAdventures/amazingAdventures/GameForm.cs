using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class GameForm : Form
    {
        ButtonEllipse playerMarker = new ButtonEllipse();
        Button Ubtn = new Button();
        Button Rbtn = new Button();
        Button Dbtn = new Button();
        Button Lbtn = new Button();
        public int points = 0;
        public int prePreTile;
        public int preTile = 0;
        public int curTile;
        public static int n = 0;

        private static readonly GameForm _instance = new GameForm();
        public static GameForm Game => _instance;
        static GameForm() { }
        public GameForm()
        {
            InitializeComponent();
            Ubtn.Click += new EventHandler(ubtn_Click);
            Rbtn.Click += new EventHandler(rbtn_Click);
            Dbtn.Click += new EventHandler(dbtn_Click);
            Lbtn.Click += new EventHandler(lbtn_Click);
        }
        private void leaveBtn_Click(object sender, EventArgs e)
        {
            string x = "pb" + curTile;
            PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox; // Find the control
            pb.Visible = true;
            playerMarker.Visible = false; // Remove character from board
            DataAccess.CharacterQuits(curTile, Main.M.Username, Main.M.GameNumber);
            Hide();
            LobbyForm.Lobby.viewPlayersOnline();
            LobbyForm.Lobby.Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        { // if arrow keys are pressed
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
        public void characterSetup()
        {
            DataAccess.AddItems(Main.M.GameNumber); // Add items to game
            otherCharactersMarker();
            itemMarker();
            onScreenControlSetup();
            characterMove();

            int a = Main.M.GameNumber;
            DataAccess.CheckCharacter(Main.M.Username, Main.M.GameNumber);
            DataAccess.GetCharacterColour(Main.M.Username, a); // Set playermarker properties
            playerMarker.BackColor = ColorTranslator.FromHtml(DataAccess.Message);
            playerMarker.ForeColor = ColorTranslator.FromHtml(DataAccess.Message);
            playerMarker.FlatStyle = FlatStyle.Flat;
            playerMarker.Name = "playerButtonEllipse";
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
            if (preTile == 15 && curTile == 16 || // If character is move from the right last tile
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
            }
            else if (preTile == 1 && curTile == 0 || // If the character is moving from the left last tile
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
            }
            else if (preTile == 121 && curTile == 136 || // If the character is moving from the buttom last tile, downwards
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
            }
           else if (preTile == 1 && curTile == -14 || // If the character is moving from the top highest tile, upwards.
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
            } 

            DataAccess.CheckCharacterLocation(curTile, Main.M.Username, Main.M.GameNumber);
            if (DataAccess.Message == "invalidMove") // If move is invalid
            {
                curTile = preTile;
                preTile = prePreTile;
                characterMove();
            }
            else if (DataAccess.Message == "itemFound") // If an item is found
            {
                characterMove();
                DataAccess.AddItems(Main.M.GameNumber);
                itemMarker();
            }
            else if (DataAccess.Message == "trapFound") // If the character hits a trap
            {
                GameLoseForm.GameLose.Show();
                Hide();
                DataAccess.GetCharacterScore(Main.M.Username, Main.M.GameNumber);
                GameLoseForm.GameLose.pointsEndLabel.Text = DataAccess.Points + " Points"; // Update the game lose form
            }
            else
            {
                characterMove(); // Anything else move character as its a normal move
            }
        }
        private void characterMove()
        {
            DataAccess.CheckGameExists(Main.M.GameNumber);
            updateCharacterLeaderboard();
            if (DataAccess.gameStatus == "gameClosed") // If the game is closed
            {
                Hide();
                DataAccess.GetCharacterScore(Main.M.Username, Main.M.GameNumber);
                GameLoseForm.GameLose.pointsEndLabel.Text = DataAccess.Points + " Points";
                GameLoseForm.GameLose.Show();
            }
            else // Otherwise move character
            {
                otherCharactersMarker();
                itemMarker();
                DataAccess.GetCharacterLocation(Main.M.Username, Main.M.GameNumber);
                string x = "pb" + curTile;                                                    // gets picturebox name
                PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;        // targets control with the name from above
                pb.Visible = false;                                                           // changes the controls properties

                Point pt = pb.FindForm().PointToClient(pb.Parent.PointToScreen(pb.Location)); // gets control location
                Size locationOfMove = new Size(pt);                                           // converts to size
                playerMarker.Visible = true;
                playerMarker.Location = new System.Drawing.Point(locationOfMove);             // moves character to tile
                playerMarker.BringToFront();
            }
        }
        private void otherCharactersMarker()
        {
            if (Main.CharacterList.Count() > 0)
            {
                foreach (Characters item in Main.CharacterList) // Remove all characters from list if some exist
                {
                    if (item.TileID != null)
                    {
                        string x = "pb" + item.TileID;
                        PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;
                        pb.Visible = true;
                        var labelToRemove = Controls[item.ID.ToString()];
                        Controls.Remove(labelToRemove);
                    }
                }
            }

            int b = n;
            Main.CharacterList.Clear();
            DataAccess.GetAllCharacterPositions(Main.M.Username, Main.M.GameNumber);
            n = Main.CharacterList.Count();
            ButtonEllipse[] button = new ButtonEllipse[n];

            for (int i = 0; i < n; i++) // Add the new characters to the list
            { 
                foreach (Characters item in Main.CharacterList) // For every character in the list
                {
                    if (item.TileID != null)
                    {
                        string x = "pb" + item.TileID;                                                // gets picturebox name
                        PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;        // targets control with the name from above
                        pb.Visible = false;                                                           // changes the controls properties
                        Point pt = pb.FindForm().PointToClient(pb.Parent.PointToScreen(pb.Location)); // gets control location
                        Size playerLocation = new Size(pt);                                           // converts to size

                        button[i] = new ButtonEllipse();

                        button[i].BackColor = ColorTranslator.FromHtml(item.Colour);
                        button[i].ForeColor = ColorTranslator.FromHtml(item.Colour);
                        button[i].FlatStyle = FlatStyle.Flat;
                        button[i].Location = new System.Drawing.Point(playerLocation);
                        button[i].Name = item.ID.ToString();
                        button[i].Size = new System.Drawing.Size(86, 86);
                        button[i].Invalidate();
                        button[i].Text = item.Name;
                        button[i].Enabled = false;
                        button[i].Font = new Font("Arial", 12);
                        Controls.Add(button[i]);
                        button[i].BringToFront();
                        i++;
                    }
                }
            }
        }
        private void itemMarker()
        {
            if (Main.ItemList.Count() > 0)
            {
                foreach (Items item in Main.ItemList)
                {
                    string x = "pb" + item.TileID;
                    PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;
                    pb.Image = null;
                    pb.Visible = false;

                    Point pt = pb.FindForm().PointToClient(pb.Parent.PointToScreen(pb.Location));
                    Size locationOfMove = new Size(pt.X - 14, pt.Y - 14);
                    pb.Location = new System.Drawing.Point(locationOfMove);
                }
            }

            onScreenControls();

            Main.ItemList.Clear();
            DataAccess.GetGameItems(Main.M.GameNumber);
            int n = Main.ItemList.Count();

            for (int i = 0; i < n; i++)
            {
                foreach (Items item in Main.ItemList) // Add tiles to list
                {
                    string x = "pb" + item.TileID;                                                
                    PictureBox pb = Controls.Find(x, true).FirstOrDefault() as PictureBox;
                    Point pt = pb.FindForm().PointToClient(pb.Parent.PointToScreen(pb.Location));
                    Size locationOfMove = new Size(pt.X + 14, pt.Y + 14);
                    pb.Location = new System.Drawing.Point(locationOfMove);
                    pb.Size = new System.Drawing.Size(60, 60);
                    Image image = Image.FromFile(@item.Photo);
                    pb.Image = image;
                    pb.BackColor = Color.Transparent;
                    pb.Visible = true;
                    pb.BringToFront();
                    i++;
                }
            }
        }
        private void gameFormChatBtn_Click(object sender, EventArgs e)
        {
            ChatForm.Chat.Show();
        }
        private void onScreenControls()
        {
            DataAccess.GetCharacterLocation(Main.M.Username, Main.M.GameNumber);
            bool x = true;
            for (int i = 1; i <= 15; i++) // On screen controls for Up arrow
            {
                if(curTile == i)
                {
                    x = false;
                    Ubtn.Visible = false;
                }
            }

            if (x == true)
            {
                DataAccess.GetCharacterLocation(Main.M.Username, Main.M.GameNumber);
                string a = "pb" + (curTile - 15);
                PictureBox pbU = Controls.Find(a, true).FirstOrDefault() as PictureBox;
                Point ptU = pbU.FindForm().PointToClient(pbU.Parent.PointToScreen(pbU.Location));
                Size locationOfUbtn = new Size(ptU);
                Ubtn.Location = new System.Drawing.Point(locationOfUbtn);
                Ubtn.Text = "ᐃ";
                Ubtn.Font = new Font("Arial", 40);
                Ubtn.BackColor = Color.White;
                Ubtn.FlatStyle = FlatStyle.Flat;
                Ubtn.FlatAppearance.BorderColor = Color.White;
                Ubtn.FlatAppearance.BorderSize = 1;
                Ubtn.TabStop = false;
                Ubtn.Visible = true;
            }

            x = true;

            for (int i = 121; i <= 135; i++) // On screen controls for Down arrow
            {
                if (curTile == i)
                {
                    x = false;
                    Dbtn.Visible = false;
                }
            }
            if (x == true)
            {
                string c = "pb" + (curTile + 15);
                PictureBox pbD = Controls.Find(c, true).FirstOrDefault() as PictureBox;
                Point ptD = pbD.FindForm().PointToClient(pbD.Parent.PointToScreen(pbD.Location));
                Size locationOfDbtn = new Size(ptD);
                Dbtn.Location = new System.Drawing.Point(locationOfDbtn);
                Dbtn.Text = "ᐁ";
                Dbtn.Font = new Font("Arial", 40);
                Dbtn.BackColor = Color.White;
                Dbtn.FlatStyle = FlatStyle.Flat;
                Dbtn.FlatAppearance.BorderColor = Color.White;
                Dbtn.FlatAppearance.BorderSize = 1;
                Dbtn.TabStop = false;
                Dbtn.Visible = true;
            }

            x = true;

            for (int i = 15; i <= 135; i = i + 15) // On screen controls for Right arrow
            {
                if (curTile == i)
                {
                    x = false;
                    Rbtn.Visible = false;
                }
            }
            if (x == true)
            {
                string b = "pb" + (curTile + 1);
                PictureBox pbR = Controls.Find(b, true).FirstOrDefault() as PictureBox;
                Point ptR = pbR.FindForm().PointToClient(pbR.Parent.PointToScreen(pbR.Location));
                Size locationOfRbtn = new Size(ptR);
                Rbtn.Location = new System.Drawing.Point(locationOfRbtn);
                Rbtn.Text = "ᐅ";
                Rbtn.Font = new Font("Arial", 40);
                Rbtn.BackColor = Color.White;
                Rbtn.FlatStyle = FlatStyle.Flat;
                Rbtn.FlatAppearance.BorderColor = Color.White;
                Rbtn.FlatAppearance.BorderSize = 1;
                Rbtn.TabStop = false;
                Rbtn.Visible = true;
            }

            x = true;


            for (int i = 1; i <= 121; i = i + 15) // On screen controls for Left arrow
            {
                if (curTile == i)
                {
                    x = false;
                    Lbtn.Visible = false;
                }
            }
            if (x == true)
            {
                string d = "pb" + (curTile - 1);
                PictureBox pbL = Controls.Find(d, true).FirstOrDefault() as PictureBox;
                Point ptL = pbL.FindForm().PointToClient(pbL.Parent.PointToScreen(pbL.Location));
                Size locationOfLbtn = new Size(ptL);
                Lbtn.Location = new System.Drawing.Point(locationOfLbtn);
                Lbtn.Text = "ᐊ";
                Lbtn.Font = new Font("Arial", 40);
                Lbtn.BackColor = Color.White;
                Lbtn.FlatStyle = FlatStyle.Flat;
                Lbtn.FlatAppearance.BorderColor = Color.White;
                Lbtn.FlatAppearance.BorderSize = 1;
                Lbtn.TabStop = false;
                Lbtn.Visible = true;
            }
        }
        private void onScreenControlSetup()
        {
            Ubtn.Size = new System.Drawing.Size(86, 86); // Creating the on screen controls
            Ubtn.Name = "Ubtn";
            Controls.Add(Ubtn);
            Ubtn.BringToFront();

            Rbtn.Size = new System.Drawing.Size(86, 86);
            Rbtn.Name = "RBtn";
            Controls.Add(Rbtn);
            Rbtn.BringToFront();

            Dbtn.Size = new System.Drawing.Size(86, 86);
            Dbtn.Name = "Dbtn";
            Controls.Add(Dbtn);
            Dbtn.BringToFront();

            Lbtn.Size = new System.Drawing.Size(86, 86);
            Lbtn.Name = "Lbtn";
            Controls.Add(Lbtn);
            Lbtn.BringToFront();


        }
        public void updateCharacterLeaderboard()
        {
            DataAccess.GetCharacterScore(Main.M.Username, Main.M.GameNumber); // Get the character scores from the game

            gameLeaderboardDGV.DataSource = null;
            Leaderboard.GameCharacterList.Clear(); // Clear the list
            DataAccess.GetGameCharacterScores(Main.M.GameNumber); // Add the characters
            gameLeaderboardDGV.DataSource = Leaderboard.GameCharacterList.OrderByDescending(a => a.Score).ToList(); // Sort the data source
            gameLeaderboardDGV.Columns.OfType<DataGridViewColumn>().ToList().ForEach(col => col.Visible = false); // Remove all columns
            gameLeaderboardDGV.Columns["Character"].Visible = true; // Add only needed columns
            gameLeaderboardDGV.Columns["Score"].Visible = true;
            gameLeaderboardDGV.Columns["Score"].Width = 100;
            gameLeaderboardDGV.ClearSelection();
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

        private void ubtn_Click(object sender, System.EventArgs e)
        {
            moveUp();
        }
        private void dbtn_Click(object sender, System.EventArgs e)
        {
            moveDown();
        }
        private void lbtn_Click(object sender, System.EventArgs e)
        {
            moveLeft();
        }
        private void rbtn_Click(object sender, System.EventArgs e)
        {
            moveRight();
        }
    }
}

