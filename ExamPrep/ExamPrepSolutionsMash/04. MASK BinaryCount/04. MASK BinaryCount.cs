using System;

class Program
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        uint n = uint.Parse(Console.ReadLine());
        uint[] numbersN = new uint[n];
        uint currentNumber;
        string currentNumberString;

        for (int i = 0; i < numbersN.Length; i++)
        {
            numbersN[i] = uint.Parse(Console.ReadLine());
        }
        for (int i = 0; i < numbersN.Length; i++)
        {// vzimame tekushto cislo ot masiwa
            currentNumber = numbersN[i];
            // ne trqbwa da se zabrawq pri preminawane w string i predstawqneto mu w 
            //binarna sistema sled chisloto , stepenta t.e. sistemata 2 
            //Convert.ToString(currentNumber,2)
            currentNumberString = Convert.ToString(currentNumber,2);
            //nulirame broqcha za vsqko sledwashto chislo
            int countBit1=0;
            int countBit0=0;
            for (int j = 0; j < currentNumberString.Length; j++)
            {                
                //http://goo.gl/OyY8f
                uint mask = (uint)1 << j;
                uint newMask = currentNumber & mask;
                uint bit = newMask >> j;
                if (bit == 1)
                {
                   countBit1++;
                }
                if (bit == 0)
                {
                    countBit0++;
                }
            }
            if (b == 1)
            {
                Console.WriteLine(countBit1);
            }
            if (b == 0)
            {
                Console.WriteLine(countBit0);
            }
        }

    }
}

