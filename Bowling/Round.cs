using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Round
    {
        private int ScoreStore { get; set; }
        public bool Spare { get; set; }
        public bool Strike { get; set; }
        public int RoundId { get; set; }
        public int BonusPoint { get; set; }

        public Round(int roundId)
        {
            RoundId = roundId;
        }

        public Round()
        {
        }

        public int Roll(int pins1, int pins2, int roundId)
        {
            RoundId = roundId;
            ScoreStore += pins1 + pins2;
            return ScoreStore;
        }

        public int GetScore()
        {
            return ScoreStore;
        }

        public void AddSpare(int pins1, int pins2, bool spare, int roundId)
        {
            RoundId = roundId;
            if(spare == true)
            {                                                    //nästa kasst bonus
                Spare = spare;
                ScoreStore += pins1 + pins2;
            }
        }

        public void AddStrike(bool strike, int roundId)
        {
            RoundId = roundId;
            if (strike == true)
            {
                Strike = strike;
                int strikePoint = 10;       //2 extra kasst som blir bonusen
                ScoreStore += strikePoint;
            }
        }

        public void AddBonus(int bonusPoint)
        {
            var player = new Player();
            bonusPoint = 0;
            ScoreStore += bonusPoint;
        }
    }
}