using System;

namespace bowling_game
{
    public class Round
    {
        public List<int> ListOfThrows = new List<int>();
        {
        }

        public int roll(int firstRoll, int secondRoll)
        {
            int firstRoll = Console.ReadLine();

            int secondRoll = Console.ReadLine();

            ListOfThrows.Add(firstRoll);
            ListOfThrows.Add(secondRoll);
        }

        public int Score(int firstRoll, int secondRoll)
        {
            int score = firstRoll + secondRoll;
            return score;
        }
    }
}
