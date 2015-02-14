using System;


namespace BitBall
{
    class BitBall
    {
        static void Main()
        {
            int n = 8;
            int[,] arrT = new int[n, n];//move down position players
            int[,] arrB = new int[n, n];//nove up position players
            int countT = 0;
            int countB = 0;          

            for (int row = 0; row < n; row++)
            {// fill out first team
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < n; col++)
                {
                    arrT[row, col] = (number >> col) & 1;
                }
            }
            for (int row = 0; row < n; row++)
            {// fill out second team
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < n; col++)
                {
                    arrB[row, col] = (number >> col) & 1;
                }
            }
            for (int col = 0; col < n; col++)
            {// check if we have B and T on the same spot = 0
                for (int row = 0; row < n; row++)
                {
                    bool Bfound = (arrB[row, col] == 1);
                    bool Tfound = (arrT[row, col] == 1);
                    if (Bfound && Tfound)
                    {
                        arrB[row, col] = 0;
                        arrT[row, col] = 0;
                    }                   
                }
            }         
           
            for (int col = 0; col < n; col++)
            {// check if we have B -> t-defence on their way
                for (int row = 0; row < n; row++)
                {
                    bool Bfound = (arrB[row, col] == 1);
                    bool Tfound = (arrT[row, col] == 1);
                    if (Bfound && !Tfound)
                    {
                        countB++; break;
                    }
                    if (Tfound && !Bfound)
                    {
                        break;
                    }                    
                }
            }            
            for (int col = 0; col < n; col++)
            {//check if we have T -> b-defence on their way
                for (int row= n-1; row>=0; row--)
                {
                    bool Bfound = (arrB[row, col] == 1);
                    bool Tfound = (arrT[row, col] == 1);

                    if (Tfound && !Bfound)
                    {
                        countT++; break;
                    }
                    if (Bfound && !Tfound)
                    {
                        break;
                    }                     
                }
            }
            
            Console.WriteLine("{0}:{1}", countT, countB);
        }
    }
}
