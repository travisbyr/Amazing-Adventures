using System;
using System.Windows.Forms;

namespace amazingAdventures
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
        private void chatCloseBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void refreshChat()
        {
            chatMessageListBox.Items.Clear(); // Clear chat listbox
            Main.ChatList.Clear(); // Clear chat messages list
            DataAccess.ReadGlobalChat(); // Add chat messages from database to list
            if (DataAccess.Message == "foundChatText")
            {
                foreach (Chat item in Main.ChatList)
                {
                    chatMessageListBox.Items.Add(item.ChatDateTime + " - " + item.PlayerUsername + " - " + item.ChatText); // Add chat messages
                }
            }
            int visibleItems = chatMessageListBox.ClientSize.Height / chatMessageListBox.ItemHeight;
            chatMessageListBox.TopIndex = Math.Max(chatMessageListBox.Items.Count - visibleItems + 1, 0); // Chatbox sticks to buttom of scroll
        }
        private void submitChatBtn_Click(object sender, EventArgs e)
        {
            if (chatTxtBox.Text.Length >= 51) // if chat length is less than max
            {
                chatErrorLine.Visible = true;
            }
            else // If so submit the text
            {
                DataAccess.SubmitGlobalChat(chatTxtBox.Text, Main.M.Username);
                chatTxtBox.Text = "";
                chatErrorLine.Visible = false;
                refreshChat();
            }
        }
    }      
}
