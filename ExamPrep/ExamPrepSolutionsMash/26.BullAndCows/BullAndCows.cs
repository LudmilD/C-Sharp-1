using System;
using System.Collections.Generic;
//http://bgcoder.com/Contest/Practice/131
//http://www.youtube.com/watch?v=BCZsbHP7TIA
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2013 Jun - C Sharp 1\Variant 1 (2013-06-23)\Problem-3-Bulls-and-Cows
class BullAndCows
{
    static void Main()
    {
        string secretNumber = Console.ReadLine();// string zashtoto shte go razbiem na char[]
        int targerBulls = int.Parse(Console.ReadLine());
        int targetCows = int.Parse(Console.ReadLine());

        const char usedSecretNum = '*';
        const char usedGuesstNum = '@';
        List<int> result = new List<int>();

        for (int num = 1000; num <= 9999; num++)
  // akozapo4wa ot 1 imame out of range exeption zashtoto ne moje da zapylnime wi4ki shar arr
        {// i uslowiqta na ciklite ne se izpylnqwat
            int countFoundBulls = 0;
            int counFoundtCows = 0;
           
            char[] digitsGuess = num.ToString().ToCharArray();//generirani chisla
            char[] secretNumDigits = secretNumber.ToString().ToCharArray();// tajni 4isla
            
            if (digitsGuess[0] >= '1' && digitsGuess[1] >= '1' && digitsGuess[2] >= '1' && digitsGuess[3] >= '1')
            {// taka si generirame 4isla i wlizat za prowerka samo tezi koito otgowarqt na uslowieto da nqmat nula
                for (int i = 0; i < digitsGuess.Length; i++) 
                {//zavyrtame cikyla na generiranite chisla
                    if (digitsGuess[i] == secretNumDigits[i])//prowerqwa dali sa na edna poziciq identi4ni
                    {//prowerka za bikowe
                        countFoundBulls++;
                        digitsGuess[i] = usedGuesstNum; // pri nameren bik se markira s *
                        secretNumDigits[i] = usedSecretNum; // syshto markirame s * w tajnoto 4islo koeto e razbirto na char []
                        // Console.WriteLine(countBulls); testwame dali izwejda krawite                     
                    }
                }

                for (int secretIndex = 0; secretIndex < secretNumDigits.Length; secretIndex++)
                {//zavyrtame cikyla na generiranite chisla
                    for (int guessIndex = 0; guessIndex < digitsGuess.Length; guessIndex++)
                    {
                        if (secretNumDigits[secretIndex] == digitsGuess[guessIndex])//vajno e mqstoto pyrvo e secretNumDigits[] zashtote 
                            //masiva koito dyrji oreginalnite taini cifri , a drugiq se wyrti po j s generiranite 4isla
                        {//prowerka za crawi na wsqka poziciq ot secretnumdigit[i] izwyrta wsi4ki digits[j]
                            counFoundtCows++;
                            digitsGuess[guessIndex] = usedGuesstNum;
                            //imashe problem 4e markirame ednakwo w dvata masiwa sys * za namerenite 4isla i s * za izpolzwanite 
                            //digitsGuess[guessIndex] = usedGuesstNum; // pri nameren bik se markira s *
                            secretNumDigits[secretIndex] = usedSecretNum; // syshto markirame s * w tajnoto 4islo koeto e razbirto na char []
                            // Console.WriteLine(countBulls);                    
                        }
                    }
                }
                if (counFoundtCows == targetCows && countFoundBulls == targerBulls)// sled naprawenite prowerki dobavqme 4isloto ot pyrviq cikyl
                {
                    result.Add(num);
                }
            }
        }
        if (result.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]+ " ");//console.writeLine dawa rezultat na now redi pri dobawqne na spqce se trimva samo posledniq nov red
            }
        }
    }
}

