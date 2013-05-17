using System;
using System.Linq;

namespace GameFifteen
{
    /// <summary>
    /// A class containing information about the number of moves and the nickname/name of player who scored.
    /// </summary>
    public class Score : IComparable<Score>
    {
        private int moves;

        /// <summary>
        /// Initializes a new instance of the <see cref="Score" /> class.
        /// </summary>
        /// <param name="moves">The number of moves done by player.</param>
        /// <param name="playerName">The name or nickname of player.</param>
        public Score(int moves, string playerName)
        {
            this.Moves = moves;
            this.PlayerName = playerName;
        }

        /// <summary>
        /// Gets or sets the number of positive moves done.
        /// </summary>
        /// <value>The moves.</value>
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

        /// <summary>
        /// Gets or sets the player name/nickname.
        /// </summary>
        /// <value>The player name.</value>
        public string PlayerName { get; set; }
    
        /// <summary>
        /// Compares scores by moves.
        /// </summary>
        /// <param name="other">The other score object.</param>
        /// <returns>Returns:
        /// -1 when the first score is "smaller" than the second;
        /// 0 when the first score is equal to the second;
        /// 1 when the first score is "bigger" than the second.</returns>
        public int CompareTo(Score other)
        {
            return this.Moves.CompareTo(other.Moves);
        }

        /// <summary>
        /// Casts <see cref="Score"/> to String.
        /// </summary>
        /// <returns>Returns string.</returns>
        public override string ToString()
        {
            string moveOrMovesString = (Moves == 1) ? " move" : " moves";
            string result = PlayerName + " --> " + Moves + moveOrMovesString;

            return result;
        }
    }
}
