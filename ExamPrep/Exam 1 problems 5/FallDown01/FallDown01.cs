using System;

class Program
{
    static void Main()
    {
        int n = 8;
        char[,] grid = new char[n, n];
        char[,] ordered = new char[n, n];
        char[] line = new char[n];
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            line = Convert.ToString(numbers[i], 2).PadLeft(n, '0').ToCharArray();
            for (int j = 0; j < n; j++)
            {
                grid[i, j] = line[j];
            }
        }
        // PrintM3x(n, grid);

        int strartRow = 0;
        for (int row = n - 1; row >= 1; row--)// access last el in  rowFor
        {
            for (int col = n - 1; col >= 0; col--)
            {
                strartRow = row;
                if (grid[row, col] == '0')// current element
                {
                    for (int rowFor = row - 1; rowFor >= 0; rowFor--)
                    {
                        if (grid[rowFor, col] == '0')
                        {
                            continue;
                        }
                        else if (grid[rowFor, col] == '1')
                        {
                            grid[strartRow, col] = '1';
                            grid[rowFor, col] = '0';// clear if found
                            strartRow--;
                            //  PrintM3x(n, grid);
                        }
                    }
                }
                else if (grid[row, col] == '1')
                {
                    continue;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                line[j] = grid[i, j];
            }
            string str = new string(line);
            int numb = Convert.ToInt32(str, 2);
            Console.WriteLine(numb);
        }
    }
    private static void PrintM3x(int n, char[,] grid)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(grid[i, j]);
            }
            Console.WriteLine();

        }
        Console.WriteLine();
        Console.WriteLine();
    }
}