using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameFifteen.Test
{
    [TestClass]
    public class HighscoresTest
    {
        private Highscores highscores = new Highscores();

        [TestMethod]
        public void TestEmptyHighscores()
        {
            string assertedResult = "There are no highscores!\n";
            string result = highscores.ToString();

            Assert.AreEqual(assertedResult, result);
        }

        [TestMethod]
        public void AddTest1()
        {
            Score score = new Score(5, "john");
            highscores.Add(score);

            string result = highscores.ToString();

            StringBuilder assertedResult = new StringBuilder();
            assertedResult.AppendLine("Scoreboard:");
            assertedResult.AppendLine("1. john --> 5 moves");

            Assert.AreEqual(assertedResult.ToString(), result);
        }

        [TestMethod]
        public void AddTest1_1()
        {
            Score score = new Score(5, "john");
            highscores.Add(score);

            Assert.AreEqual(1, highscores.Scores.Count);
        }

        [TestMethod]
        public void AddTest2()
        {
            highscores.Add(new Score(5, "john"));
            highscores.Add(new Score(4, "johnny"));

            StringBuilder assertedResult = new StringBuilder();
            assertedResult.AppendLine("Scoreboard:");
            assertedResult.AppendLine("1. johnny --> 4 moves");
            assertedResult.AppendLine("2. john --> 5 moves");

            string result = highscores.ToString();

            Assert.AreEqual(assertedResult.ToString(), result);
        }

        [TestMethod]
        public void AddTest2_1()
        {
            highscores.Add(new Score(5, "john"));
            highscores.Add(new Score(4, "johnny"));

            int count = highscores.Scores.Count;

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void AddTest3()
        {
            highscores.Add(new Score(5, "john"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(1, "teddy"));
            highscores.Add(new Score(8, "tom"));
            highscores.Add(new Score(3, "peter"));

            string result = highscores.ToString();

            StringBuilder assertedResult = new StringBuilder();
            assertedResult.AppendLine("Scoreboard:");
            assertedResult.AppendLine("1. teddy --> 1 move");
            assertedResult.AppendLine("2. peter --> 3 moves");
            assertedResult.AppendLine("3. johnny --> 4 moves");
            assertedResult.AppendLine("4. johnny --> 4 moves");
            assertedResult.AppendLine("5. john --> 5 moves");

            Assert.AreEqual(assertedResult.ToString(), result);
        }

        [TestMethod]
        public void AddTest3_1()
        {
            highscores.Add(new Score(5, "john"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(1, "teddy"));
            highscores.Add(new Score(8, "tom"));
            highscores.Add(new Score(3, "peter"));

            Assert.AreEqual(5, highscores.Scores.Count);
        }

        [TestMethod]
        public void AddTest4()
        {
            highscores.Add(new Score(5, "john"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(1, "teddy"));
            highscores.Add(new Score(8, "tom"));
            highscores.Add(new Score(3, "peter"));
            highscores.Add(new Score(10, "paul"));

            string result = highscores.ToString();

            StringBuilder assertedResult = new StringBuilder();
            assertedResult.AppendLine("Scoreboard:");
            assertedResult.AppendLine("1. teddy --> 1 move");
            assertedResult.AppendLine("2. peter --> 3 moves");
            assertedResult.AppendLine("3. johnny --> 4 moves");
            assertedResult.AppendLine("4. johnny --> 4 moves");
            assertedResult.AppendLine("5. john --> 5 moves");

            Assert.AreEqual(assertedResult.ToString(), result);
        }

        [TestMethod]
        public void AddTest4_1()
        {
            highscores.Add(new Score(5, "john"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(1, "teddy"));
            highscores.Add(new Score(8, "tom"));
            highscores.Add(new Score(3, "peter"));
            highscores.Add(new Score(10, "paul"));

            int count = highscores.Scores.Count;

            Assert.AreEqual(5, count);
        }

        [TestMethod]
        public void IsHighscoreTest1()
        {
            Assert.IsTrue(highscores.IsHighscore(100));
        }

        [TestMethod]
        public void IsHighscoreTest2()
        {
            highscores.Add(new Score(5, "john"));
            Assert.IsTrue(highscores.IsHighscore(100));
        }

        [TestMethod]
        public void IsHighscoreTest3()
        {
            highscores.Add(new Score(5, "john"));
            Assert.IsTrue(highscores.IsHighscore(1));
        }

        [TestMethod]
        public void IsHighscoreTest4()
        {
            highscores.Add(new Score(5, "john"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(1, "teddy"));
            highscores.Add(new Score(8, "tom"));

            Assert.IsFalse(highscores.IsHighscore(100));
        }

        [TestMethod]
        public void IsHighscoreTest5()
        {
            highscores.Add(new Score(5, "john"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(1, "teddy"));
            highscores.Add(new Score(8, "tom"));

            Assert.IsTrue(highscores.IsHighscore(5));
        }

        [TestMethod]
        public void IsHighscoreTest6()
        {
            highscores.Add(new Score(5, "john"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(4, "johnny"));
            highscores.Add(new Score(1, "teddy"));
            highscores.Add(new Score(8, "tom"));

            Assert.IsFalse(highscores.IsHighscore(8));
        }
    }
}