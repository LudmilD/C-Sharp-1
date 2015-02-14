using System;
//http://www.youtube.com/watch?v=dwfui_5_BOQ
//http://bgcoder.com/Contest/Practice/79
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2012-2013 - C Sharp 1 Intermediate\Exam 1 at 27 Dec 2012
class SheetsBits
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        // ot a0 do a10 = 11 elementa
        for (int i = 0; i < 11; i++)
        {
            int bitToTake = i;
            int mask = 1 << bitToTake;
            int numberAndMask = input & mask;
            int bashSiBit = numberAndMask >> bitToTake;

            //int bashSiBit = (input & (1 << i)) >> i; // pobitowo 
            //int bit = (input >> i) & 1; // pri masiw ot bitowe 0->1->2
            if (bashSiBit ==0)
            {
                Console.WriteLine("A" + (10-i));
            }

        }
    }
}

