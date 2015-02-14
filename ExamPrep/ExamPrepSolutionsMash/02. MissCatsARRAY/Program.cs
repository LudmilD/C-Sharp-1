using System;

class Program
{
    static void Main()
    {
        int judge = int.Parse(Console.ReadLine());
        int[] cats = new int[11];
        for (int i = 0; i < judge; i++)
        {
            // wpiswame nomera na kotkata ot 1-10 
            // kato im dawame +1 to4ka s izbora na nomera im
            int mark = int.Parse(Console.ReadLine());
            cats[mark]++;
        }
        int max = 0;
        int catNumber=0;
        // obhojdame masiwa
        for (int i = 0; i < cats.Length; i++)
        {
            //wzimame tekushtata stoinost (tochki na opredeleniq nomer)
            int currentValue = cats[i];
           // ako stoinosta e po golqma ot max do sega
            // prowerqwame i priswoqwame 
            if (currentValue > max)
            {
                max = currentValue;
                catNumber = i;                
            }
        }
        Console.WriteLine(catNumber);
    }
}

