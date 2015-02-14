using System;
using System.Threading;

class Program
{
    static void Main()
        // if ako polzwame samo proverwa wsi4ki uslowiq pri if else samo neobhodimoto
    {
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int result = 0;
        if ((x > 0) && (y > 0))
        {
            result = 1;
            // Console.WriteLine("1");
        }
        else if (x < 0 && y > 0) // premahnati dopylnitelni skobi mejdu uslowiqta
        {
            result = 2;
            //Console.WriteLine("2");
        }
        else if (x > 0 && y < 0)
        {
            result = 4;
            //Console.WriteLine("4");
        }
        else if (x < 0 && y < 0)
        {
            result = 3;
            // Console.WriteLine("3");
        }
        else if (x == 0 && y == 0)
        {
            result = 0;
            //Console.WriteLine("0");
        }
        else if (x == 0) // syobrazqwame po uslowie x 1234 y = 0 result 6  sledowatelno za x = 0 result = 5
        {
            result = 5;
        }
        else if (y == 0)
        {
            result = 6;
        }
        Console.WriteLine(result);
    }
}

