using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class GameManager
    {
        public GameManager()
        {

        }
        public const int MaxFrames = 10;
        private const int MaxPinsValue = 10;

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
            playerInfo.CurrentFrame = 1;

            return playerInfo;
        }

        public PlayerInfo PlayGameFrame(int pins1, int pins2, PlayerInfo playerInfo)
        {
            var currentFrame = playerInfo.CurrentFrame;

            var choosenPlayer = ListOfPlayers.FirstOrDefault(player => player.PlayerName == playerInfo.CurrentPlayer && player.PlayerId == playerInfo.CurrentPlayerId);

            if (choosenPlayer != null)
            {
                var frame = new Frame();
                frame.FrameId = currentFrame;
                frame.Pins1 = pins1;
                frame.Pins2 = pins2;
                if (pins1 == MaxPinsValue)
                {
                    frame.Strike = true;
                }
                if (pins1 + pins2 == MaxPinsValue)
                {
                    frame.Spare = true;
                }

                choosenPlayer.ListOfFrames.Add(frame);
            }

            var nextPlayer = ListOfPlayers.FirstOrDefault(player => player.PlayerId == playerInfo.CurrentPlayerId + 1);
            var nextPlayerInfo = new PlayerInfo();

            if (nextPlayer == null && currentFrame < MaxFrames)
            {
                nextPlayer = ListOfPlayers.FirstOrDefault(player => player.PlayerId == 1);
                currentFrame++;
                nextPlayerInfo.CurrentPlayer = nextPlayer.PlayerName;
                nextPlayerInfo.CurrentPlayerId = nextPlayer.PlayerId;
                nextPlayerInfo.CurrentFrame = currentFrame;
            }
            else
            {
                //Round is finished now we need to store the data
                foreach (var player in ListOfPlayers)
                {
                    player.StoreRound();
                }

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
