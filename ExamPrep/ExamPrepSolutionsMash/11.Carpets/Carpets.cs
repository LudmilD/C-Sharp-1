using System;

class Program
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        int elementOnLInes = lines+1;// +1 coluns +2 more coluns.. 
        int center = lines / 2;

        for (int i = 1; i <= center; i++)// otgowarq za redowete n/2
        {
            int elPos = 1; // pomnime poziciqta na elmenta
            while (elPos <= elementOnLInes)// otgovarq za kolonite do n i poneje 
            {// ne izlizat edni to4ki nakraq sladame +1 za krainiq element
                int leftCHeck = center - i;
                int rightCheck = center + i;
                bool leftDot = (elPos <= leftCHeck);
                bool rightDot = (elPos > rightCheck);
                if (leftDot || rightDot)
                {
                    Console.Write('.');
                    // elPos++;
                }
                else
                {
                    // Console.Write('#');
                    for (int j = 0; j < i; j++)
                    {// for za lqwata 4ast
                        if (j % 2 == 0)
                        {
                            Console.Write('/');
                            //        elPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            //        elPos++;
                        }
                        elPos++;
                    }
                    for (int j = i; j > 0; j--)
                    {// za dqsnata 4at
                        if (j % 2 != 0)// != za da se polu4i edno do drugo simetri4no
                        {
                            Console.Write('\\');
                            // elPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            // elPos++;
                        }
                        elPos++;
                    }
                }

                elPos++;

            }
            Console.WriteLine();
        }
        //#################################################################################
        //wtorata polowina
        for (int i = center; i >= 1; i--)
        {
            int elPos = 1; // pomnime poziciqta na elmenta
            while (elPos <= elementOnLInes)
            {
                if ((elPos <= center - i) || (elPos > center + i))
                {
                    Console.Write('.');
                    //elPos++;
                }
                else
                {
                    //Console.Write('#');
                    for (int j = 0; j < i; j++)
                    {// for za lqwata 4ast
                        if (j % 2 == 0)
                        {
                            Console.Write('\\');
                            //elPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            //   elPos++;
                        }
                        elPos++;
                    }
                    for (int j = i; j > 0; j--)
                    {// za dqsnata 4at 
                        if (j % 2 != 0)
                        {
                            Console.Write('/');
                            //   elPos++;
                        }
                        else
                        {
                            Console.Write(" ");
                            //   elPos++;
                        }
                        elPos++;
                    }
                }
                elPos++;
            }
            Console.WriteLine();
        }
    }
}

