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
    public partial class LoginForm : Form
    {
        public static string username;

        private static readonly LoginForm _instance = new LoginForm();

        public static LoginForm Login => _instance;

        static LoginForm() { }
        
        public LoginForm()
        {
            InitializeComponent();
            DataAccess.createdb(); // Creates the tables
            DataAccess.modifydb(); // Creates the items
            DataAccess.testData(); // Creates the test data
            registerBtn.FlatAppearance.BorderColor = Color.Blue;
            loginBtn.FlatAppearance.BorderColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            username = loginUsername.Text;
            new RegisterForm().Show();
        }

        private void login()
        {
            DataAccess.checkUsername(loginUsername.Text);
            if (DataAccess.message == "avaliableUsername")
            {
                registerBtn.Visible = true;
                usrnValidFirstLine.Visible = true;
                usrnValidSecondLine.Visible = true;
                usrnInvalidFirstLabel.Visible = false;
                usrnInvalidSecondLabel.Visible = false;
            } else if (DataAccess.message == "unavaliableUsername")
            {
                //MessageBox.Show("Error! Username or Password is invalid.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DataAccess.accountLogin(loginUsername.Text, loginPassword.Text);
                //MessageBox.Show(DataAccess.message);
                if (DataAccess.message == "NLogin")
                {
                    usrnValidFirstLine.Visible = false;
                    usrnValidSecondLine.Visible = false;
                    usrnInvalidFirstLabel.Text = "Invalid Login.";
                    usrnInvalidSecondLabel.Text = "Please try again.";
                    usrnInvalidFirstLabel.Visible = true;
                    usrnInvalidSecondLabel.Visible = true;
                } else if (DataAccess.message == "maxLoginAttempts")
                {
                    usrnValidFirstLine.Visible = false;
                    usrnValidSecondLine.Visible = false;
                    usrnInvalidFirstLabel.Text = "Account Locked";
                    usrnInvalidSecondLabel.Text = "Email an administrator to unlock this account";
                    usrnInvalidFirstLabel.Visible = true;
                    usrnInvalidSecondLabel.Visible = true;
                } else if (DataAccess.message == "SLogin")
                {
                    LobbyForm.Lobby.Show();
                    Hide();
                }
            }
        }
    }
}
