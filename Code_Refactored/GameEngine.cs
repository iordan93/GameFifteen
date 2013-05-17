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