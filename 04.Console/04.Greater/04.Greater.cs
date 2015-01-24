using System;
/*Problem 4.	Number Comparer
Write a program that gets two numbers from the console and prints the greater of them. 
 * Try to implement this without if statements. 
*/
class Program
{
    static void Main()
    {
        double a = -1.5123421231111111222222;
        double b = -2.5123421231111111222221;
        double greater=0;
        if (a>b)
        {
            greater = a;
            Console.WriteLine("greater={0}",greater);
        }
        else if (a  < b)
        {
            greater = b;
            Console.WriteLine("greater={0}", greater);
        }
        else
        {
            Console.WriteLine("{0}=={1}",a,b);
        }
                
        double max = Math.Max(a, b);
        Console.WriteLine("math max={0}",max);
    }
}

