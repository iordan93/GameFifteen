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
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 6 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField6Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField =  { { " ", "12", "10", "13" },
                                   { "15", "11", "14", "9" },
                                   { "7", "8", "6", "2" },
                                   { "4", "3", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 7 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField7Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { " ", "11", "9", "13" },
                                  { "12", "15", "10", "14" },
                                  { "3", "7", "6", "2" },
                                  { "4", "8", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 8 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField8Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { " ", "12", "10", "13" },
                                  { "15", "11", "9", "14" },
                                  { "7", "3", "6", "2" },
                                  { "4", "8", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 9 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField9Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { " ", "12", "9", "13" },
                                  { "15", "8", "10", "14" },
                                  { "11", "7", "6", "2" },
                                  { "4", "3", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 10 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField10Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField =  { { " ", "15", "9", "13" },
                                   { "11", "12", "10", "14" },
                                   { "3", "7", "6", "2" },
                                   { "4", "8", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 11 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField11Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField =  { { " ", "12", "9", "13" },
                                   { "15", "11", "14", "10" },
                                   { "3", "8", "6", "2" },
                                   { "4", "7", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 12 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField12Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { " ", "12", "9", "13" },
                                  { "15", "11", "10", "14" },
                                  { "3", "7", "5", "6" },
                                  { "4", "8", "2", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 13 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField13Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { " ", "12", "9", "13" },
                                  { "15", "11", "10", "14" },
                                  { "3", "7", "6", "2" },
                                  { "4", "8", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 14 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField14Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField = { { " ", "12", "9", "13" },
                                  { "15", "11", "10", "14" },
                                  { "8", "3", "6", "2" },
                                  { "4", "7", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 15 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField15Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField ={ { " ", "12", "9", "13" },
                                 { "15", "11", "10", "14" },
                                 { "7", "8", "5", "6" },
                                 { "4", "3", "2", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 16 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField16Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField ={ { " ", "12", "14", "13" },
                                 { "15", "11", "9", "10" },
                                 { "3", "7", "6", "2" },
                                 { "4", "8", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for IsSolvable - WithSolvableField 17 test 
        ///</summary>
        [TestMethod()]
        public void IsSolvableWithSolvableField17Test()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] gameField ={ { " ", "12", "14", "13" },
                                 { "15", "11", "9", "10" },
                                 { "8", "3", "6", "2" },
                                 { "4", "7", "5", "1" } };
            bool actual = target.IsSolvable(gameField);
            Assert.IsTrue(actual);
        }

        /// <summary>
        ///A test for GameBoard Constructor
        ///</summary>
        [TestMethod()]
        public void GameBoardConstructorTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            Assert.AreEqual(4, target.Board.GetLength(0));
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
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            string[,] expected = null; 
            string[,] actual;
            target.Board = expected;
            actual = target.Board;
            Assert.AreEqual(expected, actual);
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
    }
}
