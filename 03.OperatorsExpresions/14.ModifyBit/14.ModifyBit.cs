using System;

class Program
{
    static void Main()
    {
        int[] bitPosition = new int[] { 2, 9, 1, 7, 11 };
        int[] bitValues = new int[] { 0, 1, 1, 0, 0 };
        int[] numbers = new int[] { 5, 0, 15, 5343, 62241 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (bitValues[i] == 1)
            {
                Console.WriteLine(SetToValue1(bitPosition, numbers, i)); ;
            }
            else if (bitValues[i] == 0)
            {
                Console.WriteLine(SetToValue0(bitPosition, numbers, i));
            }
        }
    }

    static int SetToValue0(int[] bitPosition, int[] numbers, int i)// set to 0
    {
        int p = bitPosition[i];
        int n = numbers[i];        // 00000001 00100011
        int mask = ~(1 << p);      // 11111111 11011111 invertirana maska ot 0 
        int result = n & mask;     // 00000001 00000011
        return result;
    }

    static int SetToValue1(int[] bitPosition, int[] numbers, int j)// set to 1
    {
        int p = bitPosition[j];
        int n = numbers[j];         // 00000001 00100011
        int mask = 1 << p;          // 00000000 00010000
        int result = n | mask;      // 00000001 00110011
        return result;
    }

}

