using System;
using System.Numerics;
/*Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
Write a program that, for a given two integer numbers n and x, calculates the sum 
  * S= 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. Print the result with 5 digits 
 * after the decimal point*/
class Program
{
    static void Main()
    {
        //string strNum;
        //BigInteger
        decimal xSumSqr = 1;
       // BigInteger
        decimal nSumFact = 1;
       // BigInteger 
        decimal Sum = 1;
        int n = 2;
        int x = 2;
        int j = 1;
        //Console.WriteLine("Calculate 1 + 1!/X + 2!/X2 + … + N!/XN");
        //do
        //{
        //    Console.Write("Please, enter an unsigned integer number n: ");
        //    Console.Write("Please, enter an integer number x, not equal to 0: ");
        //}
        //while ((!(int.TryParse(strNum = Console.ReadLine(), out x)) || x == 0)
        //    && (!int.TryParse(strNum = Console.ReadLine(), out n)));
        if (n == 1)
        {
            Sum += 1;
        }
        else
        {// 
            for (int i = 1; i <= n; i++)
            {
                nSumFact = 1;
                for ( j = 1; j <= i; j++)
                {
                    nSumFact *= j;                    
                }
                xSumSqr = (decimal)Math.Pow(x, i);
                Sum += nSumFact / xSumSqr;
            }
        }
        Console.WriteLine("{0:F10}",Sum);
        /*
        ##1
        double expression = 1;
        for (int i = 1; i <= n; i++)
        {
            nSumFact = (nSumFact * i) / xSumSqr;
            Sum += nSumFact; //Sum += (nSumFact * i) / xSumSq
        }
         ##2
          for (int i = 1; i <= n; i++)
        {
            nSumFact *= i;
            xSumSqr *= x;
            Sum += nSumFact / xSumSqr;   
        }*/
    }
}

