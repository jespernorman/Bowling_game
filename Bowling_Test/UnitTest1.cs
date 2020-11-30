using NUnit.Framework;
using Bowling;

namespace Bowling_Test
{
    public class Tests
    {
        [Test]
        public void Round1()
        {
            var round = new Round();

            var actual = round.Roll(pins: 3, Pins: 2, pins_Result: 5);

            Assert.AreEqual(5, actual);
        }
    }
}