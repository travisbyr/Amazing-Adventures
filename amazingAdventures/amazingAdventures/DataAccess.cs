using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace amazingAdventures
{
    public class DataAccess
    {
        // PUBLIC VARIABLES

        public static string message = "";
        public static string characterScore = "";
        public static string leaderboardGame = "";

        // PUBLIC LISTS

        public static List<string> gameListName = new List<string>();
        public static List<int> gameListID = new List<int>();
        public static List<string> leaderboardList = new List<string>();
        public static List<string> chatGlobal = new List<string>();
        public static List<string> backpackList = new List<string>();
        public static List<string> playerList = new List<string>();

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
                    message = myReader.GetString("MESSAGE"); // Get message
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
                    message = myReader.GetString("MESSAGE"); // Get message
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
                    message = myReader.GetString("MESSAGE"); // Get message
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
                    message = myReader.GetString("MESSAGE"); // Get message
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
                    message = myReader.GetString("MESSAGE"); // Get message
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
                    message = myReader.GetString("MESSAGE"); // Get message
                    gameListName.Add(myReader.GetString("GameName"));
                    gameListID.Add(Int32.Parse(myReader.GetString("GameID")));
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
                    message = myReader.GetString("MESSAGE"); // Get message
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
                    message = myReader.GetString("MESSAGE"); // Get message
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
                    message = myReader.GetString("cTile"); // Get message
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
                    message = myReader.GetString("MESSAGE"); // Get message
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
                    message = myReader.GetString("MESSAGE"); // Get message 
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
                    message = myReader.GetString("MESSAGE"); // Get message 
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void viewLeaderboard(int pgamenumber)
        {
            MySqlCommand cmd = new MySqlCommand("viewLeaderboard", connect); // Select stored proecdure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("pGameNumber", pgamenumber); // Add a parameter
            connect.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            try
            {
                while (myReader.Read())
                {
                    leaderboardGame = myReader.GetString("GameName");
                    leaderboardList.Add(myReader.GetString("CharacterName"));
                    leaderboardList.Add(myReader.GetString("CharacterScore"));
                    message = myReader.GetString("MESSAGE"); // Get message  
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
                    message = myReader.GetString("MESSAGE"); // Get message  
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
            try
            {
                while (myReader.Read())
                {
                    message = myReader.GetString("MESSAGE");
                    chatGlobal.Add(myReader.GetString("ChatDateTime"));
                    chatGlobal.Add(myReader.GetString("PlayerUsername"));
                    chatGlobal.Add(myReader.GetString("ChatText"));
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
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
                    message = myReader.GetString("MESSAGE");
                    characterScore = myReader.GetString("CharacterScore");
                    backpackList.Add(myReader.GetString("ItemName"));
                    backpackList.Add(myReader.GetString("ItemCount"));
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
                    message = myReader.GetString("MESSAGE");
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
                    message = myReader.GetString("MESSAGE");
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
                    message = myReader.GetString("MESSAGE");
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
                    message = myReader.GetString("MESSAGE");
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
                    message = myReader.GetString("MESSAGE");
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
                    message = myReader.GetString("MESSAGE");
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
                    message = myReader.GetString("MESSAGE");
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
                    message = myReader.GetString("MESSAGE");
                }
            }
            finally
            {
                myReader.Close();
                connect.Close();
            }
        }

        public static void showPlayerList()
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
                    playerList.Add(myReader.GetString("PlayerUsername"));
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
                    message = myReader.GetString("MESSAGE");
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