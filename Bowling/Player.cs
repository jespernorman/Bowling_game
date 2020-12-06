using System.Collections.Generic;

namespace Bowling
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int PlayerId { get; set; }
        public List<Frame> ListOfFrames = new List<Frame>();

        public Player(string playerName, int playerId)
        {
            PlayerName = playerName;
            PlayerId = playerId;
        }

        public void StoreRound()
        {
            var round = new Round();
            round.SaveRound(ListOfFrames);
        }
    }
}