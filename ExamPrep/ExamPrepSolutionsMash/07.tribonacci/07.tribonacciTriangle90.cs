using System;
using System.Numerics;
//http://bgcoder.com/Contest/Practice/79
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2012-2013 - C Sharp 1 Intermediate\Exam 1 at 27 Dec 2012
class Program
{
    static void Main()
    {
        BigInteger a = BigInteger.Parse(Console.ReadLine());
        BigInteger b = BigInteger.Parse(Console.ReadLine());
        BigInteger c = BigInteger.Parse(Console.ReadLine());
        BigInteger elements = BigInteger.Parse(Console.ReadLine());
        BigInteger elCounter = elements;
        // elements = elements - 3;
        
        BigInteger exchanger;
        BigInteger sum = new BigInteger();

        if (elements == 1)
        {
            Console.WriteLine(a);
        }
        else if (elements == 2)
        {
            Console.WriteLine(a);// bqh go zabrawil i mi dawashe 90
            Console.WriteLine("{0} {1}", b, c);
        }
        if (elements > 2)
        {
            Console.WriteLine(a);
            Console.WriteLine("{0} {1}", b, c);
            for (int i = 2; i < elements; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    sum = a + b + c;
                    a = b;
                    b = c;
                    c = sum;
                    if (j != 0) Console.Write(" " + sum); // problem with spaces 
                    else Console.Write(sum);// first print this and dhten " "+sum
                    // so each new line begins with no spaces
                    sum = 0;                   
                }
                Console.WriteLine();
            }
        }
    }
}

