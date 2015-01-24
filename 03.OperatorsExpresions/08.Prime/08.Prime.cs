using System;
/*Problem 8.	Prime Number Check
Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). 
*/
class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 9, 97, 51, -3, 0 };
        Console.WriteLine("Number Prime");
        for (int i = 0; i < numbers.Length; i++)
        {
            bool isPrime = ((numbers[i] % 2 != 0) && (numbers[i] % 3 != 0) && (numbers[i] % 5 != 0) && (numbers[i] % 7 != 0) && (numbers[i] != 1));
            bool isCoPrime2357 = ((numbers[i] == 2) || (numbers[i] == 3) || (numbers[i] == 5) || (numbers[i] == 7));
            bool prime = (isPrime || isCoPrime2357);
            Console.WriteLine(string.Format("{0,6} {1,-7}",numbers[i],prime));
        }



    }
}

