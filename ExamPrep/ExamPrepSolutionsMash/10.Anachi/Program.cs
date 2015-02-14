using System;

class Program
{
    static void Main()
    {
        Console.WriteLine((int)'A');// proverqwame kakyw e koda na golqmo A = 65
        int shift = 64; // za da rabotime s 1 kato stoinost wadime 64
        string firstMember = Console.ReadLine();//-shift; // taka wednuj konvertirame kym int ot ASCII i wadim s 64 za da polu4im stoinost 1 ako e A
        int first = firstMember[0] - shift;

        string secondMember = Console.ReadLine();
        int second = (int)secondMember[0] - shift;

        int rowsNumber = int.Parse(Console.ReadLine());

        Console.WriteLine((char)(first + shift));
        if (rowsNumber > 1)
        {
            int next = first + second;
            if (next > 26)
            {//wseki pyt kogato smqtame pyrviqt sledwasht 4len trqbwa da syobrazim dali ne nadhvyrlq 26
                next = next % 26;
            }
            string result = ((char)(second + shift)).ToString() +
                                     ((char)(next + shift)).ToString();
            Console.WriteLine(result);
            first = second;
            second = next;
            for (int i = 3; i <= rowsNumber; i++)// ot dve zashtoto space zapo4wa ot vtoriq element
            {
                next = first + second; // iz4islqwa stoinostite po fibonachi
                if (next > 26)
                {
                    next = next % 26;
                }
                first = second;
                second = next; //razmenqme stoinostite za da polu4im sledwashtiq chlen

                next = first + second; // iz4islqwa stoinostite po fibonachi
                if (next > 26)
                {
                    next = next % 26;
                }
                first = second;
                second = next;

                Console.Write((char)(first + shift));
                Console.Write(new String(' ', i - 2));
                Console.WriteLine((char)(second + shift));
            }
        }
    }
}

