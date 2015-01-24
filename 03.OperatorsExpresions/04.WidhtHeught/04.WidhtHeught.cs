using System;

class Program
{
    static void Main()
    {
        decimal[] width = new decimal[] { 3, 2.5m, 5 };
        decimal[] height = new decimal[] { 4, 3, 5 };
        decimal area = 0;
        decimal perimerter = 0;
            Console.WriteLine("width height perimeter area");
        for (int i = 0; i < width.Length; i++)
        {
            perimerter = width[i] * 2 + height[i] * 2;
            area = width[i] * height[i];
            Console.WriteLine("{0}     {1}      {2}       {3}", width[i], height[i], perimerter, area);
        }
    }
}

