using System;
//http://www.youtube.com/watch?v=dwfui_5_BOQ
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2011-2012 - C Sharp 1 Intermediate\7 Dec 2011 Morning
//http://bgcoder.com/Contest/Practice/11
class DancingBits
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string result = ""; //string.Empty;
        int counter = 1;
        int counterK = 0;
       // char previousChar = result[0];// deklarirame pyrwi element predi da sme napylnili masiwa za towa seslaga po nadolu 

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());//convertira me w int i posle w string

            result += Convert.ToString(number, 2);
        }

        char previousChar = result[0];// deklarirame pyrwi element predi da sme napylnili masiwa za towa seslaga po nadolu 

        for (int i = 1; i < result.Length; i++)
        {
            if (result[i] == previousChar)
            {
                counter++;                
            }
            else
            {
                if (counter == k /*&& result[i+1]!=result[i]*/)
                {// slojen e v elsa a ne v if-a zashtoto taka sys sigurnos sme prekratili tyrseneto
                    counterK++;
                }
                previousChar = result[i];
                counter = 1;
            }
        }
        if (counter == k /*&& result[i+1]!=result[i]*/)
        {// syshtata proverka pomaga z posledniq element
            counterK++;
        }
        Console.WriteLine(counterK);

    }
}

