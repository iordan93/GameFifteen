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
            Console.WriteLine("Welcome to the game \"15\". Please try to arrange the numbers " +
                    "sequentially .\nUse 'top' to view the top scoreboard, 'restart' to start a new " +
                    "game and 'exit' \nto quit the game.");
        }
    }
}
