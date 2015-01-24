using System;
/*Problem 10.	Fibonacci Numbers
Write a program that reads a number n and prints on the console the first n members
 * of the Fibonacci sequence (at a single line, separated by spaces) * :
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
 * Note that you may need to learn how to use loops.
*/
// negative and positive fibonachi
class Program
{
    static void Main()
    {
        int members = -10; // 
        int a = 0;
        int b = 1;
        int sum = 0;

        PositiveNegativeFibonachi(members, ref a, ref b, ref sum);
    }

    private static void PositiveNegativeFibonachi(int members, ref int a, ref int b, ref int sum)
    {
        if (members == 0)
        {
            Console.WriteLine("nothing we display");
        }
        else if (members == 1)
        {
            Console.WriteLine(a);
        }
        else if (members == 2)
        {
            Console.WriteLine("{0} {1}", a, b);
        }
        else if(members > 2)
        {
            for (int i = 0; i < members - 2; i++)
            {
                FibonachiLogic(ref a, ref b, ref sum, i);
            }
        }
        if (members == -1)
        {
            Console.WriteLine("{0}",a);
        }
        else if (members == -2)
        {
            Console.WriteLine("{0} {1}", a, -b);
        }
        else if (members < -2)
        {
            b  *= -1;// dif
            for (int i = 0; i > members + 2; i--)// dif
            {
                FibonachiLogic(ref a, ref b, ref sum, i);
            }
        }
    }

    private static void FibonachiLogic(ref int a, ref int b, ref int sum, int i)
    {
        if (i == 0) Console.Write("{0} {1} ", a, b); // if without brakets
        sum += a + b;
        a = b;
        b = sum;
        Console.Write("{0} ", sum);
        sum = 0;
    }
}

