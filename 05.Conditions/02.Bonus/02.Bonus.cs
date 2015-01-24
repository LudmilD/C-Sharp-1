using System;
/*Write a program that applies bonus score to given score in the range [1…9] by the following rules:
•	If the score is between 1 and 3, the program multiplies it by 10.
•	If the score is between 4 and 6, the program multiplies it by 100.
•	If the score is between 7 and 9, the program multiplies it by 1000.
•	If the score is 0 or more than 9, the program prints “invalid score”.
*/
class Program
{
    static void Main()
    {
        string scoreStr = "1";//console.readline();
        scoreStr = scoreStr.Trim();
        int scoreInt = 0;
        switch (scoreStr)
        {
            case "1":
            case "2":
            case "3":
                scoreInt = int.Parse(scoreStr);
                scoreInt *= 3;
                Console.WriteLine(scoreInt);
                break;
            case "4":
            case "5":
            case "6":
                scoreInt = int.Parse(scoreStr);
                scoreInt *= 100;
                Console.WriteLine(scoreInt);
                break;
            case "7":
            case "8":
            case "9":
                scoreInt = int.Parse(scoreStr);
                scoreInt *= 1000;
                Console.WriteLine(scoreInt);
                break;
            default:
                Console.WriteLine("invalid score");
                break;
        }
    }
}

