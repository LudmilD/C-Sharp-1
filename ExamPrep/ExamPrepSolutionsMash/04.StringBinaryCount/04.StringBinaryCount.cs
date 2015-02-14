using System;

class Program
{
    static void Main()
    {

        //wywevdase 0 ili 1
        int b = int.Parse(Console.ReadLine());
        long n = int.Parse(Console.ReadLine());
        long currentNumberBitCheck;
        int bitCounterFor1 = 0;
        int bitCounterFor0 = 0;

        // inicializirane na masiw w string fomrat

        string[] numbersToCheck = new string[n];

        for (int i = 0; i < numbersToCheck.Length; i++)
        {   //wywejdane na masiwa

            numbersToCheck[i] = Console.ReadLine();
        }
        // obhojdane na stringa [] el. po element

        for (int i = 0; i < numbersToCheck.Length; i++)
        {
            currentNumberBitCheck = long.Parse(numbersToCheck[i]);
            foreach (char '0' in (string)currentNumberBitCheck)
            {
                binaryStringBuilder.Append(Convert.ToString(b, 2));
            }
            Console.WriteLine(binaryStringBuilder.ToString());
        }


    }
}

