using System;
//http://bgcoder.com/Contest/Practice/80
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2012-2013 - C Sharp 1 Intermediate\Exam 1 at 28 Dec 2012
class Program
{
    static void Main()
    {
        int fieldLenght = 8;
        int[,] matrix = new int[fieldLenght, fieldLenght];
        // int number = new int();
        for (int i = 0; i < fieldLenght; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < fieldLenght; j++)
            {
                int bit = (number >> j) & 1;
                if (bit == 1)
                {
                    matrix[i, j] = 1;
                }
            }
        }

        for (int i = 0; i < fieldLenght; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < fieldLenght; j++)
            {
                int bit = (number >> j) & 1;
                if (bit == 1)
                {
                    //matrix[i, j] = 1;
                    if (matrix[i, j] == 1)
                    {// proverka za sywpadenie na bitowe 
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = 2;
                    }
                }
            }
        }
        int counter1 = 0;
        int counter2 = 0;
        for (int col = 0; col < fieldLenght; col++)
        {
            for (int row = 0; row < fieldLenght; row++)
            {
                if (matrix[row, col] == 1)
                {
                    break;
                }
                else if (matrix[row, col] == 2)
                {
                    counter2++;
                    break;
                }
            }
        }
        for (int col = 0; col < fieldLenght; col++)
        {
            for (int row = fieldLenght - 1; row >= 0; row--)
            {
                if (matrix[row, col] == 1)
                {
                    counter1++;
                    break;
                }
                else if (matrix[row, col] == 2)
                {
                    //  counter2++;
                    break;
                }
            }
        }
        Console.WriteLine("{0}:{1}", counter1, counter2);


    }
}

