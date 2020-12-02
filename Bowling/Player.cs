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

        public void PlayRound(int roundId, int pins1, int pins2, bool strike, bool spare, int bonusPoint, string playerName, int playerId)
        {
            var round = new Round(roundId);

            if (spare == true)
            {
                round.AddSpare(pins1, pins2, spare);
            }
            else if (strike == true)
            {
                round.AddStrike(strike, pins1);
            }
            else
            {
                round.Roll(pins1, pins2);
            }

            if (CheckForBonus(roundId))
            {
                bonusPoint = 0;
                var previousRound = roundInfo.FirstOrDefault(round => round.RoundId == roundId - 1 && round.Spare == true || round.Strike == true);
                if (previousRound.Strike)
                {
                    bonusPoint = 10;
                }
                else
                {
                    bonusPoint = pins1 + pins2;
                }
                previousRound.AddBonus(bonusPoint, playerName, playerId);
            }
            roundInfo.Add(round);
        }
        public bool CheckForBonus(int currentRoundId)
        {
            return roundInfo.Any(round => round.RoundId == currentRoundId - 1 && round.Spare == true || round.Strike == true);
        }
    }
}