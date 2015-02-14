using System;
//http://bgcoder.com/Contest/Practice/11
//http://www.youtube.com/watch?v=75_7CecYMw0
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2011-2012 - C Sharp 1 Intermediate\7 Dec 2011 Morning

class Program
{
    static void Main()
    {
        int n = 8;
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {//matrix[i, j] = ((number >> j) & 1)=1; bool matrix
                matrix[i, j] = (number >> j) & 1;// take last bit
            }
        }
        int longestLine = 0;
        int longestCount = 0;
        for (int i = 0; i < n; i++)
        {
            int currentLine = 0;
            for (int j = 0; j < n; j++)
            {
                while (j < n && matrix[i, j] == 1)// obhojdane po red demek horizontalnite linii !!!
                {//i ne sme izlezli ot matricata
                    currentLine++;// na pyrwi red naj dylgata liniq e s duljina 1 [0.3]
                    j++;
                }
                if (currentLine > longestLine) // dali namerenata e po golqma ot naj dylgata
                {
                    longestLine = currentLine;
                    longestCount = 1;// ima samo edna naj golqm liniq
                    currentLine = 0;
                }
                else if (longestLine == currentLine)
                {
                    longestCount++;// ako wse pak namerime druga dobavqme broikata
                }
                currentLine = 0;
            }
        }
        // obhojdame po wertilaka t.e. po koloni
        for (int j = 0; j < n; j++)
        {
            int currentLine = 0;
            for (int i = 0; i < n; i++)
            {
                while (i < n && matrix[i, j] == 1)// obhojdane po red demek horizontalnite linii dokato ima 1ci.. !!!
                {//i ne sme izlezli ot matricata
                    currentLine++;// po to4no e da e kolona we4e no e ok :) i taka 
                    i++;
                }
                if (currentLine > longestLine) // dali namerenata e po golqma ot naj dylgata
                {
                    longestLine = currentLine;
                    longestCount = 1;// ima samo edna naj golqm liniq
                    currentLine = 0;
                }
                else if (longestLine == currentLine)
                {
                    longestCount++;// ako wse pak namerime druga dobavqme broikata
                }
                currentLine = 0;
            }
        }
        if (longestLine == 1)
        {
            longestCount = longestCount / 2;//delim na 2 zashtoto moje da ima powe4e edini4ni linii
        }
        Console.WriteLine(longestLine);
        Console.WriteLine(longestCount);
    }
}
