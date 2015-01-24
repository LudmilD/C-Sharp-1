using System;
/*Problem 11.	* Trailing Zeroes in N!
Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
 * Your program should work well for very big numbers, e.g. n=100000. 
http://www.purplemath.com/modules/factzero.htm */
class Program
{
    static void Main()
    {
        int n = 9999999;        
        int sumZeros = 0;
        int current = 0;
        for (int i = 5; i < n; i*=5)
        {            
            current = n / i;
            sumZeros += current;
        }
        Console.WriteLine(sumZeros);
    }
}

