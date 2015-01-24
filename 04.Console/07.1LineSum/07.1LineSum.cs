using System;
/*Problem 7.	Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space),
 * calculates and prints their sum. */
class Program
{
    static void Main()
    {
        string numbersStr = //"1 2 3 4 5";
        "1.5 3.14 8.2 -1 0";
        numbersStr = numbersStr.Trim();
        char[] separator = new char[] { ' ', ' ', ',', ',' };// po uslovie samo 1 space , no towa sa primerni razdeliteli
        string[] numberArrStr = numbersStr.Split(separator);// sys Split razdelqme i prawime masiw 
        decimal sum = 0;
        foreach (var item in numberArrStr)
        {
            sum += decimal.Parse(item);
        }
        Console.WriteLine(sum);



    }
}

