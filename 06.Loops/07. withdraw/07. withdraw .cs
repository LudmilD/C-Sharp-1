using System;
using System.Numerics;
/*Problem 7.	Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose k different members out of a group of n different
 * elements (also known as the number of combinations) is calculated by the following formula:
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
 * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and 
 * k (1 < k < n < 100). Try to use only two loops. 
 * 
 * ########
 * n! / (k! * (n-k)!) = (n! / k!) *  (1/(n-k)!) == (n! / k!) / (n-k)!
*/
class Program
{
    static void Main()
    {
        string strInput;
        int n = 52;
        int k = 5;
        //do
        //{
        //    Console.WriteLine("k and n are integers");
        //    Console.WriteLine("1 < k < n < 100");

        //} while (!((int.TryParse(strInput=Console.ReadLine(),out k))
        //    && (int.TryParse(strInput=Console.ReadLine(),out n))
        //    && ((1 < k)&& (k < n) && (n < 100))));
        int factorialStart = k + 1;
        int factorialEnd = n;
        BigInteger factorialNoverK = 1;//(n! / k!)
        for (int i = factorialStart; i <= factorialEnd; i++)
        {
            factorialNoverK *= i;
        }
        BigInteger OneOverNminusK = 1; //(1/(n-k)!)
        factorialStart = 1;
        factorialEnd = n - k;
        for (int i = factorialStart; i <= factorialEnd; i++)
        {
            OneOverNminusK *= i;
        }
        OneOverNminusK = OneOverNminusK;
        BigInteger result = factorialNoverK / OneOverNminusK;
        Console.WriteLine(result);

    }
}

