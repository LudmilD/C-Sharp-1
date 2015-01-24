using System;
/*Problem 5.	The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers. 
*/
class Program
{
    static void Main()
    {
        decimal a=-0.1m;
        decimal b=-0.5m;
        decimal c=-1.2m;
        decimal biggest;
        biggest=a;
        if (biggest<b)
        {
            biggest = b;
        }
        if (biggest < c)
        {
            biggest = c;
        }
        Console.WriteLine(biggest);
    }
}

