using System;
using System.Drawing;
/*Problem 2.	Print Company Information
A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
*/

namespace RichTextBox
{
    class Program
    {
        static void Main()
        {

            //company has name, address, phone number, fax number, web site and manager.
            //Validation is whole other story
            Console.Title = "Company Name";

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("coName =  "); string coName = Console.ReadLine();
            Console.ResetColor();
            Console.Write("coAdres =  "); string coAdres = Console.ReadLine();
            Console.Write("coPhone = "); string coPhone = Console.ReadLine();
            Console.Write("coFax =  "); string coFax = Console.ReadLine(); ;
            Console.Write("coWeb =  "); string coWeb = Console.ReadLine();
            Console.Write("mngFirsName = "); string mngFirsName = Console.ReadLine();
            Console.Write("mngLastName = "); string mngLastName = Console.ReadLine();
            Console.Write("mngAge =  "); string mngAge = Console.ReadLine();
            Console.Write("mngPhone =  "); string mngPhone = Console.ReadLine();

            Console.WriteLine(@"Problem 2. Print Company Information
A company has name {0}, address {1}, phone number {2}, fax number {3}, web site{4} and manager.
The manager has first name {5}, last name {6}, age {7} and a phone number{8}",
                                                                             coName, coAdres, coPhone,
                                                                             coFax, coWeb, mngFirsName,
                                                                             mngLastName, mngAge, mngPhone);
        }
    }
}




