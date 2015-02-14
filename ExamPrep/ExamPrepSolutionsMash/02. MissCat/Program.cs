using System;

class Program
{
    static void Main()

    {
        // number of Juries
        int judge =int.Parse(Console.ReadLine());
        int cat1 = 0;
        int cat2 = 0;
        int cat3 = 0;
        int cat4 = 0;
        int cat5 = 0;
        int cat6 = 0;
        int cat7 = 0;
        int cat8 = 0;
        int cat9 = 0;
        int cat10 = 0;

        for (int i = 0; i < judge; i++)
        {
            int currentMark = int.Parse(Console.ReadLine());
            switch (currentMark)
            {
                //10 cats
                case 1: cat1++; break;
                case 2: cat2++; break;
                case 3: cat3++; break;
                case 4: cat4++; break;
                case 5: cat5++; break;
                case 6: cat6++; break;
                case 7: cat7++; break;
                case 8: cat8++; break;
                case 9: cat9++; break;
                case 10: cat10++; break;
                default: Console.WriteLine("nestawa"); break;
            }
        }
                int max = 0;
                int MaxCat = 0;

                if (cat1 > max)
                {
                    max = cat1;
                    MaxCat = 1;
                }
                if (cat2 > max)
                {
                    max = cat2;
                    MaxCat = 2;
                }
                if (cat3 > max)
                {
                    max = cat3;
                    MaxCat = 3;
                }
                if (cat4 > max)
                {
                    max = cat4;
                    MaxCat = 4;
                }
                if (cat5 > max)
                {
                    max = cat5;
                    MaxCat = 5;
                }
                if (cat6 > max)
                {
                    max = cat6;
                    MaxCat = 6;
                }
                if (cat7 > max)
                {
                    max = cat7;
                    MaxCat = 7;
                }
                if (cat8 > max)
                {
                    max = cat8;
                    MaxCat = 8;
                }
                if (cat9 > max)
                {
                    max = cat9;
                    MaxCat = 9;
                }
                if (cat10 > max)
                {
                    max = cat10;
                    MaxCat = 10;
                }


                Console.WriteLine(MaxCat);

        }

 }


