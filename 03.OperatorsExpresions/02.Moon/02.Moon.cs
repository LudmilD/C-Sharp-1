using System;

class Program
{
    static void Main()
    {
        decimal[] myWeight = new[] { 75, 86, 74.6m, 53.7m };
        decimal moonGravity = 0.17m;
        decimal result;
        foreach (var item in myWeight)
        {
            result = item * moonGravity;
            Console.WriteLine("{0:###.##}kg",result);
        }

    }
}

