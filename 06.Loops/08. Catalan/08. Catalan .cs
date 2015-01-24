using System;
using System.Numerics;
/*Problem 8.	Catalan Numbers
In combinatorics, the Catalan numbers are calculated by the following formula:  
Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
*/
class Program
{
    static void Main()
    {
        string str;
        int n=15;     
        //do
        //{
        //    Console.WriteLine("(1 < n < 100)");
        //}
        //while (!((int.TryParse(str=Console.ReadLine(),out n)
        //    && (1 < n) && (n <100))));
        Factor(n);
        BigInteger catalan = Factor(2 * n) / (Factor(n + 1) * Factor(n));
        Console.WriteLine(catalan);
    }
    private static BigInteger Factor(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

