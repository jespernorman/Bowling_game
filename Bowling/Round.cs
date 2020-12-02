using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Round
    {
        public int ScoreStore { get; set; }
        public bool Spare { get; set; }
        public bool Strike { get; set; }
        public int RoundId { get; set; }
        public int BonusPoint { get; set; }

        public Round(int roundId)
        {
            RoundId = roundId;
        }

        public int Roll(int pins1, int pins2)
        {
            var maxPinsValue = 10;

            if (pins1 == maxPinsValue)
            {
                Strike = true;
                maxPinsValue = 10;
                ScoreStore += maxPinsValue;
            }
            if (pins1 + pins2 == maxPinsValue)
            {
                Spare = true;
                ScoreStore += pins1 + pins2;
            }
            else
            {
                ScoreStore += pins1 + pins2;
            }

            return ScoreStore;
        }

        public int GetScore()
        {
            return ScoreStore;
        }

        public void AddBonus(int bonusPoint)
        {
            BonusPoint = bonusPoint;
            ScoreStore += bonusPoint;
        }
    }
}