using System;
//http://www.youtube.com/watch?v=UPiodKGLsS4
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2012-2013 - C Sharp 1 Intermediate\Exam 1 at 28 Dec 2012
//http://bgcoder.com/Contest/Practice/80
class TelerikLogo
{
    static void Main()
    {
        int X = int.Parse(Console.ReadLine());
        int width = (X + X) + ((X / 2) + 1) + ((X / 2) + 1) - 3;
        int hornsLenght = X / 2;
        int middleDot = width - 2 * ((X / 2) + 1);
        Console.Write(new string('.', hornsLenght));
        Console.Write('*');
        Console.Write(new string('.', middleDot));
        Console.Write('*');
        Console.Write(new string('.', hornsLenght));
        middleDot -= 2;
        Console.WriteLine();
        int firstHornDots = X / 2 - 1;
        int dotsAfterHorn = 0;
        for (int i = 1; i < X - 1; i++)
        {
            //add realhorns
            if (i <= X / 2)
            {
                Console.Write(new string('.', firstHornDots));
                Console.Write('*');
                Console.Write(new string('.', dotsAfterHorn));
                //firstHornDots--;
                //dotsAfterHorn++; // namalqwame gi pri posledniq rog
            }
            else
            {
                Console.Write(new string('.', hornsLenght));
            }
           // Console.Write(new string('.', hornsLenght));

            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', middleDot));// V-to ot **
            Console.Write('*');
            Console.Write(new string('.', i));
            middleDot -= 2;
            //add real horns
            if (i <= X / 2)
            {
                Console.Write(new string('.', dotsAfterHorn));
                Console.Write('*');
                Console.Write(new string('.', firstHornDots));
                firstHornDots--;
                dotsAfterHorn++;
            }
            else
            {
                Console.Write(new string('.', hornsLenght));
            }                        
            //Console.Write(new string('.', hornsLenght));
            Console.WriteLine();
        }
        // srednata 4ast
        Console.Write(new string('.', width / 2));
        Console.Write('*');
        Console.WriteLine(new string('.', width / 2));

        int leftRightDots = X - 2;
        middleDot = 1;
        for (int i = 0; i < X - 1; i++)
        {
            Console.Write(new string('.', hornsLenght));
            Console.Write(new string('.', leftRightDots));
            Console.Write('*');
            Console.Write(new string('.', middleDot));
            Console.Write('*');
            Console.Write(new string('.', leftRightDots));
            Console.Write(new string('.', hornsLenght));
            middleDot += 2;
            leftRightDots--;
            Console.WriteLine();
        }
        middleDot -= 4; // predi sledwashtiq cikyl gi namalqwame 
        for (int i = 1; i < X - 1; i++)
        {
            Console.Write(new string('.', hornsLenght));
            Console.Write(new string('.', i));
            Console.Write('*');
            Console.Write(new string('.', middleDot));
            Console.Write('*');
            Console.Write(new string('.', i));
            Console.Write(new string('.', hornsLenght));

            middleDot -= 2;
            Console.WriteLine();
        }
        Console.Write(new string('.', width / 2));
        Console.Write('*');
        Console.WriteLine(new string('.', width / 2));
    }
}

