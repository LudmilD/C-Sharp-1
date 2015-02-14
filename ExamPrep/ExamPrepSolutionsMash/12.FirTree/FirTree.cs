using System;
using System.Linq;

class Firtree
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        //static string firstLine;
        string lastLine;
        int halfLines = lines / 2;
        
        int left= lines -1;
        
        int right = lines - 1;

        for (int i = 1; i < lines; i++)
        {
            //string firstLine;

            Console.Write(new string('.', left - i));// left part dots
            //Console.Write("#");//tree comulational efect
            Console.Write(new string('*', i));//tree first iter just 1 ->2
            Console.Write(new string('*', i - 1));// first iter 0 -1> 
            Console.Write(new string('.', right - i));
            Console.WriteLine();            
        }
        Console.Write(new string('.', left - 1));// left part dots
        Console.Write(new string('*',1));//tree first iter just 1 ->2       
        Console.Write(new string('.', right - 1));
        Console.WriteLine();
    }
}
