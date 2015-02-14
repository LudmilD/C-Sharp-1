using System;

class Program
{
    static void Main()
    {
        byte B = byte.Parse(Console.ReadLine());// bita koito tyrsime 0 ili 1 
        byte N = byte.Parse(Console.ReadLine());// broq na 4islata 
        for (int i = 1; i <=N ; i++)
        {
            int count = 0;
            uint number = uint.Parse(Console.ReadLine());// vyvejdame konkretnoto 4islo
            while (number!=0)
            {
                if ((number & 1)== B)
                {
                    count++;
                }
                number = number >> 1; // za4ertawame proverenite bitowe doakto 4isloto stane 0
            }
            Console.WriteLine(count);// za wsqko 4islo izvejdame rezultat
        }
        
    }
}

