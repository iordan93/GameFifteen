namespace GameFifteen
{
    using System;

    public class GameFifteen
    {
        public static void Main(string[] args)
        {
            int moves = 0;
            GameBoard board = new GameBoard(4);
            Highscores highscores = new Highscores();

            GameEngine.DisplayWelcomeMessage();

            board.GenerateBoard();
            Console.WriteLine(board);

            while (!board.IsSolved())
            {
                Console.Write("Enter a number to move: ");
                string input = GameEngine.ReadInput();

                bool hasBlankNeighbour = false;

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
                for (int i = 0; i < 4; i++)
                {
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

                    if (currentElement.Row + 1 <= 3 && board[currentElement.Row + 1, currentElement.Column] == " ")
                    {
                        string updatedBoard = board.GetUpdatedBoard(
                            new Position(currentElement.Row + 1, currentElement.Column),
                            new Position(currentElement.Row, currentElement.Column),
                            input);
                        Console.WriteLine(updatedBoard);

                        hasBlankNeighbour = true;
                        moves++;
                    }

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

                    if (currentElement.Column + 1 <= 3 && board[currentElement.Row, currentElement.Column + 1] == " ")
                    {
                        string updatedBoard = board.GetUpdatedBoard(
                            new Position(currentElement.Row, currentElement.Column + 1),
                            new Position(currentElement.Row, currentElement.Column),
                            input);

                        Console.WriteLine(updatedBoard);
                        hasBlankNeighbour = true;
                        moves++;
                    }
                }

                if (!hasBlankNeighbour)
                {
                    Console.WriteLine("Illegal move!");
                }
            }

            if (moves > 0)
            {
                Console.WriteLine("Congratulations! You won the gaime in {0} moves.", moves);
                Console.Write("Please enter your name for the top scoreboard: ");
                string name = Console.ReadLine();
                highscores.Add(new Score(moves, name));
                Console.WriteLine(highscores);

                GameEngine.DisplayWelcomeMessage();
                board.GenerateBoard();
                Console.WriteLine(board);
            }
        }
    }
}