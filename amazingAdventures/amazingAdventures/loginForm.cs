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
            DataAccess.ModifyDB(); // Creates the items
            DataAccess.TestData(); // Creates the test data
            registerBtn.FlatAppearance.BorderColor = Color.DarkGreen;
            loginBtn.FlatAppearance.BorderColor = Color.DarkGreen;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            Main.M.Username = loginUsername.Text;
            new RegisterForm().Show();
        }
        private void login()
        {
            DataAccess.CheckUsername(loginUsername.Text);
            if (DataAccess.Message == "avaliableUsername") // If username is avaliable, offer registration
            {
                registerBtn.Visible = true;
                usrnValidFirstLine.Visible = true;
                usrnValidSecondLine.Visible = true;
                usrnInvalidFirstLabel.Visible = false;
                usrnInvalidSecondLabel.Visible = false;
            } 
            else if (DataAccess.Message == "unavaliableUsername") // If username is taken
            {
                registerBtn.Visible = false;
                DataAccess.AccountLogin(loginUsername.Text, loginPassword.Text); // Check login
                if (DataAccess.Message == "NLogin") // If the login is wrong
                {
                    usrnValidFirstLine.Visible = false;
                    usrnValidSecondLine.Visible = false;
                    usrnInvalidFirstLabel.Text = "Invalid Login.";
                    usrnInvalidSecondLabel.Text = "Please try again.";
                    usrnInvalidFirstLabel.Visible = true;
                    usrnInvalidSecondLabel.Visible = true;
                } else if (DataAccess.Message == "maxLoginAttempts") // If the login has max attempts
                {
                    usrnValidFirstLine.Visible = false;
                    usrnValidSecondLine.Visible = false;
                    usrnInvalidFirstLabel.Text = "Account Locked";
                    usrnInvalidSecondLabel.Text = "Email an administrator to unlock this account";
                    usrnInvalidFirstLabel.Visible = true;
                    usrnInvalidSecondLabel.Visible = true;
                } else if (DataAccess.Message == "SLogin") // If the login is successful
                {
                    usrnValidFirstLine.Visible = false;
                    usrnValidSecondLine.Visible = false;
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
 