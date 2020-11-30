using System;
namespace BowlingGame
{
    public class Players
    {
        public Players()
        {
        }
        public string RegisterPlayer()
        {
            Console.WriteLine("Skriv in namnet på spelaren");
            string playerName = Console.ReadLine();
        }
    }
}
