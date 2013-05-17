namespace GameFifteen
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Highscores
    {
        private const int Size = 5;
        private List<Score> scores = null;

        public Highscores()
        {
            this.scores = new List<Score>(Size);
        }

        public List<Score> Scores
        {
            get
            {
                return this.scores;
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

        public void Add(Score score)
        {
            this.Scores.Add(score);
            this.Scores.Sort((x, y) => x.CompareTo(y));

            if (this.Scores.Count > Size)
            {
                this.Scores.RemoveAt(this.Scores.Count - 1);
            }
        }

        public void DrawHighscores()
        {
            Console.WriteLine(this.ToString());
        }

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
    }
}