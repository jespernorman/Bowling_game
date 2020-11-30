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

            var actual = round.Roll(pins: 3, Pins: 2);

            Assert.AreEqual(5, actual);
        }
    }
}