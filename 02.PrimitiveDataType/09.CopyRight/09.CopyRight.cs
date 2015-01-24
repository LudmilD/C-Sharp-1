using System;
/*Note that the © symbol may be displayed incorrectly at the console so you may need to
 * change the console character encoding to UTF-8 and assign a Unicode-friendly 
 * font in the console. Note also, that under old versions of Windows the © symbol
 * may still be displayed incorrectly, regardless of how much effort you put to fix it.*/
class Program
{
    static void Main()
    {
        string copyRight =
@"   ©
  © ©
 ©   ©
© © © ©";
Console.WriteLine(copyRight);
    }
}

