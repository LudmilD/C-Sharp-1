using System;

class UKflag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotCount = n / 2 - 1;
        for (int row = 0; row < n/2; row++)
        {
            Console.Write(new string ('.',row));
            Console.Write(new string('\\',1));
            Console.Write(new string('.', dotCount));
            Console.Write(new string('|', 1));
            Console.Write(new string('.', dotCount));
            Console.Write(new string('/', 1));
            Console.Write(new string('.', row));
            dotCount--;
            Console.WriteLine();
        }
        Console.Write(new string('-',n/2));
        Console.Write(new string('*',1));
        Console.WriteLine(new string('-', n / 2));
        dotCount = n / 2 - 1;
        for (int row = 0; row < n/2; row++)
        {
            Console.Write(new string ('.',dotCount));
            Console.Write(new string('/',1));
            Console.Write(new string('.', row));
            Console.Write(new string('|', 1));
            Console.Write(new string('.', row));
            Console.Write(new string('\\', 1));
            Console.Write(new string('.', dotCount));
            dotCount--;
            Console.WriteLine();
        }
    }
}

