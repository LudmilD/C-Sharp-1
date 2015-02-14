using System;

class Program
{
    static void Main()
    {

        int[,] matrix = new int[9, 9];
        for (int i = 0; i < 8; i++)
        {
            byte numbers = byte.Parse(Console.ReadLine());
            for (byte j = 0; j < 8; j++)
            {
                int bit =
                (numbers >> j) & 1;
                matrix[j, i] = bit;
            }
        }
        /*printirane na masiwa*/
        //for (int row = 0; row < 8; row++)
        //{
        //    /* for (int col = matrix.GetLength(1) - 1; col >= 0; col--)*/
        //    // pe4ata spored diagramata
        //    for (int col = 0; col < 8; col++)// printira taka kakto e zapisan
        //    {
        //        Console.Write(matrix[col, row]);
        //    }
        //    Console.WriteLine();
        //}

        int maxLenghtCOLCounter = 0;
        int LineCOLCounter = 0;
        int lenghtCOLCounter = 0;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (matrix[row, col] == 1)
                {
                    if (matrix[row, col] == 1 && matrix[row, col + 1] == 1)
                    {
                        lenghtCOLCounter++;
                    }
                    if (matrix[row, col] == 1 && matrix[row, col + 1] == 0)
                    {
                        lenghtCOLCounter++;
                        if (maxLenghtCOLCounter < lenghtCOLCounter)
                        {
                            maxLenghtCOLCounter = lenghtCOLCounter;
                            lenghtCOLCounter = 0;
                            LineCOLCounter = 0;
                            LineCOLCounter++;
                        }
                        else if (maxLenghtCOLCounter == lenghtCOLCounter)
                        {
                            LineCOLCounter++;
                            lenghtCOLCounter = 0;
                        }
                        else
                        {
                            lenghtCOLCounter = 0;
                        }
                    }
                }
            }
        }
        //Console.WriteLine("kolona");
        //Console.WriteLine("length {0}", maxLenghtCOLCounter);
        //Console.WriteLine("lines {0}", LineCOLCounter);

        int LineROWCounter = 0;
        int maxLenghtROWCounter = 0;
        int lenghtROWCounter = 0;

        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (matrix[row, col] == 1)
                {
                    if (matrix[row, col] == 1 && matrix[row + 1, col] == 1)
                    {
                        lenghtROWCounter++;
                    }
                    if (matrix[row, col] == 1 && matrix[row + 1, col] == 0)
                    {
                        lenghtROWCounter++;
                        if (maxLenghtROWCounter < lenghtROWCounter)
                        {
                            maxLenghtROWCounter = lenghtROWCounter;
                            lenghtROWCounter = 0;
                            LineROWCounter = 0;
                            LineROWCounter++;
                        }
                        else if (maxLenghtROWCounter == lenghtROWCounter)
                        {
                            LineROWCounter++;
                            lenghtROWCounter = 0;
                        }
                        else
                        {
                            lenghtROWCounter = 0;
                        }
                    }
                }
            }
        }
       
        //Console.WriteLine("red");
        //Console.WriteLine("length {0}", maxLenghtROWCounter);
        //Console.WriteLine("lines {0}", LineROWCounter);
       
        if (maxLenghtCOLCounter > maxLenghtROWCounter)
        {
            Console.WriteLine(maxLenghtCOLCounter);
            Console.WriteLine(LineCOLCounter);
        }
        if (maxLenghtROWCounter > maxLenghtCOLCounter)
        {
            Console.WriteLine(maxLenghtROWCounter);
            Console.WriteLine(LineROWCounter);
        }
        
        
        if (maxLenghtCOLCounter == maxLenghtROWCounter && maxLenghtCOLCounter !=1)
        {
            Console.WriteLine(maxLenghtROWCounter);
            Console.WriteLine((LineCOLCounter + LineROWCounter) );
        }

        if (maxLenghtCOLCounter == 1 && maxLenghtROWCounter == 1)
        {
            Console.WriteLine(maxLenghtCOLCounter);
            System.Console.WriteLine(LineCOLCounter);
        }
    }
}
//class Program
//{
//    static void Main()
//    {
//        // int[] numbers = new int[8]; // okaza se izlishno 1meren masiw tyjkato posle se prehwyrlq w dvumeren pobitow masiw
//        int[,] matrix = new int[8, 8]; // vyznikwa seriozen problem pri deklarirane na matrica ot tip
//        // vuvejdame 8-te 4isla        // byte i za towa mehani4no ograni4ih cikyla do 8 8 i kato razmer na matricata.
//        for (int i = 0; i < 8; i++)     // koeto otgowarq na tipa byte.
//        {
//            // poneje byte e 8 bitov procesora raboti w 32 ili 64 
//            // trqbwa da se convertira s tringa ot 64 w 8
//            // http://forums.asp.net/t/1579215.aspx/1
//            // towa ima otnoshenie po- kysno wyw wyvejdaneto w 8 bitowata tablica.
//            //   numbers = Convert.ToByte((Console.ReadLine()));
//            byte numbers = byte.Parse(Console.ReadLine()); // reshenieto na problema 
//            for (byte j = 0; j < 8; j++)
//            {
//                int bit =
//                (numbers >> j) & 1;
//                matrix[j, i] = bit; // i,j oreginalno
//            }
//        }

//        // izvejdane na koj da e masiw na konzolata za swerqwane
//        // printiraneto e ogledalno na primera w zada4ata no e korekten

//        /*printirane na masiwa*/
//        for (int row = 0; row < matrix.GetLength(0); row++)// izpolzwame GetLength(0) vmesto.Lenght ne znam zashto
//        {
//           /* for (int col = matrix.GetLength(1) - 1; col >= 0; col--)*/ // pe4ata spored diagramata
//             for (int col = 0; col < matrix.GetLength(1); col++)// printira taka kakto e zapisan
//            {
//                Console.Write(matrix[col, row]);// pri col,row masiwa izglejda obyrnat ogledalno nadoly
//            }// pri row,col e obyrnat ogledalno nadqsno
//            Console.WriteLine();
//        }

//        // obhojdane na masiwa po wertikala i horizontala.. s uslowie matrix[i]=1
//        // matrix[i]== matrix[i+1]
//        int maxLenghtROWCounter = 0;
//        int maxLenghtCOLCounter = 0;
//        int lineROWCounter = 0;
//        int lineCOLCounter = 0;
//        for (int row = 0; row < 8; row++)
//        {
//            int lenghtCOLCounter = 0;//NB kyde mu e mqstoto w cikyla
//            // tuk se restartira broq4a za redowete 1111 pri preminawane na now red
//            for (int col = 0; col < 8; col++)
//            {
//                if ((col <= 7) && (matrix[row, col] == 1) && (matrix[row, col + 1] == 1))
//                    lenghtCOLCounter = 1;   // prowerqwa dali sme stignali do pred posledniq el
//                                             // zapo4wa ot 1 za da wklu4i purviq element bi trqbwalo da se izpylni samo wednuj
//                {                           // ako da da proveri posledniq w proitwen slu4ej 
//                    lenghtCOLCounter++;   //izlizame ot masiwa vyv vtoriq if pri posledniq el
//                }                          // prowerka za sledawhtiq el dali e 1              
//                                          // pri izpylneno uslowie pribavq oshte edin
//                if (maxLenghtCOLCounter < lenghtCOLCounter)
//                {
//                    maxLenghtCOLCounter = lenghtCOLCounter; // sled kato smetne dyljitnata prowerqwa 
//                    lineCOLCounter = 1;// ako LenghtCOLCounter w nqkoq ot predhodnite iteracii na vytreshniq cikyl e bila
//                    //syshto tolkowa golqma to tq sled izlizane ot vytre[niq cikyl se prebroqwa neposredstweno predi da se zanuli t.e. 1 zaedini:)
//                }
//            }
//            if (maxLenghtCOLCounter == lenghtCOLCounter)// ako LenghtROWCounter w nqkoq ot predhodnite iteracii na vytreshniq cikyl e bila
//            //syshto tolkowa golqma to tq sled izlizane ot vytre[niq cikyl se prebroqwa neposredstweno predi da se zanuli t.e. 1 zaedini:)
//            {
//                lineCOLCounter++;
//            }
//        }
//        for (int col = 0; col < 8; col++)
//        {
//            int lenghtROWCounter = 0;
//            for (int row = 0; row < 8; row++)
//            {
//                if ((row < 7) && (matrix[row, col] == 1) && (matrix[row + 1, col] == 1))
//                    lenghtROWCounter = 1;
//                {
//                    lenghtROWCounter++;
//                }
//                if (maxLenghtROWCounter < lenghtROWCounter) // prawime <= zada wleze w if-a taka posle prowerqwame dali sa ravni 
//                {
//                    maxLenghtROWCounter = lenghtROWCounter; // sled kato smetne dyljitnata prowerqwa                     
//                    lineROWCounter = 1; // ako ima nqkoq po-golqma liniq broq4a na liniite se slaga na 1 zashtoto zna4i 4e ima nowa po-golema linie
//                    // i e 1 za da prebroime samata neq
//                }                
//            }
//            if (maxLenghtROWCounter == lenghtROWCounter)// ako LenghtROWCounter w nqkoq ot predhodnite iteracii na vytreshniq cikyl e bila
//                //syshto tolkowa golqma to tq sled izlizane ot vytre[niq cikyl se prebroqwa neposredstweno predi da se zanuli t.e. 1 zaedini:)
//            {
//                lineROWCounter++;
//            }
//        }
//        //prowerka za izvejdane na rezultata
//        if (maxLenghtCOLCounter == maxLenghtROWCounter) // ako dwete dyljini sa ednakwi
//        {
//            Console.WriteLine(maxLenghtROWCounter);// izvejdame maksimalnata dyljina na edna ot dwete bez zna4enie
//            Console.WriteLine((lineCOLCounter+lineROWCounter)); //izvevdame sbora na liniite po red i kolona kato gi slagame w () za]oto ina4e 
//            // se edno dolepqme stringowe
//        }
//        if (maxLenghtCOLCounter>maxLenghtROWCounter)
//        {
//            Console.WriteLine(maxLenghtCOLCounter);
//            Console.WriteLine(lineCOLCounter);
//        }
//        else if (maxLenghtROWCounter>maxLenghtCOLCounter)
//        {
//            Console.WriteLine(maxLenghtROWCounter);
//            Console.WriteLine(lineROWCounter);        
//        }

//    }
//}
