namespace GameFifteen
{
    using System;

    public class GameEngine
    {
        /// <summary>
        /// Reads the user input from the console.
        /// </summary>
        /// <returns>Returns the user input as string.</returns>
        public static string ReadInput()
        {
            string input = Console.ReadLine();
            return input;
        }

        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the game \"15\". Please try to arrange the numbers sequentially. " +
                "Use 'top' to view the top scoreboard, 'restart' to start a new game and 'exit' to quit the game.");
        }

        public static int PlayGame(GameBoard board, Highscores highscores)
        {
            //string[,] gameField =
            //    {
            //        { "1", "2", "3", "4" },
            //        { "5", "6", "7", "8" },
            //        { "9", "10", "11", "12" },
            //        { "13", "14", " ", "15" }
            //    };
            //board = new GameBoard(gameField);
            int moves = 0;


            GameEngine.DisplayWelcomeMessage();

            Console.WriteLine(board);
            while (!board.IsSolved())
            {
                Console.Write("Enter a number to move: ");
                string input = GameEngine.ReadInput();

                if (input == "exit")
                {
                    Console.WriteLine("Good bye!");
                    break;
                }

                if (input == "restart")
                {
                    GameEngine.DisplayWelcomeMessage();
                    board.GenerateBoard();
                    Console.WriteLine(board);
                    moves = 0;
                    continue;
                }

                if (input == "top")
                {
                    Console.WriteLine(highscores);
                    GameEngine.PlayGame(board, highscores);
                    continue;
                }

                try
                {
                    board.FindCurrentElement(input);
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Illegal command!");
                    continue;
                }

                Position currentElement = board.FindCurrentElement(input);

                bool hasBlankNeighbour = GameEngine.TryMoveBlock(currentElement, board, input, ref moves);

                if (!hasBlankNeighbour)
                {
                    Console.WriteLine("Illegal move!");
                }
            }

            if (moves > 0)
            {
                Console.WriteLine("Congratulations! You won the game in {0} moves.", moves);

                if (highscores.IsHighscore(moves))
                {
                    Console.Write("Please enter your name for the top scoreboard: ");
                    string name = Console.ReadLine();

                    highscores.Add(new Score(moves, name));
                }
                Console.WriteLine(highscores);

                GameEngine.DisplayWelcomeMessage();
                board.GenerateBoard();
                Console.WriteLine(board);
                PlayGame(board, highscores);
            }
            return moves;
        }

        internal static bool TryMoveBlock(Position currentElement, GameBoard board, string input, ref int moves)
        {
            bool hasBlankNeighbour = false;

            // Up
            if (currentElement.Row - 1 >= 0 && board[currentElement.Row - 1, currentElement.Column] == " ")
            {
                string updatedBoard = board.GetUpdatedBoard(
                    new Position(currentElement.Row - 1, currentElement.Column),
                    new Position(currentElement.Row, currentElement.Column),
                    input);
                Console.WriteLine(updatedBoard);

                hasBlankNeighbour = true;
                moves++;
            }

            // Down
            if (currentElement.Row + 1 < board.Size && board[currentElement.Row + 1, currentElement.Column] == " ")
            {
                string updatedBoard = board.GetUpdatedBoard(
                    new Position(currentElement.Row + 1, currentElement.Column),
                    new Position(currentElement.Row, currentElement.Column),
                    input);
                Console.WriteLine(updatedBoard);

                hasBlankNeighbour = true;
                moves++;
            }

            // Left
            if (currentElement.Column - 1 >= 0 && board[currentElement.Row, currentElement.Column - 1] == " ")
            {
                string updatedBoard = board.GetUpdatedBoard(
                    new Position(currentElement.Row, currentElement.Column - 1),
                    new Position(currentElement.Row, currentElement.Column),
                    input);

                Console.WriteLine(updatedBoard);
                hasBlankNeighbour = true;
                moves++;
            }

            // Right
            if (currentElement.Column + 1 < board.Size && board[currentElement.Row, currentElement.Column + 1] == " ")
            {
                string updatedBoard = board.GetUpdatedBoard(
                    new Position(currentElement.Row, currentElement.Column + 1),
                    new Position(currentElement.Row, currentElement.Column),
                    input);

                Console.WriteLine(updatedBoard);
                hasBlankNeighbour = true;
                moves++;
            }

            return hasBlankNeighbour;
        }
    }
}