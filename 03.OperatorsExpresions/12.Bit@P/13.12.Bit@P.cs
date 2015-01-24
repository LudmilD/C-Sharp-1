using System;
/*Problem 13.	Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given 
 * integer number n has value of 1.  */
class Program
{
    static void Main()
    {
        int[] bitPosition =new int[] {2,9,1,7,11};
        int[] number = new int[] { 5, 0, 15, 5343, 62241 };
        Console.WriteLine("n     Binary Representation  bit Position bit==1" );
        for (int i = 0; i < number.Length; i++)
        {
            string numberToBinary = Convert.ToString(number[i], 2);
            numberToBinary = (numberToBinary.PadLeft(16, '0'));// full representation in binary with all zeros
          
            int bitVal = GetBitFROMnumberINposition(number, bitPosition, i); // get bit walue as a single integer number 1 or 0
            
            bool bit1 = Convert.ToBoolean(bitVal);// convert to bool becouse value is 0 or 1 false or true
            
            Console.Write(string.Format("{0,-6} {1,16}      {2,-2}   {3,-2}      {4,-5}",
                number[i], numberToBinary, bitVal,bitPosition[i],bit1));
            Console.WriteLine();
        }
    }
    // use F11 t odebug methods
    static int GetBitFROMnumberINposition(int[] number, int[] bitPosition, int i)
    {
        int extraxt = number[i];
        int mask = 1;
        mask = mask << bitPosition[i];
        extraxt = extraxt & mask;
        extraxt = extraxt >> bitPosition[i];
        int bit = extraxt; // 0001 or 0000 = 1 or 0;
        return bit;
    }
}

