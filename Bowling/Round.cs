using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Round
    {
        private int ScoreStore { get; set; }
        public bool Spare { get; set; }
        public bool Strike { get; set; }

        public int Roll(int pins, int Pins)
        {
            ScoreStore += pins + Pins;
            return ScoreStore;
        }

        public int Score(int firstRoll, int secondRoll)
        {
            return ScoreStore;
        }
    }
}