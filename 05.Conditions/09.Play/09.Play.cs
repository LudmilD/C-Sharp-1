using System;
/*Problem 9.	Play with Int, Double and String
Write a program that, depending on the user’s choice, inputs an int, double or 
 * string variable. If the variable is int or double, the program increases it by one. 
 * If the variable is a string, the program appends "*" at the end. Print the result at the console.
 * Use switch statement. */
class Program
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int user = int.Parse(Console.ReadLine());
        switch (user)
        {
            case 1:
                int a = int.Parse(Console.ReadLine());
                a += 1;
                Console.WriteLine(a);
                break;
            case 2:
                double b = double.Parse(Console.ReadLine());
                b ++;
                Console.WriteLine(b);
                break;
            case 3: string str = Console.ReadLine();
                str = str + "*";
                Console.WriteLine(str);
                break;
            default:
                Console.WriteLine("try again");
                break;
        }
    }
}

