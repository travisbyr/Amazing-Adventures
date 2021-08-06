using System.Collections.Generic;

namespace amazingAdventures
{
    public class Leaderboard : Main
    {
        private static List<Leaderboard> _leaderboardList = new List<Leaderboard>();
        private static List<Leaderboard> _playerList = new List<Leaderboard>();
        private static List<Leaderboard> _gameCharacterList = new List<Leaderboard>();

        public string Player { get; set; }
        public int Highscore{ get; set; }
        public string Character { get; set; }
        public int Score { get; set; }

        public static List<Leaderboard> LeaderboardList { get => _leaderboardList; set => _leaderboardList = value; }
        public static List<Leaderboard> PlayerList { get => _playerList; set => _playerList = value; }
        public static List<Leaderboard> GameCharacterList { get => _gameCharacterList; set => _gameCharacterList = value; }
    }
}
