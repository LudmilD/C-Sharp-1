using System;
//http://www.youtube.com/watch?v=dwfui_5_BOQ
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2011-2012 - C Sharp 1 Intermediate\6 Dec 2011 Morning
//http://bgcoder.com/Contest/Practice/6
class WeAllLoveBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            string normalNumberAsString = Convert.ToString(number, 2);
            string reversedNumberAsString = "";
            for (int j = normalNumberAsString.Length-1; j >= 0; j--)
            {
                reversedNumberAsString += normalNumberAsString[j]; 
            }
            int endResult = Convert.ToInt32(reversedNumberAsString,2);
            Console.WriteLine(endResult);
        }
    }
}

