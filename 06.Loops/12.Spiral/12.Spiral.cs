using System;
/*Problem 12.	** Spiral Matrix
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
 * and prints a matrix holding the numbers from 1 to n*n in the form of square spiral
 * like in  the examples below. */
class Program
{
    static void Main()
    {
        int n = 15;
        int[,] mattrix = new int[n, n];
        string direction = "right";
        int col = 0;
        int row = 0;
        int value = 1;
        while (value != n * n + 1)
        {
            while (direction == "right")
            {// first check if in boundery second if it is used if curren is codrinate is used
                if (col > n - 1 || mattrix[row, col] != 0)
                {
                    col--;// set true position for down start element
                    direction = "down";
                    row++;// set right position for down start element
                }
                else
                {// set matrix value 
                    mattrix[row, col] = value;
                    value++;
                    col++;//move up
                }
            }
            while (direction == "down")
            {
                if (row > n - 1 || mattrix[row, col] != 0)
                {
                    direction = "left";
                    row--;
                    col--;
                }
                else
                {
                    mattrix[row, col] = value;
                    value++;
                    row++;
                }
            }
            while (direction == "left")
            {
                if (col < 0 || mattrix[row, col] != 0)
                {
                    col++;
                    direction = "up";
                    row--;
                }
                else
                {
                    mattrix[row, col] = value;
                    value++;
                    col--;
                }
            }
            while (direction == "up")
            {
                if (row < 0 || mattrix[row, col] != 0)
                {
                    direction = "right";
                    col++;
                    row++;
                }
                else
                {
                    mattrix[row, col] = value;
                    value++;
                    row--;
                }
            }
        }
        for (int rowp = 0; rowp < n; rowp++)
        {
            for (int colp = 0; colp < n; colp++)
            {
                Console.Write(string.Format("{0}",mattrix[rowp,colp].ToString()).PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}


