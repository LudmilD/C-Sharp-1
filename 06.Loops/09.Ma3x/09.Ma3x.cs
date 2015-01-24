using System;
/*Problem 9.	Matrix of Numbers
Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints
 * a matrix like in the examples below. Use two nested loops. */
class Program
{
    static void Main()
    {
        string str;
        int n = 4;
        bool isInt;
        int startValue = 0;
        int row = 0;
        int col;
        //do
        //{
        //    Console.WriteLine("(1 <= n <= 20)");
        //    isInt = (int.TryParse(str = Console.ReadLine(), out n));
        //}
        //while (!((isInt) && (1 <= n) && (n <= 20)));
        int[,] m3x = new int[n, n];
        for ( row = 0; row < n; row++)
        {
            startValue=row+1;
            for (col = 0; col < n; col++)
            {
                m3x[row,col] = startValue;
                startValue++;
                // we can print as we asign right here Console.WriteLine(startValue)
                // and add Console.WriteLine() for next row out side the inner loop
            }
            //Console.WriteLine()
        }
        // print m3x
        for (row = 0; row < n; row++)
        {
            for (col = 0; col < n; col++)
            {
                Console.Write(string.Format((m3x[row,col]).ToString()).PadLeft(3));
            }
            Console.WriteLine();
        }




    }
}

