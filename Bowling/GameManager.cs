using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class GameManager
    {
        public GameManager()
        {

        }
        public int RoundScore { get; set; }
        public const int MaxRounds = 10;
        public int RoundId { get; set; }
        public List<Player> PlayerScorePerRound = new List<Player>();
        public List<Player> ListOfPlayers = new List<Player>();

        public PlayerInfo StartGame (string []arrayOfPlayers)
        {
            var firstPlayer = "";

            for (int i = 0; i < arrayOfPlayers.Length; i++)
            {             
                if(i==0)
                {
                    firstPlayer = arrayOfPlayers[i];
                }

                var player = new Player(arrayOfPlayers[i], i+1);
                ListOfPlayers.Add(player);
            }
            var playerInfo = new PlayerInfo();
            playerInfo.CurrentPlayer = firstPlayer;
            playerInfo.CurrentPlayerId = 1;
            playerInfo.CurrentRound = 1;

            return playerInfo;
        }

        public PlayerInfo PlayGameRound(int pins1, int pins2, PlayerInfo currentPlayerInfo)
        {
            var chosenPlayer = ListOfPlayers.FirstOrDefault(player => player.PlayerName == currentPlayerInfo.CurrentPlayer && player.PlayerId == currentPlayerInfo.CurrentPlayerId);

            if (chosenPlayer != null)
            {
                chosenPlayer.PlayRound(RoundId, pins1, pins2);
            }

            var nextPlayer = ListOfPlayers.FirstOrDefault(player => player.PlayerName == currentPlayerInfo.CurrentPlayer && player.PlayerId == currentPlayerInfo.CurrentPlayerId);

            if (nextPlayer != null)
            {
                nextPlayer.PlayRound(RoundId, pins1, pins2);
            }
            return nextPlayer;
        }

    }
}
