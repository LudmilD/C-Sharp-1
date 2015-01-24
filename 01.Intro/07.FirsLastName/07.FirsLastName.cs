using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("first name");
        string firsName = Console.ReadLine();
        Console.WriteLine("last name");
        string lastName = Console.ReadLine();
        string print = "FirstName LastName";

        if ((firsName != "") && (lastName != ""))
        {
            Console.WriteLine("rist name si {0} and Last {1}", firsName, lastName);
        }
        else
        {
            Console.WriteLine(print);
        }

    }
}

