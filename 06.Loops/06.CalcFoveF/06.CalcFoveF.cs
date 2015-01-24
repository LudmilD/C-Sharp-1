using System;
using System.Numerics;
/*Problem 6.	Calculate N! / K!
Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop. 
// N=7 k = 5   5!/5! = 1  (n-(k+1))=2 no ne e 2! 
 */
class Program
{
    static void Main()
    {
        string strInput;
        int n = 4;
        int k = 2;
        //do
        //{
        //    Console.WriteLine("k and n are integers");
        //    Console.WriteLine("1 < k < n < 100");

        //} while (!((int.TryParse(strInput=Console.ReadLine(),out k))
        //    && (int.TryParse(strInput=Console.ReadLine(),out n))
        //    && ((1 < k)&& (k < n) && (n < 100))));
        int factorialStart = k + 1;
        int factorialEnd = n;
        decimal factorialNoverK = 1;
        for (int i = factorialStart; i <= factorialEnd; i++)
        {
            factorialNoverK *= i;
        }
        Console.WriteLine(factorialNoverK);

    }
}

