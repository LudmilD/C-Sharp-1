using System;
/*Declare a character variable and assign it with the symbol that has Unicode code 72, and then print it. 
 * Hint: first, use the Windows Calculator to find the hexadecimal representation of 72. The output should be “H”.*/
class Program
{
    static void Main()
    {
        // \uNNNN = unicode numbers 

        //int intNum = int.Parse(Console.ReadLine());
        int intNum = 72;
        char intToChar = (char)intNum;
            //'\u0048';

        //string stringUnicode = unicode.ToString();
        Console.WriteLine("symbol={0}, numberUnicode={1}, hex=0x{2:x}", intToChar, (int)intToChar, (int)intToChar);// or use intNum without cast
        string intToHex = intNum.ToString("X");
        Console.WriteLine(@"char value '\u{0:D4}'", intToHex);


    }
}

