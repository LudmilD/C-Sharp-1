using System;
/*Problem 8.	Quotes in Strings
Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties.
Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.
*/
class Program
{
    static void Main()
    {
        string one = "The \"use\" of quotations causes difficulties.";//  \\ escping \\ use f10 escaping is represented like string one
        string two =@"The ""use"" of quotations causes difficulties.";// @ " " combination
        Console.WriteLine("{0}\n\r{1}",one,two);
    }
}

