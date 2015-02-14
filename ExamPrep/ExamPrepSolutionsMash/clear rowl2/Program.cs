// /*http://www.youtube.com/watch?v=LVxxoSHS6No&feature=youtube_gdata 
 // http://bgcoder.com/Contest/Practice/131
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


static class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int halfN = n / 2;
        char fire = '#';
        char torchTop = '-';
        char torchLeft = '\\';
        char torchRight = '/';
        char blank = '.';

        for (int i = 1; i <= halfN; i++)
        {
            Console.Write(new string(blank, halfN - i));
            Console.Write(new string(fire, 1));
            Console.Write(new string(blank, i - 1));
            Console.Write(new string(blank, i - 1));
            Console.Write(new string(fire, 1));
            Console.Write(new string(blank, halfN - i));
            Console.WriteLine();
        }
        for (int i = 1; i <= halfN / 2; i++)
        {
            Console.Write(new string(blank, i - 1));
            Console.Write(new string(fire, 1));
            Console.Write(new string(blank, halfN - i));
            Console.Write(new string(blank, halfN - i));
            Console.Write(new string(fire, 1));
            Console.Write(new string(blank, i - 1));

            Console.WriteLine();
        }

        
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write(torchTop);
        //}Console.WriteLine();
        Console.WriteLine(new string(torchTop, n));// ednozna4ni sa

        for (int i = 0; i < halfN; i++)
        {
            Console.Write(new string(blank, i));
            Console.Write(new string(torchLeft, halfN - i));
            Console.Write(new string(torchRight, halfN - i));
            Console.Write(new string(blank, i));
            Console.WriteLine();
        }
    }
}