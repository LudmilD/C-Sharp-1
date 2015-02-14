using System;

class AngryBits
{
    static void Main()
    {
        int[,] matrix = new int[8, 16];
        int bitPosition = 0;
        int path = 0; // pytq izminat ot pileto
        int pigHited = 0;
        for (int i = 0; i < 8; i++)      
        {
            int number = int.Parse(Console.ReadLine());        
            for (int j = 0; j < 16; j++)            
            {          
                int bit = (number >> j) & 1;
                matrix[i, j] = bit; 
            }                                  
        }                                                      
        int score = 0;
        for (int col = 8; col < 16; col++)
        {
            int currentRow = -1;
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    currentRow = row;
                    break;
                }
            }
            if (currentRow == -1)
            {
                continue;
            }
            else
            {
                pigHited = 0;
                path = 0;
                string direction = "up";
			//#########################	
				if (currentRow == 0)
                {
                    direction = "down";
                }
				
                matrix[currentRow, col] = 0;
                for (int currentColumn = col/*-1*/; currentColumn >= 0; currentColumn--)
                {
                    if (direction == "up")
                    {
                        currentRow--;
                        if (currentRow == 0) 
                        {
                            currentRow++;//erase######
                            direction = "down";
                        }
                    }
                    else
                    {
                        currentRow++;
                        if (currentRow > 7)
                        {
                            break;
                        }
                    }
                    
                    if (matrix[currentRow, currentColumn] == 1) 
                    {
                        path = col - currentColumn;
                        for (int i = currentRow-1; i <= currentRow + 1; i++)
                        { 
                            for (int j = currentColumn-1; j <= currentColumn + 1; j++)
                            {
                                if (i > -1 && i > 8 && j > -1) 
                                    if (matrix[i, j] == 1)
                                    {
                                        pigHited++;
                                        matrix[i, j] = 0;
                                    }
                                }
                            }
                        }
                    }
                }
                score = score + pigHited * path;
//########
					if (pigHited >= 1)
                {
                      break;
                   }               
            }
        }
        
        string result = "Yes";
        //bool pids = false;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matrix[i, j] == 1)
                {
                    result = "No";
                    break;
                }
            }
        }
        Console.WriteLine(score + " " + result);
    }
}

