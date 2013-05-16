namespace GameFifteen
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GameBoard
    {
        private int gameBoardSize = 4;

        private string[,] board;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameBoard" /> class.
        /// </summary>
        public GameBoard(int gameBoardSize)
        {
            this.GameBoardSize = gameBoardSize;
            this.Board = new string[this.GameBoardSize, this.GameBoardSize];
        }

        /// <summary>
        /// Gets or sets the game board.
        /// </summary>
        /// <value>The game board.</value>
        public string[,] Board
        {
            get
            {
                return this.board;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Game board can not be assigned to null!.");
                }
                this.board = value;
            }
        }

        public string this[int indexRow, int indexColumn]
        {
            get
            {
                if (indexRow < 0 || indexRow > this.gameBoardSize || indexColumn < 0 || indexColumn > this.gameBoardSize)
                {
                    throw new ArgumentOutOfRangeException("Indexes can not be smeller than 0 and greater than current size of the board-1.");
                }
                return this.Board[indexRow, indexColumn];
            }

            set
            {
                if (indexRow < 0 || indexRow > this.gameBoardSize || indexColumn < 0 || indexColumn > this.gameBoardSize)
                {
                    throw new ArgumentOutOfRangeException("Indexes can not be smeller than 0 and greater than current size of the board-1.");
                }
                this.Board[indexRow, indexColumn] = value;
            }
        }

        /// <summary>
        /// Gets or sets the size of the game board.
        /// </summary>
        /// <value>The size of the game board.</value>
        public int GameBoardSize
        {
            get
            {
                return this.gameBoardSize;
            }
            private set
            {
                this.gameBoardSize = value;
            }
        }

        public void GenerateField()
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


        // TODO: Place a comment about this method with reference!
        // http://www.cs.bham.ac.uk/~mdr/teaching/modules04/java2/TilesSolvability.html

        public bool IsSolvable(string[,] gameField)
        {
            int[] numbersInOneRow = new int[gameField.Length];
            int index = 0;
            Position blankPosition = null;

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (gameField[i, j] == " ")
                    {
                        numbersInOneRow[index] = 0;
                        blankPosition = new Position(i, j);
                    }
                    else
                    {
                        numbersInOneRow[index] = int.Parse(gameField[i, j]);
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

            bool isFieldWidthEven = gameField.GetLength(1) % 2 == 0;
            bool isNumberOfInversionsEven = numberOfInversions % 2 == 0;
            bool isBlankOnOddRowFromBottom =
                (gameField.GetLength(0) - 1 - blankPosition.Row) % 2 == 0;

            bool isSolvable = ((!isFieldWidthEven) && isNumberOfInversionsEven) ||
                (isFieldWidthEven && (isBlankOnOddRowFromBottom == isNumberOfInversionsEven));

            return isSolvable;
        }


        private void FillOut(string[,] gameField)
        {
            Random generator = new Random();
            List<int> usedNumbers = new List<int>();
            bool isPositionFilled = false;

            this.Board[generator.Next(this.GameBoardSize), generator.Next(this.GameBoardSize)] = " ";

            for (int i = 0; i < this.GameBoardSize; i++)
            {
                for (int j = 0; j < this.GameBoardSize; j++)
                {
                    isPositionFilled = false;

                    do
                    {
                        int number = generator.Next(1, this.GameBoardSize * this.GameBoardSize);

                        if (gameField[i, j] == " ")
                        {
                            isPositionFilled = true;
                        }
                        else
                        {
                            if (!usedNumbers.Contains(number))
                            {
                                gameField[i, j] = number.ToString();
                                isPositionFilled = true;
                                usedNumbers.Add(number);
                            }
                        }
                    }
                    while (!isPositionFilled);
                }
            }
        }

        internal Position FindEmptyCell()
        {
            Position result = null;
            for (int i = 0; i < this.GameBoardSize; i++)
            {
                for (int j = 0; j < this.GameBoardSize; j++)
                {
                    if (this.Board[i, j] == " ")
                    {
                        result = new Position(i, j);
                    }
                }
            }

            return result;
        }

        public bool IsSolved()
        {
            int counter = 1;
            for (int i = 0; i < this.GameBoardSize; i++)
            {
                for (int j = 0; j < this.GameBoardSize; j++)
                {
                    if (this.Board[i, j] != counter.ToString())
                    {
                        if (counter == 16 && this.Board[i, j] == " ")
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

        public override string ToString()
        {
            if (this.Board != null)
            {


                StringBuilder output = new StringBuilder();
                output.AppendLine("  - - - - - -");
                for (int row = 0; row < this.GameBoardSize; row++)
                {
                    for (int column = 0; column < this.GameBoardSize; column++)
                    {
                        switch (column)
                        {
                            case 0:
                                output.AppendFormat("| {0,2} ", this.Board[row, column]);
                                break;
                            case 3:
                                output.AppendFormat("{0,2} |\n", this.Board[row, column]);
                                break;
                            default:
                                output.AppendFormat("{0,2} ", this.Board[row, column]);
                                break;
                        }
                    }
                }

                output.AppendLine("  - - - - - -");
                return output.ToString();
            }

            return null;
        }

    }
}
