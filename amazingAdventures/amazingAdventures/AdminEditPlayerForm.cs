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
    public partial class AdminEditPlayerForm : Form
    {
        private static readonly AdminEditPlayerForm _instance = new AdminEditPlayerForm();
        public static AdminEditPlayerForm AdminEdit => _instance;
        static AdminEditPlayerForm() { }
        public AdminEditPlayerForm()
        {
            InitializeComponent();
        }
    }
}
