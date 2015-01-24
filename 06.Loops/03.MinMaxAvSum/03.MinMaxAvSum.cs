using System;
/*Problem 3.	Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of n integer numbers and returns
 * the minimal, the maximal number, the sum and the average of all numbers 
 * (displayed with 2 digits after the decimal point). The input starts by the number n
 * (alone in a line) followed by n lines, each holding an integer number. 
 * The output is like in the examples below */
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int//[] { 2,5,1 };
        [n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        decimal min = array[0];
        decimal max = array[0];
        decimal sum = 0;
        decimal average =0;

        for (int i = 0; i < array.Length; i++)
        {
            int temp = array[i];
            if (min >= temp)
            {
                min = temp;
            }
            if (max <= temp)
            {
                max = temp;
            }
            sum += temp;
        }
        average = sum / array.Length;
        Console.WriteLine("min = {0:f2}", min);
        Console.WriteLine("max = {0:f2}", max);
        Console.WriteLine("sum = {0:f2}", sum);
        Console.WriteLine("avg = {0:f2}", average);
    }
}

