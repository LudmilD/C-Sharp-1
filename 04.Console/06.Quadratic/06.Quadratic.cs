using System;
/*Problem 6.	Quadratic Equation
Write a program that reads the coefficients a, b and c of a quadratic equation
 * ax2 + bx + c = 0 and solves it (prints its real roots). */
class Program
{
    static void Main()
    {
        double a =  -1;
        double b = -10;
        double c = -1;
        double x1;
        double x2;
        double x;
        double D = 0;
        if (a == 0)
        {
            Console.WriteLine("linear equation , not qyadratic");
            x = -c / b;
            Console.WriteLine("x= {0}",x);
            // NAN  i minus bezkrajnost :D
        }
        //else if (b < 0 && c < 0)// nqkyde go 4etoh ama maj se reshawa po dr nachin 
        //{
        //    Console.WriteLine("No Solution");
        //}
        else
        {
            D = (b * b) - (4 * a * c);
            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.Write("x1 = {0}; ", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if (D < 0)
            {
                Console.WriteLine("no real roots D < 0");
            }
            else if (D == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine("D = 0 and =>  x1=x2= {0}", x);
            }
        }

    }
}

