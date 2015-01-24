using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine(1);// n*i+1 - > string builder with 0 
        //Console.WriteLine(101); //100*10 +1 -> next
        //Console.WriteLine(1001);// 100*100 +1 -> next

        int n = 5;
        string newNumber;
        int number =0;
        for (int i = 0; i < n; i++)
        {
            newNumber = new string('0', i);
            newNumber = '1' + newNumber;
            if (i > 0)
            {
                newNumber = newNumber + '1';
                Console.WriteLine(newNumber);
            }
            else
            {
                Console.WriteLine(newNumber);
            }
            newNumber = "";
        }


    }
}

