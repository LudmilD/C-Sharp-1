using System;
/*Problem 6.	Boolean Variable
Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. Print it on the console.
*/
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int OneZero = rand.Next(0, 3);
        bool isFemale;
        isFemale = Convert.ToBoolean(OneZero);
        Console.WriteLine(isFemale);
    }
}

