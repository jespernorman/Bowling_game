using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class Round
    {
        public int ScoreStore { get; set; }
        private const int MaxPinsValue = 10;

        public Round()
        { 

        }

        public int SaveFrame(int pins1, int pins2)
        {
            ScoreStore += pins1 + pins2;
            return ScoreStore;
        }

        public void SaveRound(List<Frame> listOfFrames)
        {
            foreach (var currentFrame in listOfFrames)
            {
                if (currentFrame.FrameId == 1)
                {
                    SaveFrame(currentFrame.Pins1, currentFrame.Pins2);
                }
                else
                {
                    if (CheckForBonus(currentFrame.FrameId, listOfFrames))
                    {
                        var bonusPoint = 0;
                        var previousFrame = listOfFrames.FirstOrDefault(x => x.FrameId == currentFrame.FrameId - 1);
                        if (previousFrame.Strike)
                        {
                            bonusPoint = MaxPinsValue;
                        }
                        else if (previousFrame.Spare)
                        {
                            bonusPoint = currentFrame.Pins1 + currentFrame.Pins2;
                        }
                        ScoreStore += bonusPoint;
                    }
                    else
                    {
                        SaveFrame(currentFrame.Pins1, currentFrame.Pins2); ;
                    }
                }
            }
        }

        public int GetScore ()
        {
            return ScoreStore;
        }

        private bool CheckForBonus(int currentFrameId, List<Frame> listofFrames)
        {
            return listofFrames.Any(frame => frame.FrameId == currentFrameId - 1 && frame.Spare == true || frame.Strike == true);
        }
    }
}