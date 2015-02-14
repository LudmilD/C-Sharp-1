using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


class bittris
{
    static void Main()
    {
        if (Enviernment.CurrentDirectory.ToLower().EndWith("bin\\debug"))
        {
            Console.SetIn(new StreamReader("input.txt"));
        }

        int numberOfLines = int.Parse(Console.ReadLine());
        int numebrOfShapes = numberOfLines / 4;

        for (int ii = 0; ii < numebrOfShapes; ii++)
        {
            int shape = int.Parse(Console.ReadLine());//sled wsqko 4islo ima me 3 reda s komandi
            string commands = Console.ReadLine() +
                                Console.ReadLine() +
                                Console.ReadLine();
            Console.WriteLine("{0} {1}",shape,commands);
        }

    }
}

