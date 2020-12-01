using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class Player
    {
        public string PlayerName { get; set; }
        public List<Round> rounds = new List<Round>();

        public Player()
        {

        }
        public void PlayRound(string playerName, int roundId, int pins1, int pins2, bool strike, bool spare)
        {
            var round = new Round();
            PlayerName = playerName;

            if (spare == true)
            {
                round.AddSpare(pins1, pins2, spare, roundId);
            }
            else if (strike == true)
            {
                round.AddStrike(strike, roundId);
            }
            else
            {
                round.Roll(pins1, pins2, roundId);
            }

            if (CheckForBonus(roundId))
            {
                var countBonus = 0;
                var previousRound = rounds.FirstOrDefault(round => round.RoundId == roundId - 1 && round.Spare == true || round.Strike == true);
                if (previousRound.Strike)
                {
                    countBonus = 10;
                }
                else
                {
                    countBonus = pins1 + pins2;
                }
                previousRound.AddBonus(countBonus);
            }
            rounds.Add(round);
        }
        public bool CheckForBonus(int currentRoundId)
        {
            return rounds.Any(round => round.RoundId == currentRoundId - 1 && round.Spare == true || round.Strike == true);
        }
    }
}