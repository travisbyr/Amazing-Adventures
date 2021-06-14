using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmazingAdventures
{
    public partial class ChatForm : Form
    {

        private static readonly ChatForm _instance = new ChatForm();

        public static ChatForm Chat => _instance;

        static ChatForm() { }

        public ChatForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chatCloseBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
