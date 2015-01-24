using System;
/*Problem 15.	* Bits Exchange
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 
manuwal change number and specific bit changeBitA[0]<->changeBitB in number[0]*/
class Program
{
    static void Main()
    {
        uint[] numbers = new uint[] { 1140867093, 255406592, 4294901775, 5351, 2369124121 };
        uint[] changeBitA = new uint[] { 3, 4, 5 }; // bit position
        uint[] changeBitB = new uint[] { 24, 25, 26 };
        //##exchange
        ExchangeBits(numbers, changeBitA, changeBitB);


    }

    private static void ExchangeBits(uint[] numbers, uint[] changeBitA, uint[] changeBitB)
    {
        int counter = 0;
        uint tempNumber = 0;
        uint number = 0;
        uint newNumber = 0;
        while (numbers.Length > counter)
        {
            tempNumber = numbers[counter];//wzima pyrwoto chislo // promenq se wyw wseki if i e promeneniq nymber
            newNumber = numbers[counter];
            number = numbers[counter];//postoqnen do kraq na iteraciqta
            for (uint i = 0; i < changeBitA.Length; i++)
            {
                uint bitValueA = GetBitValueFROMnumberINposition(number, changeBitA, i);// stoinost na bitA 3 
                uint bitValueB = GetBitValueFROMnumberINposition(number, changeBitB, i); // stoinost na bitB 24
                uint tempBit = bitValueA; bitValueA = bitValueB; bitValueB = tempBit; // 3<->24 razmenqt stoinostitesi

                // razmqna na bitowete w 4isloto
                if (bitValueA == 1)//bitA 3 ove4e e sys valu na bitB 24
                {
                    tempNumber = newNumber;
                    tempNumber = SetToValue1(changeBitA, tempNumber, i);
                    newNumber = tempNumber;
                }
                else if (bitValueA == 0)
                {
                    tempNumber = newNumber;
                    tempNumber = SetToValue0(changeBitA, tempNumber, i);
                    newNumber = tempNumber;
                }

                if (bitValueB == 1)//bitA 3 ove4e e sys valu na bitB 24
                {
                    tempNumber = newNumber;
                    tempNumber = SetToValue1(changeBitB, tempNumber, i);
                    newNumber = tempNumber;
                }
                else if (bitValueB == 0)
                {
                    tempNumber = newNumber;
                    tempNumber = SetToValue0(changeBitB, tempNumber, i);
                    newNumber = tempNumber;
                }
            }
            Console.WriteLine(tempNumber);
            counter++;
        }
    }
    //static int ExchangeBits(int bitValueA, int changeBitB, )
    //{

    //}

    static uint GetBitValueFROMnumberINposition(uint number, uint[] bitPosition, uint i)
    {
        uint extraxt = number;
        uint mask = 1;
        mask = mask << (int)(bitPosition[i]); //vij praviloto po dolu
        extraxt = extraxt & mask;
        extraxt = extraxt >> (int)(bitPosition[i]);//vij praviloto po dolu
        uint bit = extraxt; // 0001 or 0000 = 1 or 0;
        return bit;
    }

    static uint SetToValue0(uint[] bitPosition, uint numbers, uint i)// set to 0
    {
        int p = (int)bitPosition[i];
        uint n = numbers;
        uint mask = ~(1u << p);     //vij praviloto po dolu
        uint result = n & mask;
        return result;
    }

    static uint SetToValue1(uint[] bitPosition, uint numbers, uint j)// set to 1
    {
        int p = (int)bitPosition[j];
        uint n = numbers;
        uint mask = 1u << p;  //vij praviloto po dolu        
        uint result = n | mask;
        return result;
    }
    /*int x << int bits
 uint x << int bits
 long x << int bits
 ulong x << int bits*/
}

