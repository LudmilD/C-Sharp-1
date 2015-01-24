using System;
using System.Text;

class Program
{
    static void Main()
    {
        Random rdn = new Random();
        int ageRnd = rdn.Next(0, 100);


        string firstName = "lala";
        //Console.ReadLine();
        string lastName = "Lola";
        //Console.ReadLine();
        int Age = ageRnd;
        bool gen = ageRnd % 2 == 0 ? gen = false : gen = true;
        string Gender = gen ? "male" : "female";
        // inicializirame bool gender s ternaren operatof "?:" 
        //opredelqme dali e true ili false pri delene na vyzrastta celo4isleno na 2 bez ostatyk e falseina4e true 


        //## RandomID generator      
        //decimal Personal ID number (e.g. 8306112507)
        //decimal	Unique employee number (27560000…27569999)

    }
}

