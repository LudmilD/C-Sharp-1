using System;

class Quadronachi
{
    static void Main()
    {

        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long d = long.Parse(Console.ReadLine());
        long lines = long.Parse(Console.ReadLine());
        long numbersInLine = long.Parse(Console.ReadLine());
        long sum = new long();
        // printira " " ako kolonite sa powe4e ot 4
        if (numbersInLine > 4) Console.Write(a + " " + b + " " + c + " " + d+" ");
        else Console.Write(a + " " + b + " " + c + " " + d);
       
        int firstFour = 4;// dobawq 4 elementa koito sme wyweli samo vednuj 
        // i se zanulqwa sled pyrviq red
        for (int row = 0; row < lines; row++)
        {
            for (int i = 0; i < numbersInLine - firstFour; i++)
            {
                sum = a + b + c + d;
                a = b; b = c; c = d; d = sum;
                long lastNumber = (numbersInLine - firstFour) - i;
                if (lastNumber == 1) Console.Write(sum);
                else Console.Write(sum + " ");
            }
            firstFour = 0;
            Console.WriteLine();
        }
    }
}

