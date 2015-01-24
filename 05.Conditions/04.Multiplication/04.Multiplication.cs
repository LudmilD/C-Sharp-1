using System;
/*Problem 4.	Multiplication Sign
Write a program that shows the sign (+, - or 0) of the product of three real numbers, 
 * without calculating it. Use a sequence of if operators. */
class Program
{
    static void Main()
    {
        decimal a = -5;// decimal.Parse(Console.Readline());
        decimal b = -1.1m;
        decimal c = 2.2m;
        bool AisPositive = false;
        bool BisPositive = false;
        bool CisPositive = false;
        if (a > 0)
        {
            AisPositive = true;
        }
        if (b > 0)
        {
            BisPositive = true;
        }
        if (c > 0)
        {
            CisPositive = true;
        }
        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }
        else if ((AisPositive && BisPositive && CisPositive)
            || (AisPositive && !BisPositive && !CisPositive)
            || (!AisPositive && BisPositive && !CisPositive)
            || (!AisPositive && !BisPositive && CisPositive))
        {// the check for positiwe is 50% and the other is for 
            //negatiwe that's why we dont use negative check
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }

    }
}

