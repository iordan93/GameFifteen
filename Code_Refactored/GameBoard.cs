using System;
using System.Collections.Generic;
using System.Text;

namespace GameFifteen
{
    /// <summary>
    /// The board for the game "Fifteen".
    /// </summary>
    public class GameBoard
    {
        private int size = 4;
        private string[,] board;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameBoard" /> class.
        /// </summary>
        /// <param name="gameBoardSize">The dimensions of the board.</param>
        public GameBoard(int gameBoardSize)
        {
            this.Size = gameBoardSize;
            this.Board = new string[this.Size, this.Size];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameBoard" /> class.
        /// </summary>
        /// <param name="boardContent">The content of the board.</param>
        public GameBoard(string[,] boardContent)
        {
            if (boardContent == null)
            {
                throw new ArgumentNullException("boardContent");
            }

            if (boardContent.GetLength(0) != boardContent.GetLength(1))
            {
                throw new ArgumentException("The board is not square.");
            }

            this.Size = boardContent.GetLength(0);
            this.Board = boardContent;
        }

        /// <summary>
        /// Gets the game board.
        /// </summary>
        /// <value>The game board.</value>
        public string[,] Board
        {
            get
            {
                return this.board;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("board", "Game board can not be assigned to null!.");
                }

                this.board = value;
            }
        }

        /// <summary>
        /// Gets the size of the game board.
        /// </summary>
        /// <value>The size of the game board.</value>
        public int Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                this.size = value;
            }
        }

        /// <summary>
        /// Game board indexer for accessing each cell on it.
        /// </summary>
        /// <param name="indexRow">Row index.</param>
        /// <param name="indexColumn">Column index.</param>
        /// <returns>Value in the requested position.</returns>
        public string this[int indexRow, int indexColumn]
        {
            get
            {
                if (indexRow < 0 || indexRow > this.size ||
                    indexColumn < 0 || indexColumn > this.size)
                {
                    throw new ArgumentOutOfRangeException("Indexes can not be smeller than 0 and greater than current size of the board.");
                }

                return this.Board[indexRow, indexColumn];
            }

            set
            {
                if (indexRow < 0 || indexRow > this.size ||
                    indexColumn < 0 || indexColumn > this.size)
                {
                    throw new ArgumentOutOfRangeException("Indexes can not be smeller than 0 and greater than current size of the board.");
                }

                this.Board[indexRow, indexColumn] = value;
            }
        }

        /// <summary>
        /// Generates initial state of the game board.
        /// </summary>
        public void GenerateBoard()
        {
            do
            {
                Position blankPosition = this.FindEmptyCell();

                if (blankPosition != null)
                {
                    this.Board[blankPosition.Row, blankPosition.Column] = "0";
                }

                this.FillOut(this.Board);
            }
            while (!this.IsSolvable(this.Board));
        }

        /// <summary>
        /// Checks whether current state of game board is solvable.
        /// </summary>
        /// <param name="gameBoard">The game board.</param>
        /// <returns>True if solvable, false if not.</returns>
        public bool IsSolvable(string[,] gameBoard)
        {
            int[] numbersInOneRow = new int[gameBoard.Length];
            int index = 0;
            Position blankPosition = null;

            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    if (gameBoard[i, j] == " ")
                    {
                        numbersInOneRow[index] = 0;
                        blankPosition = new Position(i, j);
                    }
                    else
                    {
                        numbersInOneRow[index] = int.Parse(gameBoard[i, j]);
                    }

                    index++;
                }
            }

            int numberOfInversions = 0;

            for (int i = 0; i < numbersInOneRow.Length; i++)
            {
                int number = numbersInOneRow[i];

                if (number > 1)
                {
                    for (int n = i + 1; n < numbersInOneRow.Length; n++)
                    {
                        if (numbersInOneRow[n] < number && numbersInOneRow[n] != 0)
                        {
                            numberOfInversions++;
                        }
                    }
                }
            }

            bool isFieldWidthEven = gameBoard.GetLength(1) % 2 == 0;
            bool isNumberOfInversionsEven = numberOfInversions % 2 == 0;
            bool isBlankOnOddRowFromBottom =
                (gameBoard.GetLength(0) - 1 - blankPosition.Row) % 2 == 0;

            bool isSolvable = ((!isFieldWidthEven) && isNumberOfInversionsEven) ||
                (isFieldWidthEven && (isBlankOnOddRowFromBottom == isNumberOfInversionsEven));

            return isSolvable;
        }

        /// <summary>
        /// Checks whether the game has been solved by traversing all positions on game board.
        /// </summary>
        /// <returns>True if solved, else if not.</returns>
        public bool IsSolved()
        {
            int counter = 1;
            for (int row = 0; row < this.Size; row++)
            {
                for (int col = 0; col < this.Size; col++)
                {
                    if (this.Board[row, col] != counter.ToString())
                    {
                        if (counter == this.Size * this.Size && this.Board[row, col] == " ")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    counter++;
                }
            }

            return true;
        }

        /// <summary>
        /// Renders the current state of game board.
        /// </summary>
        /// <returns>String containing representation of the current game board.</returns>
        public override string ToString()
        {
            if (this.Board != null)
            {
                StringBuilder output = new StringBuilder();
                output.AppendLine("  - - - - - -");
                for (int row = 0; row < this.Size; row++)
                {
                    // The left "border"
                    output.Append("| ");

                    for (int column = 0; column < this.Size; column++)
                    {
                        output.AppendFormat("{0,2} ", this.Board[row, column]);
                    }

                    // The right "border"
                    output.Append("|\n");
                }

                output.AppendLine("  - - - - - -");
                return output.ToString();
            }

            return null;
        }

        internal void UpdateBoard(Position oldPosition, Position newPosition, string input)
        {
            this[oldPosition.Row, oldPosition.Column] = input;
            this[newPosition.Row, newPosition.Column] = " ";
        }

        internal Position FindCurrentElement(string input)
        {
            for (int row = 0; row < this.Size; row++)
            {
                for (int col = 0; col < this.Size; col++)
                {
                    if (this[row, col] == input)
                    {
                        return new Position(row, col);
                    }
                }
            }

            throw new ArgumentException(string.Format("The element {0} does not exist in the game board.", input));
        }

        /// <summary>
        /// Finds current empty cell.
        /// </summary>
        /// <returns>Coordinates in <see cref="Position"/> format.</returns>
        private Position FindEmptyCell()
        {
            Position result = null;
            for (int row = 0; row < this.Size; row++)
            {
                for (int col = 0; col < this.Size; col++)
                {
                    if (this.Board[row, col] == " ")
                    {
                        result = new Position(row, col);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Fills out the game board with randomly generated numbers and positions.
        /// <param name="gameField">The game field to be filled out.</param>
        /// </summary>
        private void FillOut(string[,] gameField)
        {
            Random generator = new Random();
            List<int> usedNumbers = new List<int>();
            bool isPositionFilled = false;

            this.Board[generator.Next(this.Size), generator.Next(this.Size)] = " ";

            for (int row = 0; row < this.Size; row++)
            {
                for (int col = 0; col < this.Size; col++)
                {
                    isPositionFilled = false;

                    do
                    {
                        int number = generator.Next(1, this.Size * this.Size);

                        if (gameField[row, col] == " ")
                        {
                            isPositionFilled = true;
                        }
                        else
                        {
                            if (!usedNumbers.Contains(number))
                            {
                                gameField[row, col] = number.ToString();
                                isPositionFilled = true;
                                usedNumbers.Add(number);
                            }
                        }
                    }
                    while (!isPositionFilled);
                }
            }
        }
    }
}