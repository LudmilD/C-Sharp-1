using System;

class Program
{
    static void Main()
    {
        int n = 8;
        char[,] field = new char[n, n];
        char[] current = new char[n];
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());// save input in []
            current = Convert.ToString(numbers[i], 2).PadLeft(n, '0').ToCharArray();//convert to chr[]of bit arr
            for (int col = 0; col < n; col++)
            {// fill the field line by line
                field[i, col] = current[col];
            }
        }
        string directions = "down";
        string previous = "";
        int row = 0;
        int coll = n - 1;
        int distance = 0;
        int turns = 0;

        while (directions != "stop")// || (row == n-1 && coll == 0))
        {

            while (directions == "down")
            {
                if (row < n && field[row, coll] == '0')
                {
                    distance++;
                    row++;
                }
                else
                {
                    row--;
                    if (row < n && row >= 0 && coll - 1 >= 0 && field[row, coll - 1] == '0')
                    // if the very first time row>=0 other wise exeption
                    {//row-1 becouse already added and false coll-1 becouce direction i left
                        directions = "left";// set direction name
                        previous = "down";
                        //row--;//set direction right coordinates
                        coll--;
                        turns++;//count turns
                    }
                    else
                    {
                        directions = "stop";
                        // row--;// normalize direction
                    }
                }
            }
            while (directions == "left")
            {
                if (coll >= 0 && field[row, coll] == '0')
                {
                    distance++;
                    coll--;
                }
                else
                {
                    coll++;
                    if (coll == 0 && row == n - 1)// last 10 points
                    {
                        directions = "stop";
                    }
                    else if (previous == "up" && row + 1 < n && field[row + 1, coll] == '0')// check for down
                    {//#2added coll + 1 < n &&
                        //# removed //coll++;//set true direction
                        row++;
                        turns++;
                        directions = "down";
                        //previous = "left";/// noneed
                    }
                    else if (previous == "down" && row - 1 >= 0 && field[row - 1, coll] == '0')//check for up//field[row - 1, coll] == '0'
                    {
                        directions = "up";
                        row--;// one row up
                        //  coll++;//one col back
                        turns++;
                        previous = "left";
                    }
                    else
                    {
                        directions = "stop";
                        //coll++;//normalize direction
                    }
                }
            }
            while (directions == "up")
            {
                if (row >= 0 && field[row, coll] == '0')// first check valie of row so won't throw exep
                {// if fieald[row,col] is false 
                    distance++;
                    row--;
                }
                else
                {
                    row++;
                    if (coll - 1 >= 0 && field[row, coll - 1] == '0')
                    {//row-1 becouse already added and false coll-1 becouce direction i left
                        directions = "left";// set direction name
                        //row++;//set direction right coordinates
                        coll--;//added set position##=+40points
                        turns++;//count turns
                        previous = "up";
                    }
                    else
                    {
                        directions = "stop";
                        // row++;//normalize direction
                    }
                }
            }
        }
        if (coll == 0 && row == n - 1)
        {
            Console.WriteLine("{0} {1}", distance, turns);
        }
        else
        {
            Console.WriteLine("No {0}", distance);
        }


    }
}
