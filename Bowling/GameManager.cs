using System;
using System.Collections.Generic;
namespace Bowling
{
    public class GameManager
    {
        public GameManager()
        {

        }
        public int AmountOfPlayers { get; set; }
        public string PlayerName { get; set; }
        public int RoundScore { get; set; }
        public const int MaxRounds = 10;
        public int RoundId { get; set; }
        public List<Player> PlayerScorePerRound = new List<Player>();
        public List<Player> ListOfPlayers = new List<Player>();

        public string StartGame(string playerName, int playerId)
        {
            var player = new Player(playerName, playerId);
            AmountOfPlayers = 0;
            for (int i = 0; i >= AmountOfPlayers; i++)
            {
                ListOfPlayers.Add(player);
            }
            return playerName;
        }
        public void PlayGameRound(int roundId, int pins1, int pins2, bool strike, bool spare, int bonusPoint, string playerName, int playerId)
        { 
            var player = new Player(playerName, playerId);

            for (int i = 0; i >= MaxRounds; i++)
            {
                if (ListOfPlayers.Contains(player))
                {
                    player.PlayRound(roundId, pins1, pins2, strike, spare, bonusPoint, playerName, playerId);
                }
            }
        }
    }
}
