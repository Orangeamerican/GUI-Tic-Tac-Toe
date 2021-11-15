using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITicTacToe
{
    public class BoardChecker : IChecker
    {
        public double xWins = 0, oWins = 0, numGames = 0, xAvg = 0, oAvg = 0;
        public string[] word = Enumerable.Repeat("", 9).ToArray();
        //adds x and o and will allow them to be checked
        public void Accumulate(int i, string s)
        {
            word[i] = s;
        }
        //clears everything including record
        public void Clear()
        {
            for (int i = 0; i < 9; i++)
                word[i] = "";

        }
        //if x wins add it to count
        public bool Xwin()
        {
            for (int j = 0; j < 7; j++)
            {
                if (word[j] == "X")
                {
                    switch (j)
                    {
                        //checks every possible case
                        case 0:
                            if ((word[j + 1] == "X" && word[j + 2] == "X") || (word[j + 3] == "X" && word[j + 6] == "X") || (word[j + 4] == "X" && word[j + 8] == "X"))
                            {
                                xWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;

                        case 1:
                            if (word[j + 3] == "X" && word[j + 6] == "X")
                            {
                                xWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;
                        case 2:
                            if ((word[j + 3] == "X" && word[j + 6] == "X") || (word[j + 2] == "X" && word[j + 4] == "X"))
                            {
                                xWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;
                        case 3:
                            if (word[j + 1] == "X" && word[j + 2] == "X")
                            {
                                xWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;
                        case 6:
                            if (word[j + 1] == "X" && word[j + 2] == "X")
                            {
                                xWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;
                    }
                }
            }
            return false;
        }
        //if o wins
        public bool Owin()
        {
            for (int j = 0; j < 7; j++)
            {
                if (word[j] == "O")
                {
                    switch (j)
                    {
                        //checks if o wins or not
                        case 0:
                            if ((word[j + 1] == "O" && word[j + 2] == "O") || (word[j + 3] == "O" && word[j + 6] == "O") || (word[j + 4] == "O" && word[j + 8] == "O"))
                            {
                                oWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;

                        case 1:
                            if (word[j + 3] == "O" && word[j + 6] == "O")
                            {
                                oWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;
                        case 2:
                            if ((word[j + 3] == "O" && word[j + 6] == "O") || (word[j + 2] == "O" && word[j + 4] == "O"))
                            {
                                oWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;
                        case 3:
                            if (word[j + 1] == "O" && word[j + 2] == "O")
                            {
                                oWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;
                        case 6:
                            if (word[j + 1] == "O" && word[j + 2] == "O")
                            {
                                oWins++;
                                numGames++;
                                xAvg = xWins / numGames;
                                oAvg = oWins / numGames;
                                return true;
                            }
                            break;
                    }
                }
            }
            return false;
        }
        //checks for a tie
        public bool Tie()
        {
            for (int j = 0; j < 9; j++)
            {
                if (word[j] == "")
                    return false;
            }
            if (!Owin() && !Xwin())
            {
                numGames++;
                return true;
            }
            else
                return false;
        }
    }
}