namespace GameFifteen.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ScoreTest
    {
        [TestMethod]
        public void ScoreConstructorTest()
        {
            int moves = 3;
            string playerName = "Bob";
            Score target = new Score(moves, playerName);
            Assert.IsTrue((target != null) && (target.Moves == moves) && (target.PlayerName == playerName));
        }

        [TestMethod]
        public void ScoreMovesTest()
        {
            int moves = 3;
            string playerName = "Bob";
            Score target = new Score(moves, playerName);
            int expected = 5;
            int actual;
            target.Moves = expected;
            actual = target.Moves;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScorePlayerNameTest()
        {
            int moves = 3;
            string playerName = "Bob";
            Score target = new Score(moves, playerName);
            string expected = "Robert";
            string actual;
            target.PlayerName = expected;
            actual = target.PlayerName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScoreCompareTest1()
        {
            Score score1 = new Score(10, "Tom");
            Score score2 = new Score(5, "Tom");

            Assert.IsTrue(score1.CompareTo(score2) > 0);
        }

        [TestMethod]
        public void ScoreCompareTest2()
        {
            Score score1 = new Score(10, "Tom");
            Score score2 = new Score(10, "Tom");

            Assert.IsTrue(score1.CompareTo(score2) == 0);
        }

        [TestMethod]
        public void ScoreCompareTest3()
        {
            Score score1 = new Score(10, "Tom");
            Score score2 = new Score(15, "Tom");

            Assert.IsTrue(score1.CompareTo(score2) < 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Score_NegativeMovesExceptionTest()
        {
            Score score = new Score(-6, "Lucky Luke");
        }
    }
}
