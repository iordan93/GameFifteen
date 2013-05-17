namespace GameFifteen
{
    using System;

    public class GameFifteen
    {
        // Like Settings...
        //private const int GameFieldRows = 4;
        //private const int GameFieldColumns = 4;

        //// Moved to GameBoard class
        //private static void FillOutGameField(string[,] gameField)
        //{
        //    Random generator = new Random();
        //    List<int> usedNumbers = new List<int>();
        //    bool isPositionFilled = false;

        //    gameField[generator.Next(GameFieldRows), generator.Next(GameFieldColumns)] = " ";

        //    for (int i = 0; i < gameField.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < gameField.GetLength(1); j++)
        //        {
        //            isPositionFilled = false;

        //            do
        //            {
        //                int number = generator.Next(1, 16);

        //                if (gameField[i, j] == " ")
        //                {
        //                    isPositionFilled = true;
        //                }
        //                else
        //                {
        //                    if (!usedNumbers.Contains(number))
        //                    {
        //                        gameField[i, j] = number.ToString();
        //                        isPositionFilled = true;
        //                        usedNumbers.Add(number);
        //                    }
        //                }
        //            }
        //            while (isPositionFilled == false);
        //        }
        //    }
        //}

        //// Moved to GameField
        //public static string[,] GenerateGameField()
        //{
        //    string[,] gameField = new string[GameFieldRows, GameFieldColumns];

        //    do
        //    {
        //        Position blankPosition = findPrazno(gameField);

        //        if (blankPosition != null)
        //        {
        //            gameField[blankPosition.Row, blankPosition.Column] = "0";
        //        }

        //        FillOutGameField(gameField);
        //    }
        //    while (!IsSolvable(gameField));

        //    return gameField;
        //}


        //// TODO: Place a comment about this method with reference!
        //// http://www.cs.bham.ac.uk/~mdr/teaching/modules04/java2/TilesSolvability.html


        //// Moved to GameField
        //internal static bool IsSolvable(string[,] gameField)
        //{
        //    int[] numbersInOneRow = new int[gameField.Length];
        //    int index = 0;
        //    Position blankPosition = null;

        //    for (int i = 0; i < gameField.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < gameField.GetLength(1); j++)
        //        {
        //            if (gameField[i, j] == " ")
        //            {
        //                numbersInOneRow[index] = 0;
        //                blankPosition = new Position(i, j);
        //            }
        //            else
        //            {
        //                numbersInOneRow[index] = int.Parse(gameField[i, j]);
        //            }

        //            index++;
        //        }
        //    }

        //    int numberOfInversions = 0;

        //    for (int i = 0; i < numbersInOneRow.Length; i++)
        //    {
        //        int number = numbersInOneRow[i];

        //        if (number > 1)
        //        {
        //            for (int n = i + 1; n < numbersInOneRow.Length; n++)
        //            {
        //                if (numbersInOneRow[n] < number && numbersInOneRow[n] != 0)
        //                {
        //                    numberOfInversions++;
        //                }
        //            }
        //        }
        //    }

        //    bool isFieldWidthEven = gameField.GetLength(1) % 2 == 0;
        //    bool isNumberOfInversionsEven = numberOfInversions % 2 == 0;
        //    bool isBlankOnOddRowFromBottom =
        //        (gameField.GetLength(0) - 1 - blankPosition.Row) % 2 == 0;

        //    bool isSolvable = ((!isFieldWidthEven) && isNumberOfInversionsEven) ||
        //        (isFieldWidthEven && (isBlankOnOddRowFromBottom == isNumberOfInversionsEven));

        //    return isSolvable;
        //}


        //// Moved to GameBoard and renamed to ToString()
        //private static void Drawmatrica(string[,] matrica)
        //{
        //    Console.WriteLine("  - - - - - -");

        //    // TODO: Fix the "magic" number!
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            // TODO: Can this be done without so many checks every cycle/loop?
        //            if (j == 0)
        //            {
        //                Console.Write("| {0,2} ", matrica[i, j]);
        //            }
        //            else if (j == 3)
        //            {
        //                Console.WriteLine("{0,2} |", matrica[i, j]);
        //            }
        //            else
        //            {
        //                Console.Write("{0,2} ", matrica[i, j]);
        //            }
        //        }
        //    }

        //    Console.WriteLine("  - - - - - -");
        //}


        //// Moved to GameBoard class and renamed to IsSolved()
        //private static bool proverka(string[,] matrica)
        //{
        //    int counter = 1;
        //    // TODO: Fix the "magic" number!
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            if (matrica[i, j] != counter.ToString())
        //            {
        //                if (counter == 16 && matrica[i, j] == " ")
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }

        //            counter++;
        //        }
        //    }

        //    return true;


        //}


        //// methos moved to GameBoard and renamed to FindEmptyCell
        //private static Position findPrazno(string[,] matrica)
        //{
        //    Position result = null;
        //    // TODO: Fix the "magic number"!
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            if (matrica[i, j] == " ")
        //            {
        //                result = new Position(i, j);
        //            }
        //        }
        //    }

        //    return result;
        //}

        private static void ChangeAndDraw(GameBoard gameBoard, int rowToChange, int columnToChange, int row, int column, string input)
        {
            // TODO: Spaghetti :P
            gameBoard[rowToChange, columnToChange] = input;
            gameBoard[row, column] = " ";
            Console.WriteLine(gameBoard.ToString());
        }

        private static Position FindCurrentElement(GameBoard board, string input)
        {
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    if (board[row, col] == input)
                    {
                        return new Position(row, col);
                    }
                }
            }

            // TODO: Add correct behaviour (YD)
            Console.WriteLine("Cheat ! Illegal command ! !");
            return null;
        }

        static void Main(string[] args)
        {
            // TODO: Manage all output and change to something which makes sense (YD)

            // TODO: Scenario:
            // Create scoreboard. Print welcome msg. (Create game field. Check if solvable.) Wait for user command until "exit" (switch). "restart" -> go back to print msg?
            // "top" -> show scoreboard if any records. "exit" -> print bye, exit loop. DEFAULT: Is INPUT number? Is number in range? -> Illegal number! Is number able to be moved?
            // -> Illegal move! Illegal command! | If game finished (puzzle solved) -> scoreboard.method...

            GameBoard board = new GameBoard(4);
            // string[,] gameField = GameFifteen.GenerateGameField();
            board.GenerateField();

            int moves = 0;
            // TODO: Extract to method the welcome message? And with const?
            Console.WriteLine("Welcome to the game \"15\". Please try to arrange the numbers " +
                "sequentially .\nUse 'top' to view the top scoreboard, 'restart' to start a new " +
                "game and 'exit' \nto quit the game.\n\n\n");

            Console.WriteLine(board.ToString());

            while (!board.IsSolved())
            {
                Console.Write("Enter a number to move: ");
                string input = Console.ReadLine();
                bool blank = false;

                if (input == "exit")
                {
                    // TODO: Not implemented!
                    Console.WriteLine("Good bye !");
                }

                if (input == "restart")
                {
                    Console.WriteLine("Here is your new matrica, have a good play : \n\n\n");
                    board.GenerateField();
                    Console.WriteLine(board.ToString());
                    moves = 0;
                    continue;
                }

                if (input == "top")
                {
                    // TODO: Draw if records are presented. Extract method. In class.
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Name : {0} , moves : {1} ", Highscores.players[i], Highscores.moves[i]);
                    }
                    continue;

                }

                if (FindCurrentElement(board, input) == null)
                {
                    continue;
                }

                int rowCurrentElement = FindCurrentElement(board, input).Row;
                int columnCurrentElement = FindCurrentElement(board, input).Column;

                // TODO: Magic, magic, magic... Method?
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        if (rowCurrentElement - 1 >= 0)
                        {
                            if (board[rowCurrentElement - 1, columnCurrentElement] == " ")
                            {
                                ChangeAndDraw(board, rowCurrentElement - 1, columnCurrentElement, rowCurrentElement, columnCurrentElement, input);
                                blank = true;
                                moves++;
                            }
                        }
                    }

                    if (i == 1)
                    {
                        if(rowCurrentElement + 1 <= 3)
                        {
                            if (board[rowCurrentElement + 1, columnCurrentElement] == " ")
                            {
                                ChangeAndDraw(board, rowCurrentElement + 1, columnCurrentElement, rowCurrentElement, columnCurrentElement, input);
                                blank = true;
                                moves++;
                            }
                        }
                    }

                    if (i == 2)
                    {
                        if (columnCurrentElement - 1 >= 0)
                        {
                            if (board[rowCurrentElement, columnCurrentElement - 1] == " ")
                            {
                                ChangeAndDraw(board, rowCurrentElement, columnCurrentElement - 1, rowCurrentElement, columnCurrentElement, input);
                                blank = true;
                                moves++;
                            }
                        }
                    }

                    if (i == 3)
                    {
                        if (columnCurrentElement + 1 <= 3)
                        {
                            if (board[rowCurrentElement, columnCurrentElement + 1] == " ")
                            {
                                ChangeAndDraw(board, rowCurrentElement, columnCurrentElement + 1, rowCurrentElement, columnCurrentElement, input);
                                blank = true;
                                moves++;
                            }
                        }
                    }
                }

                if (!blank)
                {
                    Console.WriteLine("Cheat ! Illegal command ! !");
                }
            }

            Console.WriteLine("Your result is {0} moves !", moves);

            // TODO: Extract method. In class. Fix bug! (moves = 0)
            for (int i = 0; i < 5; i++)
            {
                if (Highscores.moves[i] > moves)
                {
                    Console.WriteLine("Congratulations, you have just putted a new record");
                    Console.Write("Please enter your name : ");

                    Highscores.moves[i] = moves;

                    Highscores.players[i] = Console.ReadLine();
                }
            }

            // TODO: A new game doesn't start automatically!

        }
    }
}








