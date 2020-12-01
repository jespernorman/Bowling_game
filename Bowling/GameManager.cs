using System;
using System.Collections.Generic;
namespace Bowling
{
    public class GameManager
    {
        public GameManager()
        {

        }
        public int AmountOfPlayers { get; set; }
        public string PlayerName { get; set; }
        public int RoundScore { get; set; }
        public const int MaxRounds = 10;
        public int RoundId { get; set; }
        public List<Player> PlayerScorePerRound = new List<Player>();

        public void Manager()
        {
            var player = new Player();
        }
    }
}
