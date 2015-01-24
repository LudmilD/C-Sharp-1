using System;
/*Problem 11.	* Number as Words
Write a program that converts a number in the range [0…999] to words,
 * corresponding to the English pronunciation. */
// NOTE doesn't start with capital Letter !!!
// methods would be f up
//reusable code
//NOTE Two hundredS s-missed in the example 
class Program
{
    static void Main()
    {
        int number = 501;
        int once = 0;
        int tens = 0;
        int hundreds = 0;
        once = number % 10;
        number /= 10;
        tens = number % 10;
        number /= 10;
        hundreds = number % 10;
        

        if (hundreds == 0 && tens == 0 && once >= 0) // o-9
        {
            if (once == 0)
            {
                Console.WriteLine("zero");
            }
            else
            {
                Once(once);
                Console.WriteLine();
            }
        }
        else 
        if (hundreds == 0 && tens == 1 && once >= 0) // 10-19
        {
            Teens(once);
            Console.WriteLine();
        }
        else if (hundreds == 0 && (tens > 1 || once >= 0)) // tens 20 -90
        {
            TwentyNinty(tens);
            Once(once);
            Console.WriteLine();
        }
        else 
        if (hundreds > 0 && (tens >= 0 || once >= 0)) // tens 100 -900
        {
            if (hundreds == 1)
            {
                Console.Write("a hundred ");
                AddAndAfterhundreds(once, tens);                                                                
            }                                                                          
            else if (hundreds > 1)
            {
                Once(hundreds);
                Console.Write(" hundreds ");
                AddAndAfterhundreds(once, tens); 
            }
            Console.WriteLine();
        }
    }

    private static void AddAndAfterhundreds(int once, int tens)
    {
        if (tens == 0 && once != 0)
        {
            Console.Write(" and ");
            Once(once);
            Console.WriteLine();
        }
        else if (tens == 1)
        {
            if (once == 0)
            {
                Console.Write(" and ");
                Teens(once);
                Console.WriteLine();
            }
            else if (once > 0)
            {
                Teens(once);
                Console.WriteLine();
            }
        }
        else if (tens > 1 && once != 0)
        {
            TwentyNinty(tens);
            Once(once);
            Console.WriteLine();
        }
        else if (tens > 1 && once == 0)
        {
            Console.Write(" and ");
            TwentyNinty(tens);
        }
    }

    private static void TwentyNinty(int tens)
    {
        switch (tens)
        {
            //case 0: Console.Write("ten");
            //    break;
            //case 1: Console.Write("eleven");
            //    break;
            case 2: Console.Write("twenty");
                break;
            case 3: Console.Write("thirty");
                break;
            case 4: Console.Write("fourtey");
                break;
            case 5: Console.Write("fifty");
                break;
            case 6: Console.Write("sixty");
                break;
            case 7: Console.Write("seventy");
                break;
            case 8: Console.Write("eighty");
                break;
            case 9: Console.Write("ninty");
                break;
            default:
                Console.Write("");
                break;
        }
    }
    private static void Teens(int once)
    {
        switch (once)
        {
            case 0: Console.Write("ten");
                break;
            case 1: Console.Write("eleven");
                break;
            case 2: Console.Write("twelve");
                break;
            case 3: Console.Write("thirteen");
                break;
            case 4: Console.Write("fourteen");
                break;
            case 5: Console.Write("fifteen");
                break;
            case 6: Console.Write("sixteen");
                break;
            case 7: Console.Write("seventeen");
                break;
            case 8: Console.Write("eighteen");
                break;
            case 9: Console.Write("ninteen");
                break;
            default:
                break;
        }
    }
    private static void Once(int once)
    {
        switch (once)
        {
            case 0: Console.Write("");
                break;
            case 1: Console.Write("one");
                break;
            case 2: Console.Write("two");
                break;
            case 3: Console.Write("tree");
                break;
            case 4: Console.Write("four");
                break;
            case 5: Console.Write("five");
                break;
            case 6: Console.Write("six");
                break;
            case 7: Console.Write("seven");
                break;
            case 8: Console.Write("eight");
                break;
            case 9: Console.Write("nine");
                break;
            default:
                break;
        }
    }
}

