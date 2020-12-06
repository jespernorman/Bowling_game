using System.Collections.Generic;
using NUnit.Framework;

namespace Test_bowling
{
    public class Tests
    {
        [Test]
        public void Round_SaveFrame()
        {
            var round = new Bowling.Round();

            var actual = round.SaveFrame(pins1: 3, pins2: 2);

            Assert.AreEqual(5, actual);
        }

        [Test]
        public void Round_GetScore()
        {
            var round = new Bowling.Round();
            var pins1 = 5;
            var pins2 = 1;

            var actual = round.SaveFrame(pins1, pins2);

            Assert.AreEqual(actual, round.GetScore());
        }

        [Test]
        public void Round_TestFullRound()
        {
            var round = new Bowling.Round();

            var listOfFrames = new List<Bowling.Frame>();

            var frame = new Bowling.Frame
            {
                FrameId = 1,
                Pins1 = 1,
                Pins2 = 1
            };

            for (int i = 0; i < 10; i++)
            {
                listOfFrames.Add(frame);
                frame.FrameId++;
            }

            round.SaveRound(listOfFrames);

            var score = round.GetScore();

            Assert.AreEqual(20, score);
        }
    }
}