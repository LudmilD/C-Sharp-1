using System;
/*Problem 14.	* Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). Note that some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently. You may need to use for-loops (learn in Internet how).
*/
//note "beep" , backspace newline etc are not shown
class Program
{
    static void Main()
    {
        int charNum = 255;
        Console.WriteLine("Number Char Hex");
        for (int i = 0; i <= charNum; i++)
        {
            Console.WriteLine(@"{0}  {1,5}   {2:X} ",i,(char)i,i);
        }
    }
}

