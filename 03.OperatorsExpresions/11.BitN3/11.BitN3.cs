using System;
/*Using bitwise operators, write an expression for finding the value of the bit 
 * #3 of a given unsigned integer.  * The bits are counted * from right to left,
 * starting from bit #0. The result of the expression should be either 1 or 0. */
class Program
{
    static void Main()
    {
        int bitPosition = 3;
        int[] number =new int[]  { 5, 0, 15, 5343, 62241 };
        Console.WriteLine("n     Binary Representation  bit Position {0}",bitPosition);
        for (int i = 0; i < number.Length; i++)
        {
            string numberToBinary = Convert.ToString(number[i],2);
            numberToBinary=(numberToBinary.PadLeft(16,'0'));// full representation in binary with all zeros
            int bitVal = GetBitFROMnumberINposition(number, bitPosition,i); // get bit walue as a single integer number 1 or 0
           
             Console.Write(string.Format("{0,-6} {1,16}      {2,-2}", number[i], numberToBinary, bitVal));
             Console.WriteLine();  
        }
    }
    // use F11 t odebug methods
    static int GetBitFROMnumberINposition(int[] number, int bitPosition, int i)
    {
        int extraxt = number[i];
        int mask = 1;
        mask = mask << bitPosition;
        extraxt = extraxt & mask;
        extraxt = extraxt >> bitPosition;
        int bit = extraxt; // 0001 or 0000 = 1 or 0;
        return bit;
    }
}

