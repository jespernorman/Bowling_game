using System;

namespace BowlingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! Hur många spelare är ni?");
            int amountOfPlayers = Console.ReadLine();

            for(int i = 0; amountOfPlayers <= 4; i++)
            {
                Players.RegisterPlayer();
            }

        }
    }
}
