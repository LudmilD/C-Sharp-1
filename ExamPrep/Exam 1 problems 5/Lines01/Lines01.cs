using System;

class Program
{
    static void Main()
    {
        int n = 8;
        char[,] grid = new char[n, n];
        char[] line = new char[n];
        for (int row = 0; row < n; row++)
        {
            int num = int.Parse(Console.ReadLine());
            line = Convert.ToString(num, 2).PadLeft(n, '0').ToCharArray();
            for (int col = 0; col < n; col++)
            {
                grid[row, col] = line[col];
            }
        }
        //printM3x(n, grid);
        int lineLen = 0;
        int lineLenBest = 0;

        int longestCount = 0;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)// vertival scan up->down
            {// n-1 becouse explore the last line
                if (grid[row, col] == '1')
                {
                    lineLen++;
                    bool isEndLine = (row == n - 1 || grid[row + 1, col] == '0');

                    if (lineLenBest < lineLen && isEndLine)
                    {//enter when counting finish
                        lineLenBest = lineLen;
                        longestCount = 0;
                        longestCount++;// zeroes befo adding! 
                        lineLen = 0;//zeros the counter if line ends, zeroes after best.
                    }
                    else if (lineLen == lineLenBest && isEndLine)
                    {
                        longestCount++;
                        lineLen = 0;//zeros the counter if line ends
                    }
                    else if (lineLenBest > lineLen && isEndLine)
                    {// restart count if line ends.
                        lineLen = 0;
                    }
                }
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)// horizontal scan
            {
                if (grid[row, col] == '1')
                {// change just col+1
                    lineLen++;
                    bool isEndLine = (col == n - 1 || grid[row, col + 1] == '0');
                    if (lineLenBest < lineLen && isEndLine)
                    {//enter when counting finish
                        lineLenBest = lineLen;
                        longestCount = 0;
                        longestCount++;// zeroes befo adding! 
                        lineLen = 0;//zeros the counter if line ends, zeroes after best.
                    }
                    else if (lineLen == lineLenBest && isEndLine)
                    {//col+1
                        longestCount++;
                        lineLen = 0;//zeros the counter if line ends
                    }
                    else if (lineLenBest > lineLen && isEndLine)
                    {// restart count if line ends.
                        lineLen = 0;
                    }
                }
            }
        }
        if (lineLenBest == 1)
        {
            longestCount = longestCount / 2;
        }
        Console.WriteLine(lineLenBest);
        Console.WriteLine(longestCount);
    }
    private static void printM3x(int n, char[,] grid)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(grid[row, col]);
            }
            Console.WriteLine();
        }
    }
}

