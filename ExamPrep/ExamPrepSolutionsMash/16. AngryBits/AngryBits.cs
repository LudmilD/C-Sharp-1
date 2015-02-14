using System;

class Program
{
    static void Main()
    {
        // prawim si masiw4e
        int[,] matrix = new int[8, 16];
        //wywejdame 8-te 4isla
        for (int i = 0; i < 8; i++)
        {
            int number = int.Parse(Console.ReadLine());
            // sega gi rpawime na bitowe
            for (int j = 0; j < 16; j++)
            {
                // fokusa za razbiwane 4isloto na bitowe i wywejdaneto mu w masiw
                int bit =
                    (number >> j) & 1;
                // bita shte byde 0 ili 1 i w zasiwimost ot towa kakyw bit se polu`awa
                // takyw bit vyvejdame
                matrix[i, j] = bit;
            }
        }
        // obhojdane na koloni i redowe i tursime 1 koeto e pile
        int score = 0;
        for (int col = 8; col < 16; col++)
        {
            int currentRow = -1; // ako e 0 nqma da wleze w if-a taka indikira 4e ne
            //e v masiwa koito e 0-8
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    currentRow = row;
                    break;
                }
            }
            //game logic - killing pigs
            if (currentRow == -1) // - 1 pokazwa 4e ne sme namerili ptica
            {
                continue; // breck shte izleze ot cikyla
            }
            else // pri namerena ptica
            {// namalqwame kolonata i reda za da se pridvijim po diagonal

                string direction = "up";
                //?  matrix[currentRow, col] = 0;
                // zadawane na diagonalno dwijenie

                //
                if (currentRow == 0)
                {
                    direction = "down";
                }
                int path = 0; // to4kite za izminatiq pyt
                int pigHitted = 0;
                matrix[currentRow, col] = 0;
                //                       
                for (int currentColumn = col - 1; currentColumn >= 0; currentColumn--)
                { //int currentColumn = col greshno
                    if (direction == "up")
                    {
                        currentRow--;
                        if (currentRow == 0)
                        {//if (currentRow == -1) greshno
                            // currentRow++; greshno
                            direction = "down";
                        }
                    }
                    else
                    {
                        currentRow++;
                        if (currentRow > 7) // dali stigame izvyn masiwa (dynoto) i ako gubim pticata
                        {
                            break;
                        }
                    }
                    if (matrix[currentRow, currentColumn] == 1)
                    {
                        path = col - currentColumn;

                        // pigHitted++;
                        // prowerka dali kolonite i redowete sa v granicite na
                        //masiva pri granichnite slu4ei praseto da e w ygyla w nqkoi ot krainite strani
                        for (int i = currentRow - 1; i <= currentRow + 1; i++)
                        {
                            for (int j = currentColumn - 1; j <= currentColumn + 1; j++)
                            {
                                // if (i > -1 || j < 0 || i >= 7 || j >= 7) pitane dali sme izwyn masiwa
                                //prowerka za gornite granici gere i dqsnata strana
                                if (i > -1 && i < 8 && j > -1) // dali sme w masiwa
                                {
                                    if (matrix[i, j] == 1)//prowerka za prase
                                    {
                                        pigHitted++; // ot4itame udyr
                                        matrix[i, j] = 0;

                                    }
                                }
                            }
                        }
                    }
                    //dobaveno
                    // udarite po rpaseto
                    if (pigHitted >= 1)
                    {
                        break;
                    }
                    //
                }
                score = score + path * pigHitted;
                // ve4e ne ni trqbwa se edno znam koga ni e trqbwalo
                //int currentCol = col;
                //currentCol--;
                //currentRow--;
                //if (currentRow == -1)
                //{
                //    direction = "down";
                //    currentRow++;
                //}
                // popadame na 1-ca w matricata koeto e prase

            }
        }
        // bool pigs = false; bulewa promenliva za prowerka ima li praseta ili string
        string result = "Yes";
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matrix[i, j] == 1)
                {
                    result = "No";
                    break;
                }
            }
        }
        Console.WriteLine("{0} {1}", score, result);
    }
}



//using System;
////http://bgcoder.com/Contest/Practice/81
////C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2012-2013 - C Sharp 1 Intermediate\Exam 1 at 29 Dec 2012
//class AngryBits
//{
//    static void Main()
//    {
//        int[,] matrix = new int[8, 16];
//        int bitPosition = 0;
//        int path = 0; // pytq izminat ot pileto
//        int pigHited = 0;
//        for (int i = 0; i < 8; i++)                                                             //## prawilanta posoka na zapiswane na bitowete w matricata
//        {// wywejdame 4islata po kolonata syotwetno 8 4isla edno po edno                        //for (int i = 0; i < 8; i++){
//            int number = int.Parse(Console.ReadLine());                                         //    for (int j = 15; j >= 0; j--)// set colum backword in the matrix           
//            for (int j = 0; j < 16; j++)// set colum backword in the matrix                     //    {// convert each number to binary                
//            {// convert each number to binary                                                   //        if (bitPosition <= 15)           
//                int bit = (number >> j) & 1;// get the bit in "number" at position j  0-16      //         {                                                                     
//                matrix[i, j] = bit;                                                            //            bitPosition++;                                                                                          
//            }                                                                                   //        }                                                                                   
//        }                                                                                        //    }      
//        //take the second half with pigs                                                         //    bitPosition = 0;
//        int score = 0;                                                                           //}
//        for (int col = 8; col < 16; col++)
//        {
//            int currentRow = -1;
//            for (int row = 0; row < 8; row++)
//            {
//                if (matrix[row, col] == 1)
//                {
//                    currentRow = row;
//                    break;
//                }
//            }
//            // logika za ubivane napraseta
//            if (currentRow == -1)
//            {
//                continue;
//            }
//            else
//            {// ot tozi else nqma smisyl zashtoto te sa si 0 po princip 
//                pigHited = 1;
//                path = 0;
//                string direction = "up";
//                if (currentRow == 0)
//                {
//                    direction = "down";
//                }
//                matrix[currentRow, col] = 0;// zanulawqne na otkritiq bit koito e bil 1 
//                //zapo4wame da se dviji pti4kata
//                for (int currentColumn = col-1; currentColumn >= 0; currentColumn--)
//                {// COL E VSYSHTNOST OT KYDE SME TRYGNALI
//                    if (direction == "up")
//                    {
//                        currentRow--;
//                        if (currentRow == 0)//ako e 0 shte widi 4e e nula i nqma da go obraboti 
//                        {
//                            currentRow++;
//                            direction = "down";
//                        }
//                    }
//                    else
//                    {// slizame nadolu
//                        currentRow++;
//                        if (currentRow > 7)
//                        {// dali stigame izvyn masiwa ? i ako stigame brak;
//                            break;
//                        }
//                    }
//                    //DO TUK PODSIGURIHME DALI SME V MASIWA 
//                    // SLED KATO SME WYTRE IZWYRSHWAME PROVERKI ZA 1 I 0 AKO SME UDARILI VLIZAME WYW WYTRESHNITE FOR CIKLI KYDETO PROWERQWAME SYSEDITE
//                    if (matrix[currentRow, currentColumn] == 1) // slu4eq w koito udrq edinica predi da stigne kraq na matricata
//                    {
//                        path = col - currentColumn;
//                        for (int i = currentRow-1; i <= currentRow + 1; i++)
//                        {// PROWERKA NA SYSEDNITE KLETKI DALI SA 1 
//                            for (int j = currentColumn-1; j <= currentColumn + 1; j++)
//                            {
//                                if (i > -1 && i > 8 && j > -1) // pitane dali sme wyw masiwa ZA DA NE IZLEZEM AKO SE NAMIRAME W YGLITE
//                                // if (i < 0 || j < 0 || i >= 7 || j >=7)// pitane dali sme izvyn masiwa 
//                                {// prowerka na gornata dnqsna granica [15,15] dali izliza
//                                    if (matrix[i, j] == 1)
//                                    {// ZANULQWANE NA UDARENOTO PRASE
//                                        pigHited++;
//                                        matrix[i, j] = 0;
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//                score = score + pigHited * path;


//                if (pigHited >= 1)
//                {
//                    break;
//                }       
//            }
//        }
//        //## PRINT ARR ... 
//        //for (int i = 0; i < 8; i++)
//        //{// print ma3x[0,0]-[16,16] not  
//        //    for (int j = 0; j < 16; j++)
//        //    {//j = 15; j >=0; j-- will be printing it mirror image [0,15][0,0] when actuallu it is not right! 
//        //        Console.Write(matrix[i, j]);
//        //    }
//        //    Console.WriteLine();
//        //}
//        string result = "Yes";
//        //bool pids = false;
//        for (int i = 0; i < 8; i++)
//        {
//            for (int j = 0; j < 8; j++)
//            {
//                if (matrix[i, j] == 1)
//                {
//                    result = "No";
//                    break;
//                }
//            }
//        }
//        Console.WriteLine(score + " " + result);
//    }
//}

