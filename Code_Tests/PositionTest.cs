using GameFifteen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameFifteen.Test
{
    //TODO: must replace pattern with real unit tests!!!!
    
    /// <summary>
    ///This is a test class for PositionTest and is intended
    ///to contain all PositionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PositionTest
    {
        /// <summary>
        ///A test for Position Constructor
        ///</summary>
        [TestMethod()]
        public void PositionConstructorTest()
        {
            int row = 0; // TODO: Initialize to an appropriate value
            int column = 0; // TODO: Initialize to an appropriate value
            Position target = new Position(row, column);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Column
        ///</summary>
        [TestMethod()]
        public void ColumnTest()
        {
            int row = 0; // TODO: Initialize to an appropriate value
            int column = 0; // TODO: Initialize to an appropriate value
            Position target = new Position(row, column); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Column = expected;
            actual = target.Column;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Row
        ///</summary>
        [TestMethod()]
        public void RowTest()
        {
            int row = 0; // TODO: Initialize to an appropriate value
            int column = 0; // TODO: Initialize to an appropriate value
            Position target = new Position(row, column); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.Row = expected;
            actual = target.Row;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
