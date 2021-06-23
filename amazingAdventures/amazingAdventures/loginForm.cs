using System;
using System.Drawing;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class LoginForm : Form
    {
        private static readonly LoginForm _instance = new LoginForm();
        public static LoginForm Login => _instance;
        static LoginForm() { }
        
        public LoginForm()
        {
            InitializeComponent();
            DataAccess.CreateDB(); // Creates the tables
            DataAccess.ModifyDB(); // Adds game components to tables, e.g items.
            loginBtn.FlatAppearance.BorderColor = Color.DarkGreen;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }
        private void login()
        {
            DataAccess.CheckUsername(loginUsername.Text);
            if (DataAccess.Message == "avaliableUsername") // If username is avaliable
            {
                usrnInvalidFirstLabel.Visible = true;
                usrnInvalidFirstLabel.Location = new Point(185, 284);
                usrnInvalidSecondLabel.Visible = true;
                usrnInvalidSecondLabel.Location = new Point(86, 304);
                loginBtn.Location = new Point(147, 235);
                loginPassword.Visible = true;
                loginPasswordLabel.Visible = true;
                usrnInvalidFirstLabel.Text = "New Username Detected";
                usrnInvalidSecondLabel.Text = "Please enter a password to register an account";

                if (loginPassword.Text != "" && loginUsername.Text != "")
                {
                    DialogResult dialogResult = MessageBox.Show("Would you like to create an account using the password and username typed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataAccess.AccountCreate(loginUsername.Text, loginPassword.Text, "remove");
                        MessageBox.Show("Account has been successfully created.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataAccess.AccountLogin(loginUsername.Text, loginPassword.Text);
                        Hide();
                        Main.M.Username = loginUsername.Text;
                        LobbyForm.Lobby.Show();
                        LobbyForm.Lobby.viewPlayersOnline();

                        usrnInvalidFirstLabel.Visible = false;
                        usrnInvalidFirstLabel.Location = new Point(178, 225);
                        usrnInvalidSecondLabel.Visible = false;
                        usrnInvalidSecondLabel.Location = new Point(79, 245);
                        loginBtn.Location = new Point(140, 176);
                        loginPassword.Visible = false;
                        loginPasswordLabel.Visible = false;
                        loginUsername.Text = "";
                        loginPassword.Text = "";
                    }
                }
            } 
            else if (DataAccess.Message == "unavaliableUsername") // If username is taken
            {
                DataAccess.AccountLogin(loginUsername.Text, loginPassword.Text); // Check login
                if (loginPassword.Text == "")
                {
                    usrnInvalidFirstLabel.Visible = true;
                    usrnInvalidFirstLabel.Location = new Point(185, 284);
                    usrnInvalidSecondLabel.Visible = true;
                    usrnInvalidSecondLabel.Location = new Point(86, 304);
                    loginBtn.Location = new Point(147, 235);
                    loginPassword.Visible = true;
                    loginPasswordLabel.Visible = true;
                    usrnInvalidFirstLabel.Text = "";
                    usrnInvalidSecondLabel.Text = "";
                }
                else if (DataAccess.Message == "NLogin" && loginPassword.Text != "") // If the login is wrong
                {
                    usrnInvalidFirstLabel.Text = "Incorrect Details";
                    usrnInvalidSecondLabel.Text = "Please enter the correct account details to proceed";

                } 
                else if (DataAccess.Message == "maxLoginAttempts") // If the login has max attempts
                {
                    usrnInvalidFirstLabel.Text = "Account Locked";
                    usrnInvalidSecondLabel.Text = "Email an administrator to unlock this account";
                    usrnInvalidFirstLabel.Visible = true;
                    usrnInvalidSecondLabel.Visible = true;
                } 
                else if (DataAccess.Message == "SLogin") // If the login is successful
                {
                    usrnInvalidFirstLabel.Visible = false;
                    usrnInvalidSecondLabel.Visible = false;
                    Main.M.Username = loginUsername.Text;
                    LobbyForm.Lobby.Show();
                    LobbyForm.Lobby.viewPlayersOnline();
                    Hide();
                }
            }
        }
    }
}
 