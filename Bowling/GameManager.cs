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
        public const int MaxRounds = 10;

        public List<Player> ListOfPlayers = new List<Player>();

        public PlayerInfo StartGame(string[] arrayOfPlayers)
        {
            var firstPlayer = "";

            for (int i = 0; i < arrayOfPlayers.Length; i++)
            {
                if (i == 0)
                {
                    firstPlayer = arrayOfPlayers[i];
                }

                var player = new Player(arrayOfPlayers[i], i + 1);
                ListOfPlayers.Add(player);
            }
            var playerInfo = new PlayerInfo();
            playerInfo.CurrentPlayer = firstPlayer;
            playerInfo.CurrentPlayerId = 1;
            playerInfo.CurrentRound = 1;

            return playerInfo;
        }

        public PlayerInfo PlayGameRound(int pins1, int pins2, PlayerInfo playerInfo)
        {
            var currentRound = playerInfo.CurrentRound;

            var chosenPlayer = ListOfPlayers.FirstOrDefault(player => player.PlayerName == playerInfo.CurrentPlayer && player.PlayerId == playerInfo.CurrentPlayerId);

            if (chosenPlayer != null)
            {
                chosenPlayer.PlayRound(roundId, pins1, pins2);
            }

            var nextPlayer = ListOfPlayers.FirstOrDefault(player => player.PlayerId == playerInfo.CurrentPlayerId + 1);
            var nextPlayerInfo = new PlayerInfo();

            if (nextPlayer == null && currentRound < MaxRounds)
            {
                nextPlayer = ListOfPlayers.FirstOrDefault(player => player.PlayerId == 1);
                currentRound++;
                nextPlayerInfo.CurrentPlayer = nextPlayer.PlayerName;
                nextPlayerInfo.CurrentPlayerId = nextPlayer.PlayerId;
                nextPlayerInfo.CurrentRound = currentRound;
            }
            else
            {
                playerInfo.GameFinished = true;
            }

            return nextPlayerInfo;
        }

        public List<Player> GetGamePlayerResult()
        {
            return ListOfPlayers;
        }
    }
}
