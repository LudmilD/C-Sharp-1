using System;
/*Problem 3.	Check for a Play Card Classical play cards use the following signs 
 * to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
 * Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. */
class Program
{
    static void Main()
    {
        string card = "10"; //Console.Readline();
        switch (card)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "A":
            case "Q":
            case "J":
            case "K":
            case "Joker":
                Console.WriteLine("yes");
                break;
            default:
                Console.WriteLine("no");
                break;
        }
    }
}

