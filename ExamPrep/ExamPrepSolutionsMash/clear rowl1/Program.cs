using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == j)
                {
                    Console.Write('*');
                }
                else
                    Console.Write('.');
            }
            Console.WriteLine();
        }
        for (int j = n-1 ; j >= 1; j--)
        {
            for (int i = 1; i <= n; i++)
            {
                if (j == i)
                {
                    Console.Write('*');
                }
                else Console.Write('.');
            }
            Console.WriteLine();
        }
        //for (int i = n - 1; i >= 1; i--)
        //{
        //    for (int j = 1; j <= n; j++)
        //    {
        //        if (i == j) Console.Write('*');                
        //        else Console.Write('.');
        //    }
        //    Console.WriteLine();
        //}
    }
}

