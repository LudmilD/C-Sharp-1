using System;

class BankAcount
{
    static void Main()
    {
        Console.WriteLine("THIS IS YOUR BANK ACCOUNT INFORMATION TYPE IN CAREFULLY! \n\r Please enter your First name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Please enter your Sirname name:");
        string secondName = Console.ReadLine();

        Console.WriteLine("Please enter your Last name:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Your balance:");
        decimal balance = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Your Bank Name:");
        string bankName = Console.ReadLine();

        Console.WriteLine("Your IBAN is:");
        string iban = Console.ReadLine();

        Console.WriteLine("BIC");
        string bic = Console.ReadLine();

        Console.WriteLine("Enter ID Number of Credit Cart N1:");
        string creditCartN1 = Console.ReadLine();

        Console.WriteLine("Enter ID Number of Credit Cart N2:");
        string creditCartN2 = Console.ReadLine();

        Console.WriteLine("Enter ID Number of Credit Cart N3:");
        string creditCartN3 = Console.ReadLine();
        Console.WriteLine("+==={0}============ PRIVATE BANKACCOUNT INFORMATION =========={0}===+", bankName);
        Console.WriteLine("|   Dear {0} {1} {2} your balance is: {3}", firstName, secondName, lastName, balance);
        Console.WriteLine("|   Your IBAN is {0} and your BIC is {1}", iban, bic);
        Console.WriteLine("|   Your First registered credit card number is: {0}", creditCartN1);
        Console.WriteLine("|   Your Second registered credit card number is: {0}", creditCartN2);
        Console.WriteLine("|   Your Third registered credit card number is: {0}", creditCartN3);
        Console.WriteLine("+==={0}============ PRIVATE BANKACCOUNT INFORMATION =========={0}===+", bankName);
        Console.WriteLine();
    }


}

