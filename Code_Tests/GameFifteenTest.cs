using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameFifteen;

namespace GameFifteen.Test
{
    [TestClass]
    public class GameFifteenTest
    {
        [TestMethod]
        public void IsSolvable_WithUnsolvableField1()
        {
            string[,] unsolvableGameField = {{ "1", "2", "3", "4" },
                                            { "5", "6", "7", "8" },
                                            { "9", "10", "11", "12" },
                                            { "13", "15", "14", " " }};

            Assert.IsFalse(GameFifteen.IsSolvable(unsolvableGameField));
        }

        [TestMethod]
        public void IsSolvable_WithUnsolvableField2()
        {
            string[,] unsolvableGameField = { { "13", "10", "11", "6" },
                                            { "5", "7", "4", "8" },
                                            { "1", "12", "14", "9" },
                                            { "3", "15", "2", " " } };

            Assert.IsFalse(GameFifteen.IsSolvable(unsolvableGameField));
        }

        [TestMethod]
        public void IsSolvable_WithSolvableField()
        {
            string[,] solvableGameField = { { "1", "2", "3", "4" },
                                          { "5", "6", "7", "8" },
                                          { "9", "10", "11", "12" },
                                          { "13", "14", " ", "15" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }

        // 17 positions which need 80 moves
        [TestMethod]
        public void IsSolvable_WithSolvableField1()
        {
            string[,] solvableGameField = { { " ", "12", "9", "13" },
                                          { "15", "11", "10", "14" },
                                          { "3", "7", "2", "5" },
                                          { "4", "8", "6", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField2()
        {
            string[,] solvableGameField = { { " ", "12", "10", "13" },
                                          { "15", "11", "14", "9" },
                                          { "3", "7", "6", "2" },
                                          { "4", "8", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField3()
        {
            string[,] solvableGameField = { { " ", "12", "9", "13" },
                                          { "15", "11", "10", "14" },
                                          { "7", "8", "6", "2" },
                                          { "4", "3", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField4()
        {
            string[,] solvableGameField = { { " ", "12", "10", "13" },
                                          { "15", "11", "14", "9" },
                                          { "3", "7", "2", "5" },
                                          { "4", "8", "6", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField5()
        {
            string[,] solvableGameField = { { " ", "12", "11", "13" },
                                          { "15", "14", "10", "9" },
                                          { "3", "7", "6", "2" },
                                          { "4", "8", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField6()
        {
            string[,] solvableGameField = { { " ", "12", "10", "13" },
                                          { "15", "11", "14", "9" },
                                          { "7", "8", "6", "2" },
                                          { "4", "3", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField7()
        {
            string[,] solvableGameField = { { " ", "11", "9", "13" },
                                          { "12", "15", "10", "14" },
                                          { "3", "7", "6", "2" },
                                          { "4", "8", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField8()
        {
            string[,] solvableGameField = { { " ", "12", "10", "13" },
                                          { "15", "11", "9", "14" },
                                          { "7", "3", "6", "2" },
                                          { "4", "8", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField9()
        {
            string[,] solvableGameField = { { " ", "12", "9", "13" },
                                          { "15", "8", "10", "14" },
                                          { "11", "7", "6", "2" },
                                          { "4", "3", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField10()
        {
            string[,] solvableGameField = { { " ", "15", "9", "13" },
                                          { "11", "12", "10", "14" },
                                          { "3", "7", "6", "2" },
                                          { "4", "8", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField11()
        {
            string[,] solvableGameField = { { " ", "12", "9", "13" },
                                          { "15", "11", "14", "10" },
                                          { "3", "8", "6", "2" },
                                          { "4", "7", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField12()
        {
            string[,] solvableGameField = { { " ", "12", "9", "13" },
                                          { "15", "11", "10", "14" },
                                          { "3", "7", "5", "6" },
                                          { "4", "8", "2", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField13()
        {
            string[,] solvableGameField = { { " ", "12", "9", "13" },
                                          { "15", "11", "10", "14" },
                                          { "3", "7", "6", "2" },
                                          { "4", "8", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField14()
        {
            string[,] solvableGameField = { { " ", "12", "9", "13" },
                                          { "15", "11", "10", "14" },
                                          { "8", "3", "6", "2" },
                                          { "4", "7", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField15()
        {
            string[,] solvableGameField = { { " ", "12", "9", "13" },
                                          { "15", "11", "10", "14" },
                                          { "7", "8", "5", "6" },
                                          { "4", "3", "2", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField16()
        {
            string[,] solvableGameField = { { " ", "12", "14", "13" },
                                          { "15", "11", "9", "10" },
                                          { "3", "7", "6", "2" },
                                          { "4", "8", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
        [TestMethod]
        public void IsSolvable_WithSolvableField17()
        {
            string[,] solvableGameField = { { " ", "12", "14", "13" },
                                          { "15", "11", "9", "10" },
                                          { "8", "3", "6", "2" },
                                          { "4", "7", "5", "1" } };

            Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        }
    }
}
