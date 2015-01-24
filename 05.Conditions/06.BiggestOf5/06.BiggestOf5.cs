using System;
/*Problem 6.	The Biggest of Five Numbers
Write a program that finds the biggest of five numbers by using only five if statements. 
*/
class Program
{
    static void Main()
    {
        decimal a = 0.0006m;
        decimal b = -0.005m;
        decimal c = -1.2m;
        decimal d = -0.05m;
        decimal e = -1.2m;

        decimal biggest;
        biggest = a;
        if (biggest < b)
        {
            biggest = b;
        }
        if (biggest < c)
        {
            biggest = c;
        }
        if (biggest < d)
        {
            biggest = d;
        }
        if (biggest < e)
        {
            biggest = e;
        }
        Console.WriteLine(biggest);
    }
}

