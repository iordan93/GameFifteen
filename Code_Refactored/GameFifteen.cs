namespace GameFifteen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GameFifteen
    {
        // Like Settings...
        private const int GameFieldRows = 4;
        private const int GameFieldColumns = 4;

        public static string[,] GenerateGameField()
        {
            string[,] gameField = new string[GameFieldRows, GameFieldColumns];

            do
            {
                Position blankPosition = findPrazno(gameField);

                if (blankPosition != null)
                {
                    gameField[blankPosition.Row, blankPosition.Column] = "0";
                }

                FillOutGameField(gameField);
            }
            while (!IsSolvable(gameField));

            return gameField;
        }

        private static void FillOutGameField(string[,] gameField)
        {
            Random rand = new Random();
            List<int> usedNumbers = new List<int>();
            bool isPositionFilled = false;

            gameField[rand.Next(GameFieldRows), rand.Next(GameFieldColumns)] = " ";

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    isPositionFilled = false;

                    do
                    {
                        int number = rand.Next(1, 16);

                        if (gameField[i, j] == " ")
                        {
                            isPositionFilled = true;
                        }
                        else
                        {
                            if (!usedNumbers.Contains(number))
                            {
                                gameField[i, j] = number.ToString();
                                isPositionFilled = true;
                                usedNumbers.Add(number);
                            }
                        }
                    }
                    while (isPositionFilled == false);
                }
            }
        }

        // TODO: Place a comment about this method with reference!
        // http://www.cs.bham.ac.uk/~mdr/teaching/modules04/java2/TilesSolvability.html
        private static bool IsSolvable(string[,] gameField)
        {
            int[] numbersInOneRow = new int[gameField.Length];
            int index = 0;
            Position blankPosition = null;

            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    if (gameField[i, j] == " ")
                    {
                        numbersInOneRow[index] = 0;
                        blankPosition = new Position(i, j);
                    }
                    else
                    {
                        numbersInOneRow[index] = int.Parse(gameField[i, j]);
                    }

                    index++;
                }
            }

            int numberOfInversions = 0;

            for (int i = 0; i < numbersInOneRow.Length; i++)
            {
                int number = numbersInOneRow[i];

                if (number > 1)
                {
                    for (int n = i + 1; n < numbersInOneRow.Length; n++)
                    {
                        if (numbersInOneRow[n] < number)
                        {
                            numberOfInversions++;
                        }
                    }
                }
            }

            bool isFieldWidthEven = gameField.GetLength(1) % 2 == 0;
            bool isNumberOfInversionsEven = numberOfInversions % 2 == 0;
            bool isBlankOnOddRowFromBottom =
                (gameField.GetLength(0) - 1 - blankPosition.Row) % 2 == 0;

            bool isSolvable = ((!isFieldWidthEven) && isNumberOfInversionsEven) ||
                (isFieldWidthEven && (isBlankOnOddRowFromBottom == isNumberOfInversionsEven));

            return isSolvable;
        }

        private static void Drawmatrica(string[,] matrica)
        {
            Console.WriteLine("  - - - - - -");

            // TODO: Fix the "magic" number!
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // TODO: Can this be done without so many checks every cycle/loop?
                    if (j == 0)
                    {
                        Console.Write("| {0,2} ", matrica[i, j]);
                    }
                    else if (j == 3)
                    {
                        Console.WriteLine("{0,2} |", matrica[i, j]);
                    }
                    else
                    {
                        Console.Write("{0,2} ", matrica[i, j]);
                    }
                }
            }

            Console.WriteLine("  - - - - - -");
        }

        private static bool proverka(string[,] matrica)
        {
            int counter = 1;
            // TODO: Fix the "magic" number!
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrica[i, j] != counter.ToString())
                    {
                        if (counter == 16 && matrica[i, j] == " ")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    counter++;
                }
            }

            return true;


        }

        private static Position findPrazno(string[,] matrica)
        {
            Position result = null;
            // TODO: Fix the "magic number"!
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrica[i, j] == " ")
                    {
                        result = new Position(i, j);
                    }
                }
            }

            return result;
        }

        private static void ChangeAndDraw(string[,] matrica, int rowToChange, int columnToChange, int row, int column, string input)
        {
            // TODO: Spaghetti :P
            matrica[rowToChange, columnToChange] = input;
            matrica[row, column] = " ";
            Drawmatrica(matrica);
        }

        private static Position FindCurrentElement(string[,] matrica, string input)
        {
            // TODO: Fix "magic" number!
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrica[i, j] == input)
                    {
                        return new Position(i, j);
                    }
                }
            }
            Console.WriteLine("Cheat ! Illegal command ! !");
            return null;
        }

        static void Main(string[] args)
        {
            // TODO: Scenario:
            // Create scoreboard. Print welcome msg. (Create game field. Check if solvable.) Wait for user command until "exit" (switch). "restart" -> go back to print msg?
            // "top" -> show scoreboard if any records. "exit" -> print bye, exit loop. DEFAULT: Is INPUT number? Is number in range? -> Illegal number! Is number able to be moved?
            // -> Illegal move! Illegal command! | If game finished (puzzle solved) -> scoreboard.method...
            string[,] gameField = GameFifteen.GenerateGameField();
            int moves = 0;
            // TODO: Extract to method the welcome message? And with const?
            Console.WriteLine("Welcome to the game \"15\". Please try to arrange the numbers " +
                "sequentially .\nUse 'top' to view the top scoreboard, 'restart' to start a new " +
                "game and 'exit' \nto quit the game.\n\n\n");

            Drawmatrica(gameField);
            #region YD
            while (!proverka(gameField))
            {
                Console.Write("Enter a number to move : ");
                string вход = Console.ReadLine();
                bool празно = false;


                int rowEmptySpace = findPrazno(gameField).Row;
                int columnEmptySpace = findPrazno(gameField).Column;

                if (вход == "exit")
                {
                    // TODO: Not implemented!
                    Console.WriteLine("Good bye !");
                }

                if (вход == "restart")
                {
                    Console.WriteLine("Here is your new matrica, have a good play : \n\n\n");
                    gameField = GameFifteen.GenerateGameField();
                    Drawmatrica(gameField);
                    moves = 0;
                    continue;
                }

                if (вход == "top")
                {
                    // TODO: Draw if records are presented. Extract method. In class.
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Name : {0} , moves : {1} ", TopScores.igrachi[i], TopScores.hodove[i]);
                    }
                    continue;

                }

                if (FindCurrentElement(gameField, вход) == null)
                {
                    continue;
                }

                int rowCurrentElement = FindCurrentElement(gameField, вход).Row;
                int columnCurrentElement = FindCurrentElement(gameField, вход).Column;




                // TODO: Magic, magic, magic... Method?
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        if (rowCurrentElement - 1 < 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (gameField[rowCurrentElement - 1, columnCurrentElement] == " ")
                            {
                                ChangeAndDraw(gameField, rowCurrentElement - 1, columnCurrentElement, rowCurrentElement, columnCurrentElement, вход);
                                празно = true;
                                moves++;
                            }
                        }
                    }
                    if (i == 1)
                    {
                        if (rowCurrentElement + 1 > 3)
                        {
                            continue;
                        }
                        else
                        {
                            if (gameField[rowCurrentElement + 1, columnCurrentElement] == " ")
                            {
                                ChangeAndDraw(gameField, rowCurrentElement + 1, columnCurrentElement, rowCurrentElement, columnCurrentElement, вход);
                                празно = true;
                                moves++;
                            }
                        }
                    }
                    if (i == 2)
                    {
                        if (columnCurrentElement - 1 < 0)
                        {
                            continue;
                        }
                        else
                        {
                            if (gameField[rowCurrentElement, columnCurrentElement - 1] == " ")
                            {
                                ChangeAndDraw(gameField, rowCurrentElement, columnCurrentElement - 1, rowCurrentElement, columnCurrentElement, вход);
                                празно = true;
                                moves++;
                            }
                        }
                    }
                    if (i == 3)
                    {//tuka ne sym siguren kakvo e tova ama raboti!


                        if (columnCurrentElement + 1 > 3)
                        {


                            continue;
                        }


                        else
                        {

                            if (gameField[rowCurrentElement, columnCurrentElement + 1] == " ")
                            {

                                ChangeAndDraw(gameField, rowCurrentElement, columnCurrentElement + 1, rowCurrentElement, columnCurrentElement, вход);
                                празно = true;
                                moves++;

                            }

                        }

                    }

                }

                if (!празно)
                {

                    Console.WriteLine("Cheat ! Illegal command ! !");
                }

            }
            #endregion

            Console.WriteLine("Your result is {0} moves !", moves);
            // TODO: Extract method. In class. Fix bug! (moves = 0)
            for (int i = 0; i < 5; i++)
            {
                if (TopScores.hodove[i] > moves)
                {
                    Console.WriteLine("Congratulations, you have just putted a new record");
                    Console.Write("Please enter your name : ");

                    TopScores.hodove[i] = moves;

                    TopScores.igrachi[i] = Console.ReadLine();
                }
            }

            // TODO: A new game doesn't start automatically!
        }
    }
}








