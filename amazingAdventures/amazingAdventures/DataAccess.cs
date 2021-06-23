using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace amazingAdventures
{
    public class DataAccess
    {
        // PUBLIC VARIABLES

        public static string Message = "";
        public static string gameStatus = "gameOpen";

        // CONNECTION TO DATABASE

        private static MySqlConnection connect = new MySqlConnection("server=localhost;user id=root;password=ps3Lot~m;database=DAT602_Assessment;persistsecurityinfo=True");

        // SETTING UP DATABASE

        public static void createdb()
        {
            MySqlCommand cmd = new MySqlCommand("createdb", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            myReader.Close();
            connect.Close();
        }

        public static void modifydb()
        {
            MySqlCommand cmd = new MySqlCommand("modifyDB", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            myReader.Close();
            connect.Close();
        }

        public static void testData()
        {
            MySqlCommand cmd = new MySqlCommand("editDB", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            myReader.Close();
            connect.Close();
        }

        // ACCOUNT FUNCTIONALITY

        public static void accountCreate(string pusername, string ppassword, string pemail)
        {
            MySqlCommand cmd = new MySqlCommand("accountCreate", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUserName", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pPassword", ppassword); // Add a parameter
            cmd.Parameters.AddWithValue("pEmail", pemail); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void checkUsername(string pusername)
        {
            MySqlCommand cmd = new MySqlCommand("checkUsername", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUserName", pusername); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void accountLogin(string pusername, string ppassword)
        {
            MySqlCommand cmd = new MySqlCommand("accountLogin", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUserName", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pPassword", ppassword); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void accountLogout(string pusername)
        {
            MySqlCommand cmd = new MySqlCommand("accountLogout", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUserName", pusername); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }

        }

        // GAME FUNCTIONALITY

        public static void gameCreation(string pusername, string pgamename)
        {
            MySqlCommand cmd = new MySqlCommand("gameCreation", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUserName", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pGameName", pgamename); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void gamesList()
        {
            MySqlCommand cmd = new MySqlCommand("listOfGames", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message
                    Main.M.GameListName.Add(myReader.GetString("GameName"));
                    Main.M.GameListID.Add(Int32.Parse(myReader.GetString("GameID")));
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void characterJoinGame(int pgamenumber, string pcharactername, string pcharactercolour, string pusername)
        {
            MySqlCommand cmd = new MySqlCommand("characterJoinGame", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            cmd.Parameters.AddWithValue("pCharacterName", pcharactername); // Add a parameter
            cmd.Parameters.AddWithValue("pCharacterColour", pcharactercolour); // Add a parameter
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void checkCharacterLocation(int ptile, string pusername, int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("checkCharacterLocation", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pTile", ptile); // Add a parameter
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void getCharacterLocation(string pusername, int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("characterCurrentTile", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                   // Message = myReader.GetString("cTile"); // Get message
                    GameForm.Game.curTile = Int32.Parse(myReader.GetString("cTile"));
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void characterQuits(int ptile, string pusername, int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("characterQuits", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pTile", ptile); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void characterRejoins(string pusername, int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("characterRejoins", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message 
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void gameClose(string pusername)
        {
            MySqlCommand cmd = new MySqlCommand("gameClose", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                  //  gameStatus = myReader.GetString("MESSAGE"); // Get message 
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void viewOnlinePlayers()
        {
            MySqlCommand cmd = new MySqlCommand("viewOnlinePlayers", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    string a = myReader.GetString("PlayerUsername");
                    int b = Int32.Parse(myReader.GetString("Highscore"));
                    Leaderboard.LeaderboardList.Add(new Leaderboard() { Player = a, Highscore = b});
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }
        public static void addItems(int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("addItems", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE"); // Get message  
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void readGlobalChat()
        {
            MySqlCommand cmd = new MySqlCommand("viewGlobalChat", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                    if (Message != "noChatText")
                    {
                        string chatdatetime = myReader.GetString("ChatDateTime");
                        string playerusername = myReader.GetString("PlayerUsername");
                        string chattext = myReader.GetString("ChatText");
                        Main.ChatList.Add(new Chat() { ChatDateTime = chatdatetime, PlayerUsername = playerusername, ChatText = chattext });
                    }
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void globalChat(string pchatmessage, string pusername)
        {
            MySqlCommand cmd = new MySqlCommand("globalChat", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pChatMessage", pchatmessage); // Add a parameter
            cmd.Parameters.AddWithValue("pUserName", pusername); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
/*            try
            {
                while (myReader.Read())
                {

                }
            }
            finally
            {*/
                myReader.Close();
                connect.Close();
           // }
        }

        public static void playerBackpack(string pusername, int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("playerBackpack", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                    Main.M.CharacterScore = myReader.GetString("CharacterScore");
                    Main.M.BackpackList.Add(myReader.GetString("ItemName"));
                    Main.M.BackpackList.Add(myReader.GetString("ItemCount"));
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        // PLAYER PROPERTIES

        public static void changeEmail(string pusername, string pemail)
        {
            MySqlCommand cmd = new MySqlCommand("changeEmail", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pEmail", pemail); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void changePassword(string pusername, string ppassword)
        {
            MySqlCommand cmd = new MySqlCommand("changePassword", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pPassword", ppassword); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void changeUsername(string pusername, string pnewusername)
        {
            MySqlCommand cmd = new MySqlCommand("changeUsername", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pNewUsername", pnewusername); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        // ADMIN PROPERTIES

        public static void adminLockPlayer(string pusername, bool plocked)
        {
            MySqlCommand cmd = new MySqlCommand("lockPlayer", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pLocked", plocked); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void adminDeletePlayer(string pusername)
        {
            MySqlCommand cmd = new MySqlCommand("deletePlayer", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void clearGlobalChat()
        {
            MySqlCommand cmd = new MySqlCommand("clearGlobalChat", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void adminCloseGame(int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("adminCloseGame", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                  //  gameStatus = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void adminSetAdmin(string pusername, bool pisadmin)
        {
            MySqlCommand cmd = new MySqlCommand("adminSetAdmin", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pIsAdmin", pisadmin); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void listOfPlayers()
        {
            MySqlCommand cmd = new MySqlCommand("listOfPlayers", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    string name = myReader.GetString("PlayerUsername");
                    Leaderboard.PlayerList.Add(new Leaderboard() { Player = name });
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void checkCharacter(string pusername, int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("checkCharacter", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                    Main.M.CharacterName = myReader.GetString("CNAME");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }
        public static void getColour(string pusername, int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("getColour", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("CharacterColour");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void getAllCharacterPositions(string pusername, int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("getCharacters", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    string name = myReader.GetString("CharacterName");
                    string colour = myReader.GetString("CharacterColour");
                    int id = Int32.Parse(myReader.GetString("CharacterID"));
                    int? tile = null;

                    if (!myReader.IsDBNull(myReader.GetOrdinal("TileID")))
                    {
                        tile = Int32.Parse(myReader.GetString("TileID"));
                    }                 

                    Main.CharacterList.Add(new Characters() { Name = name, Colour = colour, TileID = tile, ID = id });
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }
        public static void checkAdmin(string pusername)
        {
            MySqlCommand cmd = new MySqlCommand("checkAdmin", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Message = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void getGameItems(int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("getGameItems", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    int x = myReader.GetInt32("VAL");
                    if (x != 0)
                    {
                        string b = myReader.GetString("NME");
                        string c = myReader.GetString("PIC");
                        int tile = Int32.Parse(myReader.GetString("ID"));
                        Main.ItemList.Add(new Items() { TileID = tile, Name = b, Photo = c });
                    }
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void getCharacterScore(string pusername, int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("getCharacterScore", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    int x = Int32.Parse(myReader.GetString("CharacterScore"));
                    Message = x.ToString(); 
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }
        public static void checkGameExists(int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("checkGameExists", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    gameStatus = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void getPlayerInfo(string pusername)
        {
            MySqlCommand cmd = new MySqlCommand("getPlayerInfo", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    Main.M.GetPPassword = myReader.GetString("PlayerPassword");
                    Main.M.GetPEmail = myReader.GetString("PlayerEmail");
                    Main.M.GetPLocked = myReader.GetString("Locked");
                    Main.M.GetPHighscore = myReader.GetString("Highscore");
                    Main.M.GetPIsAdmin = myReader.GetString("IsAdmin");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void updatePlayerInfo(string pusername, string nusername, string npassword, string nemail, int nhighscore, bool nisadmin, bool nlocked)
        {
            MySqlCommand cmd = new MySqlCommand("updatePlayerInfo", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pUsername", pusername); // Add a parameter
            cmd.Parameters.AddWithValue("nUsername", nusername); // Add a parameter
            cmd.Parameters.AddWithValue("nPassword", npassword); // Add a parameter
            cmd.Parameters.AddWithValue("nEmail", nemail); // Add a parameter
            cmd.Parameters.AddWithValue("nHighscore", nhighscore); // Add a parameter
            cmd.Parameters.AddWithValue("nIsAdmin", nisadmin); // Add a parameter
            cmd.Parameters.AddWithValue("nLocked", nlocked); // Add a parameter
            connect.Open();
            cmd.ExecuteNonQuery();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }
    }
}