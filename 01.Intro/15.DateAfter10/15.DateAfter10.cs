using System;
/*Problem 15.	* Age after 10 YearsWrite a program to read your birthday from the console and 
 * print how old you are now and how old you will be after 10 years.*/
// Age afret 10 year formard -> int yourage; yourage+10 :)
// not the case if you take day and month.
class Program
{
    static void Main()
    {
        //http://www.dotnetperls.com/time 
        DateTime dateBirth = DateTime.Parse("20/02/87"); // dd/mm/yy // you can change manualy
        DateTime today = DateTime.Now;
        DateTime futurAge = new DateTime();
        int ageAfter = 10; // calculate our age after Number of years // you can change manualy
        int age=0;

        if (today.Month > dateBirth.Month)
        {
            age = today.Year - dateBirth.Year;
            futurAge = today.AddYears(ageAfter);
        }
        else if (today.Month == dateBirth.Month)
        {
            if (today.Day > dateBirth.Day)
            {
                age = (today.Year - dateBirth.Year) - 1;
                futurAge = today.AddYears(ageAfter - 1);//stil haven get there:)
            }
            else if (today.Day <= dateBirth.Day)
            {
                futurAge = today.AddYears(ageAfter);
                age = (today.Year - dateBirth.Year) - 1;
            }
        }
        else if (today.Month < dateBirth.Month)
        {
            futurAge = today.AddYears(ageAfter - 1);// just befor yout b day:)
            age = (today.Year - dateBirth.Year) - 1;
        }
        Console.WriteLine(age);
        int futureAge = futurAge.Year - dateBirth.Year;
        Console.WriteLine(futureAge);
    }
}

