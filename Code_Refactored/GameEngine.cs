using System;

namespace GameFifteen
{
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

        public static void PlayGame(GameBoard board, Highscores highscores)
        {
            GameEngine.DisplayWelcomeMessage();
            int moves = 0;
            string input = String.Empty;

            do
            {
                Console.Write(board);
                Console.Write("Enter a number to move: ");
                input = GameEngine.ReadInput();

                switch (input)
                {
                    case "exit":
                        Console.WriteLine("Good bye!");
                        return;
                    case "restart":
                        GameBoard newGameBoard = new GameBoard(board.Size);
                        newGameBoard.GenerateBoard();
                        board = newGameBoard;
                        Console.WriteLine();
                        GameEngine.DisplayWelcomeMessage();
                        moves = 0;
                        break;
                    case "top":
                        Console.Write(highscores);
                        break;
                    default:
                        try
                        {
                            board.FindCurrentElement(input);
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Illegal command!");
                            break;
                        }

                        Position currentElement = board.FindCurrentElement(input);
                        bool hasBlankNeighbour = GameEngine.TryMoveBlock(currentElement, board, input, ref moves);

                        if (!hasBlankNeighbour)
                        {
                            Console.WriteLine("Illegal move!");
                        }

                        break;
                }

                if (board.IsSolved())
                {
                    Console.WriteLine("Congratulations! You won the game in {0} moves.", moves);

                    if (highscores.IsHighscore(moves))
                    {
                        Console.Write("Please enter your name for the top scoreboard: ");
                        string name = Console.ReadLine();

                        highscores.Add(new Score(moves, name));
                    }

                    Console.Write(highscores);

                    GameBoard newGameBoard = new GameBoard(board.Size);
                    newGameBoard.GenerateBoard();
                    board = newGameBoard;
                    Console.WriteLine();
                    GameEngine.DisplayWelcomeMessage();
                    moves = 0;
                }
            }
            while (input != "exit");
        }

        internal static bool TryMoveBlock(Position currentElement, GameBoard board, string input, ref int moves)
        {
            bool hasBlankNeighbour = false;

            // Up
            if (currentElement.Row - 1 >= 0 && board[currentElement.Row - 1, currentElement.Column] == " ")
            {
                board.UpdateBoard(
                    new Position(currentElement.Row - 1, currentElement.Column),
                    new Position(currentElement.Row, currentElement.Column),
                    input);

                hasBlankNeighbour = true;
                moves++;
            }

            // Down
            if (currentElement.Row + 1 < board.Size && board[currentElement.Row + 1, currentElement.Column] == " ")
            {
                board.UpdateBoard(
                    new Position(currentElement.Row + 1, currentElement.Column),
                    new Position(currentElement.Row, currentElement.Column),
                    input);

                hasBlankNeighbour = true;
                moves++;
            }

            // Left
            if (currentElement.Column - 1 >= 0 && board[currentElement.Row, currentElement.Column - 1] == " ")
            {
                board.UpdateBoard(
                    new Position(currentElement.Row, currentElement.Column - 1),
                    new Position(currentElement.Row, currentElement.Column),
                    input);

                hasBlankNeighbour = true;
                moves++;
            }

            // Right
            if (currentElement.Column + 1 < board.Size && board[currentElement.Row, currentElement.Column + 1] == " ")
            {
                board.UpdateBoard(
                    new Position(currentElement.Row, currentElement.Column + 1),
                    new Position(currentElement.Row, currentElement.Column),
                    input);

                hasBlankNeighbour = true;
                moves++;
            }

            return hasBlankNeighbour;
        }
    }
}