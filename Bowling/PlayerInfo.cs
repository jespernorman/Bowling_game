using System;
namespace Bowling
{
    public class PlayerInfo
    {
        public string CurrentPlayer { get; set; }
        public int CurrentPlayerId { get; set; }
        public int CurrentRound { get; set; }
        public bool GameFinished { get; set; }
    }
}
