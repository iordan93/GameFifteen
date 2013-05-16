using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameFifteen;

namespace GameFifteen.Test
{
    [TestClass]
    public class GameBoardTest
    {
        /// <summary>
        ///A test for IsSolvable - WithUnsolvableField 1 test.
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithUnsolvableField1Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = {{ "1", "2", "3", "4" },
                                            { "5", "6", "7", "8" },
                                            { "9", "10", "11", "12" },
                                            { "13", "15", "14", " " }}; ;
            bool expected = false;
            bool actual = target.IsSolvable(gameField);
            Assert.IsFalse(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithUnsolvableField test.
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithUnsolvableField2Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { "13", "10", "11", "6" },
                                            { "5", "7", "4", "8" },
                                            { "1", "12", "14", "9" },
                                            { "3", "15", "2", " " } };
            bool expected = false;
            bool actual = target.IsSolvable(gameField);
            Assert.IsFalse(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField test.
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableFieldTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField =  { { "1", "2", "3", "4" },
                                          { "5", "6", "7", "8" },
                                          { "9", "10", "11", "12" },
                                          { "13", "14", " ", "15" } };
            bool expected = false;
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 1 test - 17 positions which need 80 moves
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField1Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField =  { { " ", "12", "9", "13" },
                                          { "15", "11", "10", "14" },
                                          { "3", "7", "2", "5" },
                                          { "4", "8", "6", "1" } };
            bool expected = false;
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 2 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField2Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField =  { { " ", "12", "10", "13" },
                                          { "15", "11", "14", "9" },
                                          { "3", "7", "6", "2" },
                                          { "4", "8", "5", "1" } };
            bool expected = false;
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 3 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField3Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { " ", "12", "9", "13" },
                                  { "15", "11", "10", "14" },
                                  { "7", "8", "6", "2" },
                                  { "4", "3", "5", "1" } };
            bool expected = false;
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 4 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField4Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { " ", "12", "10", "13" },
                                          { "15", "11", "14", "9" },
                                          { "3", "7", "2", "5" },
                                          { "4", "8", "6", "1" } };
            bool expected = false;
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 5 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField5Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { " ", "12", "11", "13" },
                                          { "15", "14", "10", "9" },
                                          { "3", "7", "6", "2" },
                                          { "4", "8", "5", "1" } };
            bool expected = false;
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        //[TestMethod]
        //public void IsSolvable_WithSolvableField6()
        //{
        //    string[,] solvableGameField = { { " ", "12", "10", "13" },
        //                                  { "15", "11", "14", "9" },
        //                                  { "7", "8", "6", "2" },
        //                                  { "4", "3", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField7()
        //{
        //    string[,] solvableGameField = { { " ", "11", "9", "13" },
        //                                  { "12", "15", "10", "14" },
        //                                  { "3", "7", "6", "2" },
        //                                  { "4", "8", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField8()
        //{
        //    string[,] solvableGameField = { { " ", "12", "10", "13" },
        //                                  { "15", "11", "9", "14" },
        //                                  { "7", "3", "6", "2" },
        //                                  { "4", "8", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField9()
        //{
        //    string[,] solvableGameField = { { " ", "12", "9", "13" },
        //                                  { "15", "8", "10", "14" },
        //                                  { "11", "7", "6", "2" },
        //                                  { "4", "3", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField10()
        //{
        //    string[,] solvableGameField = { { " ", "15", "9", "13" },
        //                                  { "11", "12", "10", "14" },
        //                                  { "3", "7", "6", "2" },
        //                                  { "4", "8", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField11()
        //{
        //    string[,] solvableGameField = { { " ", "12", "9", "13" },
        //                                  { "15", "11", "14", "10" },
        //                                  { "3", "8", "6", "2" },
        //                                  { "4", "7", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField12()
        //{
        //    string[,] solvableGameField = { { " ", "12", "9", "13" },
        //                                  { "15", "11", "10", "14" },
        //                                  { "3", "7", "5", "6" },
        //                                  { "4", "8", "2", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField13()
        //{
        //    string[,] solvableGameField = { { " ", "12", "9", "13" },
        //                                  { "15", "11", "10", "14" },
        //                                  { "3", "7", "6", "2" },
        //                                  { "4", "8", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField14()
        //{
        //    string[,] solvableGameField = { { " ", "12", "9", "13" },
        //                                  { "15", "11", "10", "14" },
        //                                  { "8", "3", "6", "2" },
        //                                  { "4", "7", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField15()
        //{
        //    string[,] solvableGameField = { { " ", "12", "9", "13" },
        //                                  { "15", "11", "10", "14" },
        //                                  { "7", "8", "5", "6" },
        //                                  { "4", "3", "2", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField16()
        //{
        //    string[,] solvableGameField = { { " ", "12", "14", "13" },
        //                                  { "15", "11", "9", "10" },
        //                                  { "3", "7", "6", "2" },
        //                                  { "4", "8", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}
        //[TestMethod]
        //public void IsSolvable_WithSolvableField17()
        //{
        //    string[,] solvableGameField = { { " ", "12", "14", "13" },
        //                                  { "15", "11", "9", "10" },
        //                                  { "8", "3", "6", "2" },
        //                                  { "4", "7", "5", "1" } };

        //    Assert.IsTrue(GameFifteen.IsSolvable(solvableGameField));
        //}

        /// <summary>
        ///A test for GameBoard Constructor
        ///</summary>
        [TestMethod()]
        public void GameBoardConstructorTest()
        {
            int gameBoardSize = 0; // TODO: Initialize to an appropriate value
            GameBoard target = new GameBoard(gameBoardSize);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GenerateField
        ///</summary>
        [TestMethod()]
        public void GenerateFieldTest()
        {
            int gameBoardSize = 0; // TODO: Initialize to an appropriate value
            GameBoard target = new GameBoard(gameBoardSize); // TODO: Initialize to an appropriate value
            target.GenerateField();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for IsSolved
        ///</summary>
        [TestMethod()]
        public void IsSolvedTest()
        {
            int gameBoardSize = 0; // TODO: Initialize to an appropriate value
            GameBoard target = new GameBoard(gameBoardSize); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsSolved();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            int gameBoardSize = 0; // TODO: Initialize to an appropriate value
            GameBoard target = new GameBoard(gameBoardSize); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Board
        ///</summary>
        [TestMethod()]
        public void BoardTest()
        {
            int gameBoardSize = 0; // TODO: Initialize to an appropriate value
            GameBoard target = new GameBoard(gameBoardSize); // TODO: Initialize to an appropriate value
            string[,] expected = null; // TODO: Initialize to an appropriate value
            string[,] actual;
            target.Board = expected;
            actual = target.Board;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            int gameBoardSize = 0; // TODO: Initialize to an appropriate value
            GameBoard target = new GameBoard(gameBoardSize); // TODO: Initialize to an appropriate value
            int indexRow = 0; // TODO: Initialize to an appropriate value
            int indexColumn = 0; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target[indexRow, indexColumn] = expected;
            actual = target[indexRow, indexColumn];
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsSolvable
        ///</summary>
        [TestMethod()]
        public void IsSolvableTest()
        {
            int gameBoardSize = 0; // TODO: Initialize to an appropriate value
            GameBoard target = new GameBoard(gameBoardSize); // TODO: Initialize to an appropriate value
            string[,] gameField = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsSolvable(gameField);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
