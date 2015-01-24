using System;
/*Problem 5.	Third Digit is 7?
Write an expression that checks for given integer if its third digit from right-to-left is 7
*/
class Program
{
    static void Main()
    {
        int[] value = new int [] {5,701,9703,877,777877,9999799};
        bool tirdd = false;
        int number = 0;
        Console.WriteLine("Number     Is Third 7");
        foreach (var item in value)
        {
            number = item / 100;
            if (number % 10 == 7)
            {
                tirdd = true;
            }
            else
            {
                tirdd = false;
            }
            Console.WriteLine(" {0}        {1}",item,tirdd); 
        }
    }
}

