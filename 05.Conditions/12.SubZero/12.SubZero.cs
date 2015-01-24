using System;
/*Problem 12.	* Zero Subset
We are given 5 integer numbers. Write a program that finds all subsets of these numbers
 * whose sum is 0. Assume that repeating the same subset several times is not a problem. */

class sumSubSet
{
    static void Main()
    {
        //Console.Write("Enter Integer a=");
        int a = 1; //int.Parse(Console.ReadLine());
        //Console.Write("Enter Integer b=");
        int b = 2;//int.Parse(Console.ReadLine());
       // Console.Write("Enter Integer c=");
        int c = -1;//int.Parse(Console.ReadLine());
        //Console.Write("Enter Integer d=");
        int d = -1;//int.Parse(Console.ReadLine());
        //Console.Write("Enter Integer e=");
        int e = -2;//int.Parse(Console.ReadLine());
        int sum = 0;

        // 2 var Check For A ; a,b,c,d,e, each has 4 cheks ##########################################################
        if (a + b == sum)
        {
            Console.WriteLine("these is sub set  a={0}+b={1} = 0", a, b);
        }
        if (a + c == sum)
        {
            Console.WriteLine("these is sub set  a={0} + c={1} = 0", a, c);
        }
        if (a + d == sum)
        {
            Console.WriteLine("these is sub set  a={0} + d={1} = 0", a, d);
        }
        if (a + e == sum)
        {
            Console.WriteLine("these is sub set  a={0} + e={1} = 0", a, e);
        }

        // 2 var Chec For B ; a,b,c,d,e, each has 4 cheks  ##########################################################
        if (b + c == sum)
        {
            Console.WriteLine("these is sub set  b={0} + c={1} = 0", b, c);
        }
        if (b + d == sum)
        {
            Console.WriteLine("these is sub set  b={0} + d={1} = 0", b, d);
        }
        if (b + e == sum)
        {
            Console.WriteLine("these is sub set b={0} + e={1} = 0", b, e);
        }

        // 2 var Chec For C, D, E, ; a,b,c,d,e, each has 4 cheks  ######################################################
        if (c + d == sum)
        {
            Console.WriteLine("these is sub set  c={0} + d={1} = 0", c, d);
        }
        if (c + e == sum)
        {
            Console.WriteLine("these is sub set  c={0} + e={1} = 0", c, e);
        }
        if (d + e == sum)
        {
            Console.WriteLine("these is sub set  d={0} + e={1} = 0", d, e);
        }

        // 3 var A  - 6 checks for each a,b,c,d,e, ##############################################################
        if (a + b + c == sum)
        {
            Console.WriteLine("these is sub set = 0 a={0} + b={1} + c={2}", a, b, c);
        }
        if (a + b + d == sum)
        {
            Console.WriteLine("these is sub set  a={0} + b={1} + d={2} = 0", a, b, d);
        }
        if (a + b + e == sum)
        {
            Console.WriteLine("these is sub set  a={0} + b={1} + e={2} = 0", a, b, e);
        }
        if (a + d + c == sum)
        {
            Console.WriteLine("these is sub set  a={0} + d={1} + c={2} = 0", a, d, c);
        }
        if (a + e + c == sum)
        {
            Console.WriteLine("these is sub set  a={0} + e={1} + c={2} = 0", a, e, c);
        }
        if (a + d + e == sum)
        {
            Console.WriteLine("these is sub set  a={0} + d={1} + e={2} = 0", a, d, e);
        }

        // 3 var B   6 checks for each a,b,c,d,e, others a duplikated ###################### 
        if (b + c + d == sum)
        {
            Console.WriteLine("these is sub set  b={0} + c={1} + d={2} = 0", b, c, d);
        }
        if (b + c + e == sum)
        {
            Console.WriteLine("these is sub set  b={0} + c={1} + e={2} = 0", b, c, e);
        }
        if (b + d + e == sum)
        {
            Console.WriteLine("these is sub set  b={0} + d={1} + e={2} = 0", b, d, e);
        }

        // 3 var C D E   6 checks for each a,b,c,d,e,  others are duplicated###################### 
        if (c + d + e == sum)
        {
            Console.WriteLine("these is sub set  c={0} + d={1} + e={2} = 0", c, d, e);
        }
        // 4 var total 6 checks ######################      
        if (a + b + c + d == sum)
        {
            Console.WriteLine("these is sub set  a={0} + b={1} + c={2} + d={3} = 0", a, b, c, d);
        }
        if (a + b + c + e == sum)
        {
            Console.WriteLine("these is sub set  a={0} + b={1} + c={2} + e={3} = 0", a, b, c, e);
        }
        if (a + b + d + e == sum)
        {
            Console.WriteLine("these is sub set  a={0} + b={1} + d={2} + e={3} = 0", a, b, d, e);
        }
        if (b + c + d + e == sum)
        {
            Console.WriteLine("these is sub set  b={0} + c={1} + d={2} + e={3} = 0", b, c, d, e);
        }
        if (a + c + d + e == sum)
        {
            Console.WriteLine("these is sub set  d={0} + b ={1} + c={2} + e={3} = 0", a, c, d, e);
        }
        //5 var #######
        if (a + b + c + d + e == sum)
        {
            Console.WriteLine("these is sub set  a={0} + b ={1} + c={2} + d={3} e={4} = 0", a, b, c, d, e);
        }
        Console.WriteLine("Total of 25 check need to be made to get this result");
    }
}

