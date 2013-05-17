using System;
using System.Linq;

namespace GameFifteen
{
    public class Score : IComparable<Score>
    {
        private int moves;

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

        public Score(int moves, string playerName)
        {
            this.Moves = moves;
            this.PlayerName = playerName;
        }
    
        public int CompareTo(Score other)
        {
            return this.Moves.CompareTo(other.Moves);
        }

        public override string ToString()
        {
            string moveOrMovesString = (Moves == 1) ? " move" : " moves";
            string result = PlayerName + " --> " + Moves + moveOrMovesString;

            return result;
        }
    }
}
