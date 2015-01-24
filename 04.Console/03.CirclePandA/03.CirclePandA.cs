using System;
/*Problem 3.	Circle Perimeter and Area
Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point
*/
class Program
{
    static void Main()
    {
        double r = 5.5;
        double A = Math.PI * Math.Pow(r, 2);
        double P = 2 * Math.PI * r;
        Console.WriteLine("r={0} Area = {1:F2} Perimeter={2:F2}",r,A,P);


    }
}

