/*http://www.youtube.com/watch?v=LVxxoSHS6No&feature=youtube_gdata 
 http://bgcoder.com/Contest/Practice/131
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


static class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char fire = '#';
        char torchTop = '-';
        char torchLeft = '\\';
        char torchRight = '/';
        char blank = '.';

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(blank);
            }
            Console.WriteLine();
        }
        
        
        for (int i = 0; i < n; i++)
        {
            Console.Write(torchTop);
        }
        Console.WriteLine();
    }
}

