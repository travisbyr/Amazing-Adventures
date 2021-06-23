﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
           InitializeComponent();
           registerBtn.FlatAppearance.BorderColor = Color.DarkGreen;
           registerUsername.Text = Main.M.Username;
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            DataAccess.AccountCreate(registerUsername.Text, registerPassword.Text, registerEmail.Text);
            MessageBox.Show("Account has been successfully created.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm.Login.registerBtn.Visible = false;
            LoginForm.Login.usrnValidFirstLine.Visible = false;
            LoginForm.Login.usrnValidSecondLine.Visible = false;
            Hide();
        }
    }
}
