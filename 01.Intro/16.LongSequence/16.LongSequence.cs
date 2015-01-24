using System;

class Program
{
    static void Main()
    {

        int times = 1000;
        int startNum = 2;
        int toPrint = 0;
        int countMember = 1;
        while (times != 0)
        {
            if (startNum % 2 == 1)
            {
                toPrint = startNum * (-1);
                Console.WriteLine("member {0} is {1}", countMember, toPrint);
                countMember++;
                startNum++;
            }
            else
            {
                Console.WriteLine("member {0} is {1}", countMember, startNum);
                countMember++;
                startNum++;
            }
            times--;
        }
    }
}
