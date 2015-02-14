using System;
//http://www.youtube.com/watch?v=H-bgOnSBwVQ
//http://bgcoder.com/Contest/Practice/6
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2011-2012 - C Sharp 1 Intermediate\6 Dec 2011 Morning
class Pillars
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];
        //bool [,] matrix = new bool [8,8];
        for (int row = 0; row < 8; row++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {   //matrix[row, col] = (number >> col) & 1=1;
                matrix[row, col] = (number >> col) & 1;
            }
        }
        int pillarIndex = 7;
        int countBitsLeft = 0;
        int countBitsRight = 0;
        bool foundSolition = false;
        while (pillarIndex >= 0)
        {
            countBitsLeft = 0;
            countBitsRight = 0;
            for (int col = 0; col < pillarIndex; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        countBitsLeft++;
                    }
                }
            }
            for (int col = pillarIndex + 1; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        countBitsRight++;
                    }
                }
            }
            if (countBitsRight == countBitsLeft)
            {
                foundSolition = true;
                break; // zashtoot po uslovie se tysi samo naj lqvoto reshenie
            }
            pillarIndex--;
        }
        if (foundSolition)
        {
            Console.WriteLine(pillarIndex);
            Console.WriteLine(countBitsLeft);
        }
        else
        {
            Console.WriteLine("No");
        }



    }
}
