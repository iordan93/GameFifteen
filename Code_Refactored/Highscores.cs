namespace GameFifteen
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Highscores
    {
        public const int Size = 5;
        private List<Score> scores = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Highscores"/> class.
        /// </summary>
        public Highscores()
        {
            this.scores = new List<Score>(Size);
        }

        /// <summary>
        /// Gets or sets the list of scores.
        /// </summary>
        /// <value>Gets or sets the scores list.</value>
        public List<Score> Scores
        {
            get
            {
                return this.scores;
            }

            set
            {
                this.scores = value;
            }
        }

        public bool IsHighscore(int points)
        {
            if (this.Scores.Count < Size)
            {
                return true;
            }

            return this.Scores[this.Scores.Count - 1].Moves > points;
        }

        /// <summary>
        /// Adds score to list of top scores.
        /// </summary>
        /// <param name="score">The <see cref="Score"/> object to be added.</param>
        public void Add(Score score)
        {
            this.Scores.Add(score);
            this.Scores.Sort((x, y) => x.CompareTo(y));

            if (this.Scores.Count > Size)
            {
                this.Scores.RemoveAt(this.Scores.Count - 1);
            }
        }

        /// <summary>
        /// Casts <see cref="Highscores"/> to String.
        /// </summary>
        /// <returns>Returns the System.String representation of the top score board.</returns>
        public override string ToString()
        {
            if (this.Scores.Count == 0)
            {
                return "There are no highscores!";
            }

            StringBuilder result = new StringBuilder();
            result.AppendLine("Scoreboard:");

            for (int i = 0; i < this.Scores.Count; i++)
            {
                result.AppendLine(string.Format("{0}. {1}", i + 1, this.Scores[i].ToString()));
            }

            return result.ToString();
        }

        /// <summary>
        /// Prints the list of top scores on the console.
        /// </summary>
        internal void DrawHighscores()
        {
            Console.WriteLine(this.ToString());
        }
    }
}