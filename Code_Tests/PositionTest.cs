using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameFifteen.Test
{
    /// <summary>
    ///This is a test class for <see cref="Position"/> and is intended
    ///to contain all <see cref="Position"/> Unit Tests
    ///</summary>
    [TestClass]
    public class PositionTest
    {
        /// <summary>
        ///A test for Position Constructor
        ///</summary>
        [TestMethod]
        public void PositionConstructorTest()
        {
            int row = 2;
            int column = 2;
            Position target = new Position(row, column);
            Assert.IsTrue((target != null) && (target.Row == row) && (target.Column == column));
        }

        /// <summary>
        ///A test for Column
        ///</summary>
        [TestMethod]
        public void ColumnTest()
        {
            int row = 0;
            int column = 0;
            Position target = new Position(row, column);
            int expected = 1;
            int actual;
            target.Column = expected;
            actual = target.Column;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Row
        ///</summary>
        [TestMethod]
        public void RowTest()
        {
            int row = 0;
            int column = 0;
            Position target = new Position(row, column);
            int expected = 2;
            int actual;
            target.Row = expected;
            actual = target.Row;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// A test for ArgumentOutOfRangeException in Column property.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeColumnExceptionTest()
        {
            int row = 0;
            int column = -2;
            Position target = new Position(row, column);
        }

        /// <summary>
        /// A test for ArgumentOutOfRangeException in Row property.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeRowExceptionTest()
        {
            int row = -2;
            int column = 0;
            Position target = new Position(row, column);
        }
    }
}
