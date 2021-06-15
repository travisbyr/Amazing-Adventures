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
            refreshChat();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chatCloseBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void refreshChat()
        {
            chatMessageListBox.Items.Clear();
            Main.ChatList.Clear();
            DataAccess.readGlobalChat();
            if (DataAccess.Message == "foundChatText")
            {
                foreach (Chat item in Main.ChatList)
                {
                    chatMessageListBox.Items.Add(item.ChatDateTime + " - " + item.PlayerUsername + " - " + item.ChatText);
                }
            }
        }

        private void submitChatBtn_Click(object sender, EventArgs e)
        {
            if (chatTxtBox.Text.Length >= 51)
            {
                chatErrorLine.Visible = true;
            }
            else
            {
                DataAccess.globalChat(chatTxtBox.Text, Main.M.Username);
                chatTxtBox.Text = "";
                chatErrorLine.Visible = false;
                refreshChat();
            }
        }
    }      
}
