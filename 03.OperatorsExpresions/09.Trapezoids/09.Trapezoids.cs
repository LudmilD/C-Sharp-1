using System;
/*Problem 9.	Trapezoids
Write an expression that calculates trapezoid's area by given sides a and b and height h. 
*/
class Program
{
    static void Main()
    {
        double[] a = new double[] { 5, 2, 8.5, 100, 0.222, };
        double[] b = new double[] { 7, 1, 4.3, 200, 0.333 };
        double[] h = new double[] { 12, 33, 2.7, 300, 0.555 };
        Console.WriteLine("a       b       c        area");
        for (int i = 0; i < a.Length; i++)
        {
            double area = 0.5 * (a[i] + b[i]) * h[i];
         Console.WriteLine(string.Format("{0,-8}{1,-8}{2,-8}{3,10}",a[i],b[i],h[i],area));
        }
        

    }
}

