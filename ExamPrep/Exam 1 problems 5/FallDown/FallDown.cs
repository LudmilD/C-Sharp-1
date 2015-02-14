using System;


namespace FallDown
{
    class FallDown
    {
        static void Main()
        {

            int[,] arr = new int[8, 8];
            for (int row = 0; row < 8; row++)
            {
                //standart way to declare arr of bits from number
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    arr[row, col] = (number >> col) & 1; // 1&1= 1 ; 
                }
            }
            // // //print out tha tables of bits
            //for (int row = 0; row < 8; row++)
            //{
            //    for (int col = 7; col >= 0; col--)
            //    {
            //        Console.Write(arr[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}
            // Console.WriteLine();

            bool isEmpty = true;
            int emptyRow = 0;
            int emptyCol = 0;
            int fulRow = 0;
            int fulCol = 0;
            for (int row = 7; row >= 0; row--)
            {
                for (int col = 7; col >= 0; col--)//was col >= 1 becouse miss understood looping in vertical
                {
                    if (arr[row, col] == 0)
                    {// find empty slot and save coordinates
                        isEmpty = true;
                        emptyCol = col;
                        emptyRow = row;

                        //vertical search and replace
                        for (int searchCol = emptyRow - 1; searchCol >= 0; searchCol--)
                        {//-1 to start from next position donw -> up direction
                            if (arr[searchCol, col] == 1)//iterate over rows in order to serch in specific collumn col index is dif than column itself
                            {//find occupy slot
                                arr[emptyRow, col] = 1;
                                emptyRow--;//go upper next in colonm
                                arr[searchCol, col] = 0;
                            }
                        }
                    }
                }
            }
            // // //print method
            //for (int row = 0; row < 8; row++)
            //{
            //    for (int col = 7; col >= 0; col--)
            //    {
            //        Console.Write(arr[row, col] + " ");
            //    }
            //    Console.WriteLine();
            //}
            string binNumber = "";
            string current = "";
            int numberToPrint = 0;
            //read row by row and make binary string which convert to int number
            for (int row = 0; row < 8; row++)
            {
                binNumber = "";//zero the nymber cumulator
                for (int col = 7; col >= 0; col--)
                {
                    current = arr[row, col].ToString();//extracht bin digit from array 
                    binNumber = binNumber + current;//add current digit to form binary represented number
                }
                numberToPrint = Convert.ToInt32(binNumber, 2);//convert to int obviously :D
                Console.WriteLine(numberToPrint);
            }
        }
    }
}


