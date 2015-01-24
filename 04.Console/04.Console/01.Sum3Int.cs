using System;
/*Problem 1.	Sum of 3 Integers Write a program that reads 3 integer numbers from the console and prints their sum. */
class Program
{
    static void Main()
    {
        Print3Num();
    }

    private static void Print3Num()
    {
        decimal sum = 0;
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine("enter nymber {0}", i);
            sum = sum + decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine("sum is {0}", sum);
    }
}

