using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int row = 0;
        
        //do sredata vklu4itelno
        while (row <= (2 * n - 1)/2)// n -1
        {
            int col = 0;
            while (col < n)
            {                
                    if (row == col)
                    {
                        Console.Write("*");
                    }
                    else 
                    {
                        Console.Write(".");
                    }                    
                col++;               
            }            
          row++; 
          Console.WriteLine();
        }
        // ot sredata bez 1 red
        
        row = ((2 * n - 1) / 2) - 1; // obryshtame uslowieto za da wleze w while 
        while (row >= 0)
        {
            int col = n;
            while (col > 0) // na nowo obryshtame uslowieto
            {
                if (col == n - row)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
                col--;
            }
            row--;
            Console.WriteLine();
        }              
    }
}