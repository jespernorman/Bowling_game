using System;

namespace bowling_game
{
    public class Round
    {
        public ArrayList Throws[];

        public int roll(int firstRoll, int secondRoll)
        {
            int firstRoll = Console.ReadLine();

            int secondRoll = Console.ReadLine();
            int score = firstRoll + secondRoll;

            throws.Add(firstRoll);
            throws.Add(secondRoll);
            throws.Add(score);
            return score;         
        }

    }
}
