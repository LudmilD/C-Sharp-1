using System;
//http://www.youtube.com/watch?v=ZVH26zL8WXQ
//http://bgcoder.com/Contest/Practice/5
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2011-2012 - C Sharp 1 Intermediate\sample 1
class Program
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());
        long[] nums = new long [n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = long.Parse(Console.ReadLine());
        }
        int maxI=1;
        for (int i = 1; i <=n; i++)
        {
            maxI*=2;
        } //edno i syshto powdiga na 2 stepen n -1
         maxI -= 1;
        //int maxI = (int)Math.Pow((double)2, n) - 1;
        int count = 0; // broi namereni sumi
        for (int i = 1; i <= maxI; i++)
        {
            long currentSum = 0;
            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;// poziciqta na bita
                int nAndMask = i & mask; // i e 4isloto
                int bit = nAndMask >> j; //wsyshtame maskata j pozicii i polu4awame bita
                //bit = (i & (1 << j))>>j
                if (bit == 1 )   currentSum += nums[j];                            
            }
            if (currentSum == s) count++;            
        }
        Console.WriteLine(count);
    }
}
