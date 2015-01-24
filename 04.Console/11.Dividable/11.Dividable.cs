using System;
/*Problem 11.	* Numbers in Interval Dividable by Given Number
Write a program that reads two positive integer numbers and prints how many numbers p exist
 * between them such that the reminder of the division by 5 is 0. */
class Program
{
    static void Main()
    {
        int start = 3;
        int end = 4;
        bool printed = false;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0} ", i);
                printed = true;
            }
        }
        if (!printed)
        {
            Console.WriteLine("- :D");
        }
        Console.WriteLine();
    }
}

