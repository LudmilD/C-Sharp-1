using System;
/*Write a program that safely compares floating-point numbers with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal 
 * if they are more closely to each other than a fixed constant eps. */
class Program
{
    static void Main()
    {
        double eps = 0.000001;// precition
        double //a = 5.3;
        //a=5.00000001;
        //a=-0.0000007;
        a=-4.999999;
        
        double// b = 6.01;
        //b=5.00000003;
        //b=0.00000007;
        b=-4.999998;
        double difference = a - b;
        difference = Math.Abs(difference);// if result is minus and desult is border like -0.000001 it will give true :D
        bool ternar = true;
        if (difference < eps)
        {
            Console.WriteLine("true");
        }
        else if (difference >= eps)
        {
            Console.WriteLine("false");
            ternar = false;
        }
        Console.WriteLine(ternar ? (ternar) : (ternar));// write the valie
        Console.WriteLine(ternar ? "true" : "false");// write "true" if ternar = true
    }
}

