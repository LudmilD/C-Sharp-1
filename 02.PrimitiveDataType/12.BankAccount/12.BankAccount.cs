using System;
/*Problem 12.	Bank Account Data
A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
 * bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the 
 * information for a single bank account using the appropriate data types and descriptive names.
*/
class Program
{
    static void Main()
    {

        string firstName="Jingal";
        string lastName="Bels";
        decimal balance=1234546789.1234566m;
        string bankName="Bank Of hamerika";
        short IBAN=1234;
        decimal cCard1=12342345+IBAN;
        decimal cCard2=123432456+IBAN;
        decimal cCard3=34286234+IBAN;

        Console.WriteLine(new string('-',30));
        Console.WriteLine("Credit Card {0} belongs to {1} {2} with balance \n\r {3:C6} and IBAN {4}", cCard1,firstName, lastName,balance,IBAN);
        Console.WriteLine("{0} work to provide best cervice",bankName);
        Console.WriteLine(new string('-', 30));
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Credit Card {0} belongs to {1} {2} with balance \n\r {3:C4} and IBAN {4}", cCard2, firstName, lastName, balance, IBAN);
        Console.WriteLine("{0} work to provide best cervice", bankName);
        Console.WriteLine(new string('-', 30));
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Credit Card {0} belongs to {1} {2} with balance \n\r {3:C2} and IBAN {4}", cCard3, firstName, lastName, balance, IBAN);
        Console.WriteLine(@"""{0}"" work to provide best cervice", bankName);
        Console.WriteLine(new string('-', 30));

    }
}

