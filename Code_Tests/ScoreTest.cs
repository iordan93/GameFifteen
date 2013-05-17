using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameFifteen.Test
{
    [TestClass]
    public class ScoreTest
    {
        [TestMethod]
        public void CompareTest1()
        {
            Score score1 = new Score(10, "Tom");
            Score score2 = new Score(5, "Tom");

            Assert.IsTrue(score1.CompareTo(score2) > 0);
        }

        [TestMethod]
        public void CompareTest2()
        {
            Score score1 = new Score(10, "Tom");
            Score score2 = new Score(10, "Tom");

            Assert.IsTrue(score1.CompareTo(score2) == 0);
        }

        [TestMethod]
        public void CompareTest3()
        {
            Score score1 = new Score(10, "Tom");
            Score score2 = new Score(15, "Tom");

            Assert.IsTrue(score1.CompareTo(score2) < 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeMovesExceptionTest()
        {
            Score score = new Score(-6, "Lucky Luke");
        }
    }
}
