using System;


namespace AngryBits
{
    class AngryBits
    {
        static void Main()
        {
            int n=8;
            int rowN = n;
            int colN = n * 2;
            int[,] bits = new int[rowN, colN];
            for (int row = 0; row < rowN; row++)
            {//declarations
                int number = int.Parse(Console.ReadLine());// we will input 8 numbers == n==rowN
                for (int col = 0; col < colN; col++)
                {                   
                    bits[row, col] = (number >> col) & 1;
                }
            }
            //fing a birth to lounch
            int countFlight = 0;
            int countPigHit = 0;
            //biths shoot at pigs
            for (int col = 8; col < colN; col++)
            {//births start from 8 collom
                for (int row = 0; row < n; row++)
                {//iterate inside each collom
                    if (bits[row, col] == 1) 
                    {//starts to fly
                        bits[row, col] = 0; // set the bit to zero 
                        int rowFly=row;
                        int colFly=col;
                        bool hitTop = (rowFly != 0);//> 0 becouse inside valu 0 will be reached

                        bool hitBottom = (rowFly < n-1);
                        bool hitOUT = colFly < 0;
                        
                        bool isPigArea = (colFly <= 7 && colFly >= 0);
                        bool pigHit = (bits[rowFly, colFly] == 1);

                        bool birdsHitPig=false;
                        while (hitTop && !birdsHitPig)//fly upward 
                        { //coordinates set
                            rowFly--;
                            colFly--;
                            countFlight++;
                            //condition section
                            hitTop = (rowFly != 0);
                            pigHit = hitBottom && hitOUT && (bits[rowFly, colFly] == 1);
                            isPigArea =  (colFly <= 7 && colFly >= 0);
                            //check condition
                            if (isPigArea && pigHit)
                            {
                                bits[rowFly, colFly] = 0;//remove pig from the field;
                                countPigHit++;
                                birdsHitPig = true; break;
                            }
                        }
                        hitBottom = (rowFly < n - 1);//didn;t updated ...
                        while (hitBottom && !hitOUT && !birdsHitPig)//fly downWard
                        {//and check coordinates
                            rowFly++;
                            colFly--;
                            countFlight++;
                            //condition section
                            hitBottom = (rowFly <= n - 1);
                            hitOUT = colFly <= 0;
                            isPigArea = hitBottom && hitOUT && (colFly <= 7 && colFly >= 0);
                            pigHit = hitBottom && hitOUT && (bits[rowFly, colFly] == 1);
                            //check condition
                            if (isPigArea && pigHit)
                            {
                                bits[rowFly, colFly] = 0;//remove pig from the field;
                                countPigHit++;
                                birdsHitPig = true; break;
                            }
                        }
                    }
                }
            }
            //check if pigs left
            bool pigsLeft = false;
            for (int row = 0; row < n && !pigsLeft; row++)
            {
                for (int col = n-1; col >= 0; col--)
                {
                    if (bits[row, col] == 1)
                    {
                        pigsLeft = true;
                        break;
                    }
                }
            }
            int result = countPigHit * countFlight;
            if (!pigsLeft)
            {
                Console.WriteLine(result+" Yes");
            }
            else
            {
                Console.WriteLine(result+" No");  
            }
        }
    }
}
