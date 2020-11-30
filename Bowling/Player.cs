using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Player
    {
        public List<Round> rounds = new List<Round>();

        public Player()
        {
        }
        public void PlayRound(string playerName, int pins, int Pins, bool strike, bool spare)
        {
            var round = new Round();
            round.Roll(pins, Pins);

            if (spare)
                round.Spare = spare;

            if (strike)
                round.Strike = strike;

            rounds.Add(round);
        }
    }
}