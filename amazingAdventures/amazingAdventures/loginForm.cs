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

            } else
            {
                MessageBox.Show("Unavliable username");
            }
            MessageBox.Show(DataAccess.message);
        }
    }
}
