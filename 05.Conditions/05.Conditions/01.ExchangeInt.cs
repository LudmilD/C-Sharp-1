using System;
/*Problem 1.	Exchange If GreaterWrite an if-statement that takes two integer variables 
 * a and b and exchanges their values if  * the first one is greater than the second one.
 * As a result print the values a and b, separated by a space. */
class Program
{
    static void Main()
    {
        string aStr = "5.4";
        string bStr = "3.14";
        int aInt = 0;
        int bInt = 0;
        int temp = 0;

        bool AisInt = int.TryParse(aStr, out aInt);
        bool BisInt = int.TryParse(bStr, out bInt);

        if (AisInt && BisInt)
        {
            if (aInt > bInt)
            {
                temp = bInt;
                bInt = aInt;
                aInt = temp;

                Console.WriteLine("{0} {1}",aInt,bInt);
            }
            else
            {
                Console.WriteLine("{0} {1}", aInt, bInt);
            }
        }
        else
        {
            Console.WriteLine("{0} {1}",aStr,bStr);
        }

    }
}

