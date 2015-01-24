using System;
/*Problem 4.	Print a Deck of 52 Cards
Write a program that generates and prints all possible cards from a standard deck of 52 cards */
class Program
{
    static void Main()
    {
        string[] cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "A", "J", "Q", "K" };
        //////////////////////////// club♣    dimonds ♦  heart♥    bspade♠    
        char[] signs = new char[] { '\u2663', '\u2666', '\u2665', '\u2660', };
        
        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < signs.Length; j++)
            {                
                Console.Write(string.Format("{0}{1}",cards[i],signs[j]).PadLeft(4));
            }
            Console.WriteLine();
        }
    }
}

