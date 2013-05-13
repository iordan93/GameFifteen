using System;

namespace GameFifteen
{
    public class Position
    {
        private int row;
        private int column;

        /// <summary>
        /// Initializes an instance of <see cref="Position"/> class.
        /// </summary>
        /// <param name="row">Row number.</param>
        /// <param name="column">Column number.</param>
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
                if (value < 0 )
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
    }
}
