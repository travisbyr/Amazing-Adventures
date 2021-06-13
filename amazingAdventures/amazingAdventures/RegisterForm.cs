﻿using System;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
           InitializeComponent();
           registerBtn.FlatAppearance.BorderColor = Color.Blue;
           registerUsername.Text = LoginForm.username;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            DataAccess.accountCreate(registerUsername.Text, registerPassword.Text, registerEmail.Text);
            MessageBox.Show("Account has been successfully created.");
            LoginForm.Login.registerBtn.Visible = false;
            LoginForm.Login.usrnValidFirstLine.Visible = false;
            LoginForm.Login.usrnValidSecondLine.Visible = false;
            this.Close();
        }
    }
}