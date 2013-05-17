namespace GameFifteen
{
    using System;
    using System.Linq;

    public class Score : IComparable<Score>
    {
        private int moves;

        public Score(int moves, string playerName)
        {
            this.Moves = moves;
            this.PlayerName = playerName;
        }

        public int Moves
        {
            get
            {
                return this.moves;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Moves cannot be negative number!");
                }
                else
                {
                    this.moves = value;
                }
            }
        }

        public string PlayerName { get; set; }
    
        public int CompareTo(Score other)
        {
            return this.Moves.CompareTo(other.Moves);
        }

        public override string ToString()
        {
            string moveOrMovesString = (this.Moves == 1) ? " move" : " moves";
            string result = this.PlayerName + " --> " + this.Moves + moveOrMovesString;

            return result;
        }
    }
}
