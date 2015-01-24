using System;
/*Problem 1.	Odd or Even Integers
Write an expression that checks if given integer is odd or even
*/
class Program
{
    static void Main()
    {
        int[] values = new[] { 3, 2, -2, -1, 0 };
        bool oddEven = false;
        for (int i = 0; i <= values.Length; i++)
        {
            if (values[i] % 2 == 0 && values[i] != 0)
            {
                oddEven = false;
                Console.WriteLine(oddEven);
            }
            else if (values[i] == 0)
            {
                Console.WriteLine("zero is not Even needer Odd");
                oddEven = false;
                Console.WriteLine(oddEven);
            }
            else if (values[i] % 2 != 0)
            {
                oddEven = true;
                Console.WriteLine(oddEven);
            }
        }
    }
}

