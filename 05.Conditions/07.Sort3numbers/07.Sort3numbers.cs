using System;
/*Write a program that enters 3 real numbers and prints them sorted in descending order. 
 * Use nested if statements. Don’t use arrays and the built-in sorting functionality. */
class Program
{
    static void Main()
    {
        decimal a = -2.5m;
        decimal b = -2.5m;
        decimal c = 5m;
        decimal biggest;
        decimal smallest;
        decimal midle;

        biggest = a;
        smallest = a;
        midle = a;
        biggest = Biggest(b, c, biggest);
        smallest = Smallest(b, c, smallest);
        midle = Midle(a, b, c, midle);


        Console.WriteLine("{0} {1} {2}", biggest, midle, smallest);

    }
    // first i wrote some methods for biggest and smallest but since no array or other marks are used 
    //i used them as a base and combine them for separate check for b and c else are midle value
    private static decimal Smallest(decimal b, decimal c, decimal smallest)
    {
        if (smallest > b)
        {
            smallest = b;
        }
        if (smallest > c)
        {
            smallest = c;
        }
        return smallest;
    }

    private static decimal Biggest(decimal b, decimal c, decimal biggest)
    {
        if (biggest < b)
        {
            biggest = b;
        }
        if (biggest < c)
        {
            biggest = c;
        }
        //Console.WriteLine(biggest);
        return biggest;
    }
    private static decimal Midle(decimal a, decimal b, decimal c, decimal midle)
    {
        if (a < b)//(!(a > b))
        {
            midle = b;
        }
        if (b > c)//(!(b < c))
        {
            midle = c;
        }
        return midle;
    }
}

