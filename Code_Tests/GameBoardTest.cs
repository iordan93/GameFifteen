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
        ///A test for IsSolved - solved board
        ///</summary>
        [TestMethod()]
        public void IsSolvedSolvedBoardTest()
        {
            int gameBoardSize = 4; 
            GameBoard target = new GameBoard(gameBoardSize); 
            bool expected = true; 
            string[,] gameField ={ { "1", "2", "3", "4" },
                                 { "5", "6", "7", "8" },
                                 { "9", "10", "11", "12" },
                                 { "13", "14", "15", " " } };
            bool actual = target.IsSolved();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for IsSolved
        ///</summary>
        [TestMethod()]
        public void IsSolvedEmptyBoardTest()
        {
            int gameBoardSize = 4; // TODO: Initialize to an appropriate value
            GameBoard target = new GameBoard(gameBoardSize); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            string[,] gameField ={ { "1", "22", "14", "13" },
                                 { "15", "11", "9", "10" },
                                 { "8", "3", "6", "2" },
                                 { "4", "7", "5", "1" } };
            bool actual = target.IsSolved();
            Assert.AreEqual(expected, actual);
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
        [ExpectedException(typeof(ArgumentException))]
        public void BoardTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            target.Board = null;
        }

        /// <summary>
        ///A test for Item - Write to negative row -> Exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ItemWriteNegativeRowTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            int indexRow = -5;
            int indexColumn = 0;
            string noneValue = string.Empty;
            target[indexRow, indexColumn] = noneValue;
        }

        /// <summary>
        ///A test for Item - Write to negative column -> Exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ItemWriteNegativeColumnTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            int indexRow = 0;
            int indexColumn = -9;
            string noneValue = string.Empty;
            target[indexRow, indexColumn] = noneValue;
        }

        /// <summary>
        ///A test for Item - Write to column bigger than size of board -> Exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ItemWriteBiggerThanSizeOfBoardColumnTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            int indexRow = 3;
            int indexColumn = 30;
            string noneValue = string.Empty;
            target[indexRow, indexColumn] = noneValue;
        }

        /// <summary>
        ///A test for Item - Write to row bigger than size of board -> Exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ItemWrieBiggerThanSizeOfBoardRowTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            int indexRow = 10;
            int indexColumn = 0;
            string noneValue = string.Empty;
            target[indexRow, indexColumn] = noneValue;
        }

        /// <summary>
        ///A test for Item - Read / Write / Compare
        ///</summary>
        [TestMethod()]
        public void ItemReadWriteTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            int indexRow = 2;
            int indexColumn = 2;
            string expected = "4";
            target[indexRow, indexColumn] = expected;
            string actual = target[indexRow, indexColumn];
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Item - Read from column bigger than size of board -> Exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ItemReadBiggerThanSizeOfBoardColumnTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            int indexRow = 2;
            int indexColumn = 33;
            string value = target[indexRow, indexColumn];

        }

        /// <summary>
        ///A test for Item - Read from row bigger than size of board -> Exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ItemReadBiggerThanSizeOfBoardRowTest()
        {
            int gameBoardSize = 4;
            GameBoard target = new GameBoard(gameBoardSize);
            int indexRow = 23;
            int indexColumn = 3;
            string value = target[indexRow, indexColumn];

        }
    }
}
