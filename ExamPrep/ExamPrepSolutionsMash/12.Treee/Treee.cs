using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Treee
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int startCount = 3;//1
        int dotCount = n - 2;
        
        string firstLine = new string('.', dotCount)+'*'+  new string('.', dotCount);//
        Console.WriteLine(firstLine); // ili se smenq zakomentiranoto za syshtiq efekt
        dotCount--;//
        for (int i = 1; i < n - 1; i++)//0
        {
            Console.Write(new string('.', dotCount));
            Console.Write(new string('*', startCount));
            Console.Write(new string('.', dotCount));
            Console.WriteLine();
            dotCount--;
            startCount += 2;
        }
        Console.WriteLine(firstLine);
        ////last line
        //startCount = 1;
        //dotCount = n - 2;
        //Console.Write(new string('.', dotCount));
        //Console.Write(new string('*', startCount));
        //Console.Write(new string('.', dotCount));
        //Console.WriteLine();
    }
}

