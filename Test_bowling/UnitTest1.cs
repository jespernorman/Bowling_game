using NUnit.Framework;
using Bowling;

namespace Test_bowling
{
    public class Tests
    {
        [Test]
        public void Round1()
        {
            var round = new Round();

            var actual = round.Roll(pins1: 3, pins2: 2, roundId: 1);

            Assert.AreEqual(5, actual);
        }
    }
}