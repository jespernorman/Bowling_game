using NUnit.Framework;

namespace Test_bowling
{
    public class Tests
    {
        [Test]
        public void RollTest()
        {
            var round = new Bowling.Round(roundId: 1);

            var actual = round.Roll(pins1: 3, pins2: 2);

            Assert.AreEqual(5, actual);
        }

        [Test]
        public void SpareTest()
        {
            var round = new Bowling.Round(roundId: 1);

            var actual = round.Roll(pins1: 8, pins2: 2);

            Assert.IsTrue(round.Spare);
        }

        [Test]
        public void StrikeTest()
        {
            var round = new Bowling.Round(roundId: 1);

            var actual = round.Roll(pins1: 10, pins2: 0);

            Assert.IsTrue(round.Strike);
        }

        [Test]
        public void AddBonus()
        {
            var round = new Bowling.Round(roundId: 1);

            var originalScore = round.ScoreStore;
            var bonus = round.BonusPoint;

            round.AddBonus(10);
            if(round.ScoreStore < originalScore && bonus < originalScore)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}