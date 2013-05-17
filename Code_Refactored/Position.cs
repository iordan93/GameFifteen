using System;

namespace GameFifteen
{
    /// <summary>
    /// A class representing position on board.
    /// </summary>
    public class Position
    {
        private int row;
        private int column;

        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        /// <param name="row">Zero-based row number.</param>
        /// <param name="column">Zero-based column number.</param>
        public Position(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

        /// <summary>
        /// Gets or sets the column.
        /// </summary>
        /// <value>The column.</value>
        public int Column
        {
            get
            {
                return this.column;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("It is not allowed column to be negative number!");
                }

                this.column = value;
            }
        }

        /// <summary>
        /// Gets or sets the row.
        /// </summary>
        /// <value>The row.</value>
        public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("It is not allowed row to be negative number!");
                }

                this.row = value;
            }
        }

        // An interesting idea: To implement CompareTo() function that shows whether the first
        // Position object is on left, on top, on right, on bottom of the second Position object.
    }
}