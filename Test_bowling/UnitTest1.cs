using NUnit.Framework;

namespace Test_bowling
{
    public class Tests
    {
        [Test]
        public void RollTest()
        {
            var round = new Bowling.Round(roundId:1);

            var actual = round.Roll(pins1: 3, pins2: 2);

            Assert.AreEqual(5, actual);
        }
        [Test]
        public void SpareTest()
        {
            var round = new Bowling.Round(roundId: 1);

            var actual = round.Roll(pins1: 8, pins2: 2);
            if(AddSpare(pins1: 5, pins2: 5, true)
            {

            }

            Assert.IsFalse(true);

        }
        [Test]
        public void StrikeTest()
        {
            var round = new Bowling.Round(roundId: 1);

            var actual = round.AddStrike(false);

            Assert.IsFalse(false);
        }
    }
}