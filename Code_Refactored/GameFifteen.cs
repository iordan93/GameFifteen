namespace GameFifteen
{
    using System;

    /// <summary>
    /// The main class to play game.
    /// </summary>
    public class GameFifteen
    {
        /// <summary>
        /// Entry point for the game.
        /// </summary>
        public static void Main()
        {
            GameBoard board = new GameBoard(4);
            board.GenerateBoard();
            Highscores highscores = new Highscores();

            GameEngine.PlayGame(board, highscores);
        }
    }
}