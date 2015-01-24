using System;
/*Write a program that enters a number n and after that enters
 * more n numbers and calculates and prints their sum. Note that you may need to use a for-loop*/
class Program
{
    static void Main()
    {
        int n = 3;
        decimal sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("enter consequent number [{0}]",i);
            sum += decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine("sum = {0}",sum);
    }
}

