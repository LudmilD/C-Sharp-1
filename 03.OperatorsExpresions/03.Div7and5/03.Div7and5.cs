using System;

class Program
{
    static void Main()
    {
        int[] value = new int[] { 3, 0, 5, 7, 35, 140 };
        bool chekck = true;

        Console.WriteLine("NUMBER	Divided by 7 and 5?");
        foreach (var item in value)
        {
            if (item  % 5== 0 && item % 7 ==0 && item !=0)
            {
                chekck=true;
            }
            else if (item  % 5== 0 && item % 7 ==0 && item ==0)
            {
                chekck = false;
            }
            else
            {
                chekck = false;
            }
            Console.WriteLine("{0,6}      {1}",item,chekck);
        }

    }
}

