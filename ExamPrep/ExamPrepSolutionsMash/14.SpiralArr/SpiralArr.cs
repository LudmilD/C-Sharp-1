using System;
//1 2 3
//8 9 4
//7 6 5
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] spiral = new int[N, N];
        string direction = "right";
        int currentRow = 0;
        int currentCol = 0;
        for (int i = 1; i <= 100; i++)
        {
            // conditions to  change directions               V - smanq posokata ako we4e e popylneno
            if (direction == "right" && (currentCol >= N || spiral[currentRow, currentCol] != 0))
            {
                currentCol--; //1 zada ne izlizame ot masiwa toi izliza i se wryshta i                 
                currentRow++;//2 prezapiswa vyrhu 10 pishe 11 ako ne napisheme sledwahtoto
                direction = "down";
            }
            else if (direction == "down" && (currentRow >= N || spiral[currentRow, currentCol] != 0))
            {
                currentRow--;//
                currentCol--;
                direction = "left";
            }
            else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol++;
                direction = "up";
            }
            else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow++;
                direction = "right";
            }
            spiral[currentRow, currentCol] = i;
            //directions
            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }
        //print arr
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(spiral[i, j] + "  ");

            }
            Console.WriteLine();
        }

    }
}

