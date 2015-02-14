//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2011-2012 - C Sharp 1 Intermediate\test Exam
//http://www.youtube.com/watch?v=dwfui_5_BOQ
//http://bgcoder.com/Contest/Practice/7
using System;
class OddNumber
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long result = long.Parse(Console.ReadLine());


        for (int i = 1; i < n; i++)
        {
            result ^= long.Parse(Console.ReadLine());
        }
        Console.WriteLine(result);
    }
}

