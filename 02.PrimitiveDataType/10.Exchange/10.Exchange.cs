using System;
/*Problem 10.	Exchange Variable Values
Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. Print the variable values before and after the exchange.
*/
class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int temp = 0;
        Console.WriteLine("a={0} b={1}",a,b);
        // exchange 
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("a={0} b={1}", a, b);
    }
}

