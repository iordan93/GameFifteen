namespace GameFifteen
{
    using System;

    public class GameFifteen
    {
        public static void Main(string[] args)
        {
            // TODO: Manage all output and change to something which makes sense (YD)

            // TODO: Scenario:
            // Create scoreboard. Print welcome msg. (Create game 
            // Check if solvable.) Wait for user command until "exit" (switch). "restart" -> go back to print msg?
            // "top" -> show scoreboard if any records. "exit" -> print bye, exit loop. DEFAULT: Is INPUT number? Is number in range? -> Illegal number! Is number able to be moved?
            // -> Illegal move! Illegal command! | If game finished (puzzle solved) -> scoreboard.method...
            GameBoard board = new GameBoard(4);
            board.Generate();

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
                    board.Generate();
                    Console.WriteLine(board.ToString());
                    moves = 0;
                    continue;
                }

                if (input == "top")
                {
                    // TODO: Draw if records are presented. Extract method. In class.
                    for (int i = 0; i < 5; i++)
                    {
                        // Console.WriteLine("Name : {0} , moves : {1} ", Highscores.players[i], Highscores.moves[i]);
                    }

                    continue;
                }

                if (FindCurrentElement(board, input) == null)
                {
                    continue;
                }

                int currentElementRow = FindCurrentElement(board, input).Row;
                int currentElementCol = FindCurrentElement(board, input).Column;

                // TODO: Magic, magic, magic... Method?
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        if (currentElementRow - 1 >= 0)
                        {
                            if (board[currentElementRow - 1, currentElementCol] == " ")
                            {
                                string updatedBoard = GetUpdatedBoard(board, new Position(currentElementRow - 1, currentElementCol),
                                    new Position(currentElementRow, currentElementCol), input);
                                Console.WriteLine(updatedBoard);
                                blank = true;
                                moves++;
                            }
                        }
                    }

                    if (i == 1)
                    {
                        if (currentElementRow + 1 <= 3)
                        {
                            if (board[currentElementRow + 1, currentElementCol] == " ")
                            {
                                string updatedBoard = GetUpdatedBoard(board, new Position(currentElementRow + 1, currentElementCol),
                                    new Position(currentElementRow, currentElementCol), input);
                                Console.WriteLine(updatedBoard);
                                blank = true;
                                moves++;
                            }
                        }
                    }

                    if (i == 2)
                    {
                        if (currentElementCol - 1 >= 0)
                        {
                            if (board[currentElementRow, currentElementCol - 1] == " ")
                            {
                                string updatedBoard = GetUpdatedBoard(board, new Position(currentElementRow, currentElementCol - 1),
                                    new Position(currentElementRow, currentElementCol), input);
                                Console.WriteLine(updatedBoard);
                                blank = true;
                                moves++;
                            }
                        }
                    }

                    if (i == 3)
                    {
                        if (currentElementCol + 1 <= 3)
                        {
                            if (board[currentElementRow, currentElementCol + 1] == " ")
                            {
                                string updatedBoard = GetUpdatedBoard(board, new Position(currentElementRow, currentElementCol + 1),
                   new Position(currentElementRow, currentElementCol), input);
                                Console.WriteLine(updatedBoard);
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
            //for (int i = 0; i < 5; i++)
            //{
            //    if (Highscores.moves[i] > moves)
            //    {
            //        Console.WriteLine("Congratulations, you have just put a new record");
            //        Console.Write("Please enter your name : ");

            //        Highscores.moves[i] = moves;

            //        Highscores.players[i] = Console.ReadLine();
            //    }
            //}

            // TODO: A new game doesn't start automatically!
        }

        private static string GetUpdatedBoard(GameBoard gameBoard, Position oldPosition, Position newPosition, string input)
        {
            gameBoard[oldPosition.Row, oldPosition.Column] = input;
            gameBoard[newPosition.Row, newPosition.Column] = " ";
            return gameBoard.ToString();
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
    }
}