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
    public partial class loginForm : Form
    {
        public loginForm()
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
            } else
            {
                usrnInvalidFirstLabel.Visible = true;
                usrnInvalidSecondLabel.Visible = true;
                //MessageBox.Show("Error! Username or Password is invalid.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show(DataAccess.message);
        }
    }
}
