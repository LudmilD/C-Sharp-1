using System;


namespace FormulaBit1
{
    class FormulaBis1
    {
        static void Main()
        {
            int n = 8;
            int[,] arr = new int[n, n];
            for (int row = 0; row < n; row++)
            {
                int input = int.Parse(Console.ReadLine());
                for (int col = 0; col < n; col++)
                {
                    arr[row, col] = (input >> col) & 1;
                }
            }
            int countRoad = 0;
            int countTrun = 0;
            string direction = "down";
            string previous = "left";
            //save coordinates and start from there
            int curCol = 0;
            int curRow = 0;

            //check start if readu [0,0]!=1
            bool isEnd = false;
            //down [0,0] ->[N-1,0];
            while (!(direction == "STOP"))
            {
                if (direction == "down")
                {
                    for (int row = curRow; row <= n; row++)
                    {
                        curRow = row;
                        bool inM3XandZer0 = curRow < n && arr[curRow, curCol] == 0;//row!=n-1 check if outside m3x
                        bool inM3XandONE1orEndM3x = curRow == n || (curRow < n && arr[curRow, curCol] == 1);
                       // bool isEnd = curCol == n - 1 && curRow == n - 1;                       
                        if (inM3XandZer0 && !isEnd)
                        {
                            countRoad++;                           
                            if (curCol == n - 1 && curRow == n - 1) // check for end                            
                            {
                                isEnd = true;
                                direction = "STOP"; break;
                            }
                        }                        
                        else if (inM3XandONE1orEndM3x)//check insidem3x next is 1 
                        {
                            bool leftInM3x = curCol + 1 < n;//TODO check if lef inside m3x 
                            bool leftIs0 = curRow != 0 && leftInM3x && arr[curRow - 1, curCol + 1] != 1;//leftInM3x proteck for exception 
                            // added check for the case [0,0]= 1  curRow != 0
                            bool checkLeft = leftInM3x && leftIs0;
                            if (checkLeft)//inside m3x and left is 0
                            {
                                countTrun++; curRow--; curCol++; // set coordinates and turn
                                direction = "left";
                                previous = "down";
                                break;//ok
                            }//change direction   ##set coordinates                         
                            else { direction = "STOP"; break; }//##TODO left is 1 there for stop
                        }
                    }
                }
                //left
                if (direction == "left")
                {
                    for (int col = curCol; col <= n; col++)
                    {
                        curCol = col;
                        bool inM3XandZer0 = curCol < n && arr[curRow, curCol] == 0;
                        bool inM3XandONE1orEndM3x = (curCol == n) || (curCol < n && arr[curRow, curCol] == 1);
                        // bool isEnd = curCol == n - 1 && curRow == n - 1;
                        if (inM3XandZer0 && !isEnd)
                        {
                            countRoad++;
                            if (curCol == n - 1 && curRow == n - 1) // check for end                            
                            {
                                isEnd = true;
                                direction = "STOP"; break;
                            }
                        }
                        //bool inSideM3X = curCol < n;                    
                        else if (inM3XandONE1orEndM3x)
                        {
                            //countTrun++;//change direction   ##                     
                            curCol--;//set coordinates 1/2 make previousposition current IMPORTANT
                            bool isUpInM3XandZer0 = curRow - 1 >= 0 && arr[curRow - 1, curCol] == 0;
                            bool isDownInM3XandZer0 = curRow + 1 < n && arr[curRow + 1, curCol] == 0;
                            if (previous == "down" && isUpInM3XandZer0)
                            {
                                countTrun++;
                                curRow--;//set coordinates 1/2
                                previous = "left";
                                direction = "up"; break;
                            }
                            else if (previous == "up" && isDownInM3XandZer0)
                            {
                                countTrun++;
                                curRow++;//set coordinates 1/2
                                previous = "left";
                                direction = "down"; break;
                            }
                            else { direction = "STOP"; break; }//impossable turn}
                        }
                    }
                }
                //up
                if (direction == "up")
                {
                    for (int row = curRow; row >= -1; row--)
                    {
                        curRow = row;
                        bool inM3XandZer0 = curRow >= 0 && arr[curRow, curCol] == 0;//row!=n-1 check if outside m3x
                        bool inM3XandONE1orEndM3x = (curRow == -1) || (curRow >= 0 && arr[curRow, curCol] == 1);
                        //  bool isEnd = curCol == n - 1 && curRow == n - 1;
                        if (inM3XandZer0)
                        {
                            countRoad++;
                        }
                        //else if (isEnd)
                        //{//there is no chance to end movin upward
                        //    direction = "STOP"; break; 
                        //}
                        else if (inM3XandONE1orEndM3x)
                        {
                            bool leftInM3x = curCol + 1 < n;//TODO check if lef inside m3x 
                            bool leftIs0 = leftInM3x && arr[curRow + 1, curCol + 1] != 1;//leftInM3x proteck for exception 
                            bool checkLeft = leftInM3x && leftIs0;
                            if (checkLeft)//inside m3x and left is 0
                            {
                                countTrun++; curRow++; curCol++; // set coordinates and turn
                                direction = "left";
                                previous = "up";
                                break;//ok
                            }
                            else { direction = "STOP"; break; }
                        }
                    }
                }//up end
            }//while end
            //  bool isEnd3 = (curCol == n - 1 && curRow == n - 1);
            if (direction == "STOP" || isEnd)
            {
                if (isEnd)//condition for end of road
                {
                    Console.WriteLine(countRoad + " " + countTrun);
                }
                else//condition for no road
                {
                    Console.WriteLine("No" + " " + countRoad);
                }
            }            

        }
    }
}
