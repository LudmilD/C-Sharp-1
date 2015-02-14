using System;


namespace Lines
{
    class Lines
    {
        static void Main()
        {
            int[,] arr = new int[8, 8];
            //input each number as consequens of bits in INT[,] 
            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    arr[row, col] = (number >> col) & 1;
                }
            }
            int countMaxLines = 0;
            int maxLineLEN = 0;
            int counLinesHorLEN = 0;

            for (int row = 0; row < 8; row++)
            {// check HORZONTAL lines
                counLinesHorLEN = 0;// if first line start with 1 it produce bug so again Grounding for new coll
                for (int col = 0; col < 8; col++)
                {
                    if (arr[row, col] == 1)
                    {// check current 
                        counLinesHorLEN++;
                        if (col + 1 < 8 && arr[row, col + 1] == 1)//check next
                        {//col + 1 < 8 check whether c +1 will go out of range when shecking for arr[row, col + 1] == 1
                            counLinesHorLEN++;
                            col++;
                        }
                    }
                    else if (arr[row, col] == 0)
                    {
                        counLinesHorLEN = 0;
                    }

                    //check line lenght and count if more lines with same size appear
                    if (counLinesHorLEN > maxLineLEN)
                    {
                        countMaxLines = 0;
                        maxLineLEN = counLinesHorLEN;
                        countMaxLines++;
                    }
                    else if (counLinesHorLEN == maxLineLEN && maxLineLEN != 0)
                    {
                        countMaxLines++;
                    }
                }
            }

            int countLineVerLEN = 0;
            for (int col = 0; col < 8; col++)
            {//chesk VERTICAL lines
                countLineVerLEN = 0;// new row start with 0 lent
                for (int row = 0; row < 8; row++)
                {
                    if (arr[row, col] == 1)
                    { //check current
                        countLineVerLEN++;
                        if (row + 1 < 8 && arr[row + 1, col] == 1)
                        {//check next in context of current; row + 1 < 8 protect for out of rance exception
                            countLineVerLEN++;
                            row++;
                        }
                    }
                    else if (arr[row,col ] == 0)//changed row<->col place cost 3 tests fails n3 n4 and n6
                    {//they were misplased becouse general algorithm changed place between col row in for loop
                        countLineVerLEN = 0;
                    }

                    //check line lenght and count if more lines with same size appear
                    if (countLineVerLEN > maxLineLEN)
                    {
                        countMaxLines = 0;
                        countMaxLines++;
                        maxLineLEN = countLineVerLEN;

                    }
                    else if (countLineVerLEN == maxLineLEN && maxLineLEN != 0)
                    {
                        countMaxLines++;
                    }
                }
            }

            if (maxLineLEN == 1)
            {//check if duplicated specially for line with len = 1
                countMaxLines = countMaxLines / 2;
            }
            Console.WriteLine(maxLineLEN);
            Console.WriteLine(countMaxLines);
        }
    }
}
