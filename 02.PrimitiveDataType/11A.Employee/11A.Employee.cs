using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("First name");
        string firstName = (string)(Console.ReadLine());
        Console.WriteLine("Last name");
        string lastName = (string)(Console.ReadLine());
        Console.WriteLine("your Age");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("M for Male F for Female");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Your ID");
        int iD = int.Parse(Console.ReadLine());
        Console.WriteLine("unique employee number (27560000 to 27569999)");
        uint uEN = uint.Parse(Console.ReadLine());

        Console.WriteLine("Hello {0} {1}! Your age is {2}, gender {3}", firstName, lastName, age, gender);
        Console.WriteLine("Your ID is: {0}", iD);
        Console.WriteLine("unique employee number: {0}", uEN);

    }
}
