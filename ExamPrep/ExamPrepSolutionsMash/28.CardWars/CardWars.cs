using System;
using System.Numerics;
//http://bgcoder.com/Contest/Practice/131
//http://www.youtube.com/watch?v=up-5CDJ_K-s
class CardWars
{
    static void Main()
    {
        checked
        {// po tozi nachin proverqwame za overflow exception
            int allGames = int.Parse(Console.ReadLine());
            const int cardsInGame = 3;
            BigInteger globalPlayerOneScore = 0;
            BigInteger globalPlayerTwoScore = 0;
            bool xCardDrawnByPlayerOne = false;
            bool xCardDrawnByPlayerTwo = false;
            int gamesWonByPlayerOne = 0;
            int gamesWonByPlayerTwo = 0;
            for (int i = 0; i < allGames; i++)
            {// w tozi cikyl shte se igraqt wsi4ki igri 
                int playerOneLocalScore = 0;
                int playerTwoLocalScore = 0;
                for (int j = 0; j < cardsInGame; j++)
                {// cikyl za prowerka na kartite na ediniq igrach
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A": playerOneLocalScore += 1;
                            break;
                        case "J": playerOneLocalScore += 11;
                            break;
                        case "Q": playerOneLocalScore += 12;
                            break;
                        case "K": playerOneLocalScore += 13;
                            break;
                        case "Z": globalPlayerOneScore = 2 * globalPlayerOneScore;
                            //globalPlayerOneScore*=2
                            break;
                        case "Y": globalPlayerOneScore -= 200;
                            break;
                        case "X": xCardDrawnByPlayerOne = true;
                            break;
                        // card value 2 = 10 card value 10 = 2 taka si spestqwame por cikyl ili otdelni casove
                        default: playerOneLocalScore += 12 - int.Parse(card);
                            break;
                    }
                }
                for (int j = 0; j < cardsInGame; j++)
                {
                    string card = Console.ReadLine();
                    switch (card)
                    {
                        case "A": playerTwoLocalScore += 1;
                            break;
                        case "J": playerTwoLocalScore += 11;
                            break;
                        case "Q": playerTwoLocalScore += 12;
                            break;
                        case "K": playerTwoLocalScore += 13;
                            break;
                        case "Z": globalPlayerTwoScore = 2 * globalPlayerTwoScore;
                            //globalPlayerOneScore*=2
                            break;
                        case "Y": globalPlayerTwoScore -= 200;
                            break;
                        case "X": xCardDrawnByPlayerTwo = true;
                            break;
                        // card value 2 = 10 card value 10 = 2 taka si spestqwame por cikyl ili otdelni casove
                        default: playerTwoLocalScore += 12 - int.Parse(card);
                            break;
                    }
                }
                //## X card conditions
                if (xCardDrawnByPlayerOne && xCardDrawnByPlayerTwo)
                {
                    globalPlayerOneScore += 50;
                    globalPlayerTwoScore += 50;
                    //and reset flags
                    xCardDrawnByPlayerOne = false;
                    xCardDrawnByPlayerTwo = false;
                }

                //##wyznikwa porblem kak da izwedeme rezultata samo za izvadenite karti i da ne prawi
                //nishto drugo
                if (xCardDrawnByPlayerOne)
                {//ako beikneme cikyla pak zapo4wat nqkakwi iz4islqwaniq za globalnata igra
                    //Console.WriteLine("X card drawn! Player one wins the match!");
                    // return;
                    break;// samo breikwa i pechatame po nadolu
                }
                else if (xCardDrawnByPlayerTwo)
                {
                    //Console.WriteLine("X card drawn! Player two wins the match!");
                    //return;spri  swoeto izpylnenie i wyrni rezultat .. no main metoda e void
                    // t.e. ne wryshta rezultat no shte raboti
                    //break; ima problem s nego ne izvejda izcqlo a smo ot lokalniq for cikyl
                    //Environment.Exit();
                    break;// samo breikwa i pechatame po nadolu
                }

                //## who won !!! koi e spechelil malkata igra tochki samo za pobeditelq
                if (playerOneLocalScore > playerTwoLocalScore)
                {
                    globalPlayerOneScore += playerOneLocalScore;
                    gamesWonByPlayerOne++;
                }// ako slojime ELSE bez if shte e se edno pl1LS <=pl2LS
                else if (playerOneLocalScore < playerTwoLocalScore)
                {
                    globalPlayerTwoScore += playerTwoLocalScore;
                    gamesWonByPlayerTwo++;
                }
            }

            //## tuk otpe4atwa breiknatite X carti vsi4ki trqbwa da sa wyrzani w else if 
            if (xCardDrawnByPlayerOne)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");

            }
            else if (xCardDrawnByPlayerTwo)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");

            }


            //## izvejdane na rezultatite
            else if (globalPlayerOneScore > globalPlayerTwoScore) // 2 testa gyrmqt bez else
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", globalPlayerOneScore);
                Console.WriteLine("Games won: {0}", gamesWonByPlayerOne);
            }
            else if (globalPlayerOneScore < globalPlayerTwoScore)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", globalPlayerTwoScore);
                Console.WriteLine("Games won: {0}", gamesWonByPlayerTwo);
            }
            else// kogato i dwata sa ravni 
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", globalPlayerTwoScore);
            }







        }

    }
}

