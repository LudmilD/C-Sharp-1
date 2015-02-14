using System;
class Program
{
    static void Main()
    {
        bool[,] track = new bool[8, 8];
        for (int i = 0; i < 8; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                track[i, j] = ((currentNumber >> j) & 1) != 0;
            }
        }
        int row = 0;
        int col = 0;
        string direction = "down";
        string lastDirection = "down";
        int pathCount = 0;
        int directionCount = 0;
        bool exitFound = false;
        while (true)
        {
            if (track[row, col])
            {// ne e nameren izhod, ot wlizaneto wednaha izliza zashtoto e 1
                break;
            }
            pathCount++;// slaga se predi za da otbeleji poslednata kletka predi exit
            if (row == 7 && col == 7)
            {
                exitFound = true;
                break;
            }
            if (direction == "down" && (row + 1 > 7 || track[row + 1, col]))
            {// (row +1>7) da ne izlia ot maiwa nadolu, track[row+1,col] poneje masiwa e bulev ne se nalaga da pravime proverka track[row+1,col]=1 ili 0 1 treu 0  false
                direction = "left";
                lastDirection = "down";
                directionCount++;
                if (col + 1 > 7 || track[row, col + 1])
                {// prowerqwa e dali nqma swobodni kletki naokolo i dali ne izlia ot masiwa
                    break;
                }
            }
            else if (direction == "up" && (row - 1 < 0 || track[row - 1, col]))//beshe greshno track[row + 1, col]
            {
                direction = "left";
                lastDirection = "up";
                directionCount++;
                if (col + 1 > 7 || track[row, col + 1])
                {
                    break;
                }
            }
            else if (direction == "left" && lastDirection == "down" && (col + 1 > 7 || track[row, col + 1]))
            {
                direction = "up";
                directionCount++;
                if (row - 1 < 0 || track[row - 1, col])
                {
                    break;
                }
            }
            else if (direction == "left" && lastDirection == "up" && (col + 1 > 7 || track[row, col + 1]))
            {
                direction = "down";
                directionCount++;
                if (row + 1 > 7 || track[row + 1, col])   //(row + 1 < 0 || track[row - 1, col]) was mistaken track[row - 1, col])
                {
                    break;
                }
            }
            if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {// indeksite w masiwa sa na obratno poradi na4inan a popylwane na bitowa matrica
                col++;
            }
            else if (direction == "up")
            {
                row--;
            }
        }
        if (exitFound)
        {
            Console.WriteLine(pathCount + " " + directionCount);
        }
        else
        {
            Console.WriteLine("No " + pathCount);
        }
    }
}

