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

        public int Roll(int pins1, int pins2)
        {
            var maxPinsValue = 10;

            if (maxPinsValue == pins1)
            {
                Strike = true;
                int strikePoint = 10;
                ScoreStore += strikePoint;
            }
            if (maxPinsValue == pins1 + pins2)
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

        //public void AddSpare(int pins1, int pins2, bool spare)
        //{
        //    int sumofpins = 10;
        //    if(sumofpins == pins1 + pins2)
        //    {                             
        //        Spare = true;
        //        ScoreStore += pins1 + pins2;
        //    }
        //}

        //public void AddStrike(bool strike, int pins1)
        //{
        //    int allpins = 10;
        //    if (allpins == pins1)
        //    {
        //        Strike = true;
        //        int strikePoint = 10;      
        //        ScoreStore += strikePoint;
        //    }
        //}

        public void AddBonus(int bonusPoint, string playerName, int playerId)
        {
            var player = new Player(playerName, playerId);
            bonusPoint = 0;
            ScoreStore += bonusPoint;
        }
    }
}