using System.Collections.Generic;

namespace amazingAdventures
{
    public class Main
    {
        private static readonly Main _instance = new Main();
        public static Main M => _instance;
        static Main() { }

        private string getPPassword;
        private string getPEmail;
        private string getPLocked;
        private string getPHighscore;
        private string getPIsAdmin;

        private int gameNumber;
        private string username;
        private string message;
        private string characterName;
        private string characterScore;
        private string leaderboardGame;

        public string GetPPassword { get => getPPassword; set => getPPassword = value; }
        public string GetPEmail { get => getPEmail; set => getPEmail = value; }
        public string GetPLocked { get => getPLocked; set => getPLocked = value; }
        public string GetPHighscore { get => getPHighscore; set => getPHighscore = value; }
        public string GetPIsAdmin { get => getPIsAdmin; set => getPIsAdmin = value; }

        private List<int> _gameListID = new List<int>();
        private List<string> _gameListName = new List<string>();
        private static List<Main> _chatList = new List<Main>();
        private static List<Main> _characterList = new List<Main>();
        private static List<Main> _itemList = new List<Main>();

        public int GameNumber { get => gameNumber; set => gameNumber = value; }
        public string Username { get => username; set => username = value; }
        public string Message { get => message; set => message = value; }
        public string CharacterName { get => characterName; set => characterName = value; }
        public string CharacterScore { get => characterScore; set => characterScore = value; }
        public string LeaderboardGame { get => leaderboardGame; set => leaderboardGame = value; }

        public List<int> GameListID { get => _gameListID; set => _gameListID = value; }
        public List<string> GameListName { get => _gameListName; set => _gameListName = value; }
        public static List<Main> ChatList { get => _chatList; set => _chatList = value; }
        public static List<Main> CharacterList { get => _characterList; set => _characterList = value; }
        public static List<Main> ItemList { get => _itemList; set => _itemList = value; }

    }
}
