using System;
/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
*/
class Program
{
    static void Main()
    {
        //drop to digit ?!
        string[] numberStr = new string[] { "2011", "3333", "9876" };

        Console.WriteLine(@"NUMBER	sum     reversed   last digit   second and third
                           in front     digits exchanged");

        for (int i = 0; i < numberStr.Length; i++)// wzima chislo
        {
            string num = numberStr[i];
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            //GET DIGIT
            for (int j = 0; j < num.Length; j++)
            {
                switch (j)
                {// towa moje da se razbie i sys to.charArray()...
                    case 0: a = int.Parse(num[j].ToString()); break;
                    case 1: b = int.Parse(num[j].ToString()); break;
                    case 2: c = int.Parse(num[j].ToString()); break;
                    case 3: d = int.Parse(num[j].ToString()); break;
                }
            }
            //PRINT
            //##number
            Console.Write("{0}   ", num);
            //##Calculates the sum
            int sum = a + b + c + d;
            //Console.Write ("{0}+{1}+{2}+{3}={4}      ", a, b, c, d, sum);
            Console.Write(" {0}    ", sum);
            // print reverced
            Console.Write("{0}{1}{2}{3}          ", d, c, b, a);
            // exchange last-first
            Console.Write("{0}{1}{2}{3}          ", d, a, b, c);
            // exchange midle
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}

