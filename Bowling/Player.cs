using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class Player
    {
        public string PlayerName { get; set; }
        public string PlayerId { get; set; }
        public List<Round> roundInfo = new List<Round>();

        public Player(string playerName, int playerId)
        {
            PlayerName = playerName;
            PlayerId = PlayerId;

        }

        public void PlayRound(int roundId, int pins1, int pins2, string playerName, int playerId)
        {
            var round = new Round(roundId);

            round.Roll(pins1, pins2);
           
            if (CheckForBonus(roundId))
            {
                var bonusPoint = 0;
                var previousRound = roundInfo.FirstOrDefault(round => round.RoundId == roundId - 1 && round.Spare == true || round.Strike == true);
                if (previousRound.Strike)
                {
                    bonusPoint = 10;
                }
                else
                {
                    bonusPoint = pins1 + pins2;
                }
                previousRound.AddBonus(bonusPoint);
            }
            roundInfo.Add(round);
        }
        public bool CheckForBonus(int currentRoundId)
        {
            return roundInfo.Any(round => round.RoundId == currentRoundId - 1 && round.Spare == true || round.Strike == true);
        }
    }
}