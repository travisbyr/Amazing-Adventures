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
    public partial class AdminCreatePlayerForm : Form
    {
        private static readonly AdminCreatePlayerForm _instance = new AdminCreatePlayerForm();
        public static AdminCreatePlayerForm AdminCreate => _instance;
        static AdminCreatePlayerForm() { }
        public AdminCreatePlayerForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

        }
    }
}