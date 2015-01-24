using System;
/*Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
 * The first and the second sequence of bits may not overlap. */

class Program
{
    static void Main()
    {
        //entry
        uint[] numbers = new uint[] { 3333333333, };//number
        int PAAbitStart = -1;//p //##
        int QBBbitStart = 0;//q
        uint seqyenceKK = 33;//k
        int bitLen32 = 32; // uint 32 , long 64 :)// need for out of range exept
        
        int max = Math.Max(PAAbitStart, QBBbitStart);// need for ovelaping chech
        int min = Math.Min(PAAbitStart, QBBbitStart);
       
        if (PAAbitStart < 0u || PAAbitStart > bitLen32 || QBBbitStart < 0u || QBBbitStart > bitLen32
            || (PAAbitStart + seqyenceKK) > bitLen32 || (QBBbitStart + seqyenceKK) > bitLen32)
        {
            Console.WriteLine("out of range");
        }
        else if ((min + seqyenceKK) > max)
        {
            Console.WriteLine("over lapping");
        }
        else
        {
            buidtArray(numbers, PAAbitStart, QBBbitStart, seqyenceKK);
        }
    }

    private static void buidtArray(uint[] numbers, int PAAbitStart, int QBBbitStart, uint seqyenceKK)
    {
        int[] changeBitA = new int[seqyenceKK];
        int[] changeBitB = new int[seqyenceKK];
        for (int PAA = PAAbitStart, QBB = QBBbitStart, ji = 0;
            PAA < PAAbitStart + seqyenceKK && QBB < QBBbitStart + seqyenceKK && ji < seqyenceKK;
            PAA++, QBB++, ji++)
        {
            changeBitA[ji] = PAA;
            changeBitB[ji] = QBB;
        }


        //##exchange
        ExchangeBits(numbers, changeBitA, changeBitB);
    }

    private static void ExchangeBits(uint[] numbers, int[] changeBitA, int[] changeBitB)
    {
        int counter = 0;
        uint tempNumber = 0;
        int number = 0;
        uint newNumber = 0;
        while (numbers.Length > counter)
        {
            tempNumber = numbers[counter];//wzima pyrwoto chislo // promenq se wyw wseki if i e promeneniq nymber
            newNumber = numbers[counter];
            number = (int)numbers[counter];//postoqnen do kraq na iteraciqta
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


    static uint GetBitValueFROMnumberINposition(int number, int[] bitPosition, uint i)
    {
        uint extraxt = (uint)number;
        uint mask = 1;
        mask = mask << (int)(bitPosition[i]); //vij praviloto po dolu
        extraxt = extraxt & mask;
        extraxt = extraxt >> (int)(bitPosition[i]);//vij praviloto po dolu
        uint bit = extraxt; // 0001 or 0000 = 1 or 0;
        return bit;
    }

    static uint SetToValue0(int[] bitPosition, uint numbers, uint i)// set to 0
    {
        int p = (int)bitPosition[i];
        uint n = numbers;
        uint mask = ~(1u << p);     //vij praviloto po dolu
        uint result = n & mask;
        return result;
    }

    static uint SetToValue1(int[] bitPosition, uint numbers, uint j)// set to 1
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



