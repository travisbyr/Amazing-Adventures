using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingAdventures
{
    public class Leaderboard : Main
    {
        private static List<Leaderboard> _leaderboardList = new List<Leaderboard>();
        public string Player { get; set; }
        public int Highscore{ get; set; }

        public static List<Leaderboard> LeaderboardList { get => _leaderboardList; set => _leaderboardList = value; }
    }
}
