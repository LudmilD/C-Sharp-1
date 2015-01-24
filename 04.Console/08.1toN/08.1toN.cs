using System;
/*Problem 8.	Numbers from 1 to n
Write a program that reads an integer number  n from the console and prints all the numbers
 * in the interval [1..n], each on a single line. Note that you may need to use a for-loop. */
class Program
{
    static void Main()
    {
        int n = 5;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

