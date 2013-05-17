namespace GameFifteen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Highscores
    {
        /// <summary>
        /// This is the top score table
        /// </summary>
        public const int PlayersCount = 5;

        public static int[] moves = new int[PlayersCount];
        public static string[] players = new string[PlayersCount];
    }
}