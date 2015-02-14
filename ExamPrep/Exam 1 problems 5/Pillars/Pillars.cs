using System;


namespace Pillars
{
    class Pillars
    {
        static void Main()
        {
            int number=0;
            string binaryStr="";
            

            char [,] binCharArr = new Char[8,8];

            for (int i = 0; i < 8; i++)
            {
                number = int.Parse(Console.ReadLine());// input
                binaryStr = Convert.ToString(number, 2).PadLeft(8,'0');//convert to specifik number
                int posFix = 7;
                for (int j = 0; j < 8; j++)
                {
                    char[] tempChar = binaryStr.ToCharArray();
                    binCharArr[i, posFix - j] = tempChar[j];// posFix-j fix position in the m3x
                }
            }
            int pilPossition = 7;// in order to separate m3x in 2 part its position is 
            //restricted in [7,7] to 7-0 [7,7-0] originaly misunderstood with 6-1 as 
            // we need tyo devide and compare so basicali nonexisting with other is compared
            bool isFound=false;
            while (pilPossition >= 0 && !isFound)
            {
                //check left side
                int counterLeft = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 7; j > pilPossition; j--)//j > pilPossition restrict pillar position 
                    {// no be included
                        if (binCharArr[i, j] == '1')
                        {
                            counterLeft++;
                        }
                    }
                }

                //check right side
                int counterRight = 0;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = pilPossition - 1; j >= 0; j--)//exclude pillar itself pilPossition-1
                    {
                        if (binCharArr[i, j] == '1')
                        {
                            counterRight++;
                        }
                    }
                }

                //output
                /*If a pillar splitting the grid into two vertical sides each holding the same
                 * number of full cells exists, print its column index on the first line and the 
                 * number of full cells in each of the sides. */
                if (counterRight == counterLeft) 
                {
                    Console.WriteLine(pilPossition);
                    Console.WriteLine(counterLeft);
                    isFound = true;
                }
                
                pilPossition--;
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
            

        }
    }
}
