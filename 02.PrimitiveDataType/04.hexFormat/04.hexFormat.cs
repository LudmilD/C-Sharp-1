using System;
/*Problem 4.	Variable in Hexadecimal Format
Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). 
 * Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is “254”.
*/
class Program
{
    static void Main()
    {
        int value = 0xfe;
        int hex = 254;
        Console.WriteLine(value);//254
        Console.WriteLine("{0} in hex 0x{1:x}",hex,hex);
    }
}

