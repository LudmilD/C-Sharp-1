using System;
/*Problem 10.	* Calculate GCD
Write a program that calculates the greatest common divisor (GCD) of
 * given two integers a and b. Use the Euclidean algorithm (find it in Internet). */
/*##### EXAMPLE To compute gcd(48,18), divide 48 by 18 to get a quotient of 2 and a remainder of 12.
 * Then divide 18 by 12 to get a quotient of 1 and a remainder of 6.
 * Then divide 12 by 6 to get a remainder of 0, which means that 6 is the gcd.
 * Note that we ignored the quotient in each step except to notice 
 * when the remainder reached 0, signalling that we had arrived at the answer*/
class Program
{
    static void Main()
    {
        int a = 31;
        int b = 15;
     

        if (b == 0)
        {
            Console.WriteLine(a);
        }
        else if (a == 0)
        {
            Console.WriteLine(b);
        }
        else if (a > b)
        {
            GCD(a, b);
        }
        else if (b > a)
        {
            GCD(b, a);
        }
        else if (a == b)
        {
            Console.WriteLine(a);
        }
    }

    private static void GCD(int a, int b)
    {
        int devided = a;
        int modDiviser = b;
        int remainder = -1;
        while (remainder != 0)
        {
            remainder = devided % modDiviser;
            devided = modDiviser;
            modDiviser = remainder;
        }
        Console.WriteLine(devided);
    }
}

