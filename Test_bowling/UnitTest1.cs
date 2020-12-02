using NUnit.Framework;

namespace Test_bowling
{
    public class Tests
    {
        [Test]
        public void Round_AddRollTest()
        {
            var round = new Bowling.Round(roundId: 1);

            var actual = round.Roll(pins1: 3, pins2: 2);

            Assert.AreEqual(5, actual);
        }

        [Test]
        public void Round_AddSpare()
        {
            var round = new Bowling.Round(roundId: 1);

            round.Roll(pins1: 8, pins2: 2);

            Assert.IsTrue(round.Spare);
        }

        [Test]
        public void Round_AddStrike()
        {
            var round = new Bowling.Round(roundId: 1);

            round.Roll(pins1: 10, pins2: 0);

            Assert.IsTrue(round.Strike);
        }

        [Test]
        public void Round_AddBonus()
        {
            var round = new Bowling.Round(roundId: 1);

            var originalScore = round.ScoreStore;
            var originalBonus = round.BonusPoint;

            round.AddBonus(10);

            if(round.ScoreStore > originalScore && round.BonusPoint > originalBonus)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        public void Round_GetScore()
        {
            var round = new Bowling.Round(roundId: 1);
            var pins1 = 5;
            var pins2 = 1;

            var actual = round.Roll(pins1, pins2);

            if (actual == round.GetScore())
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