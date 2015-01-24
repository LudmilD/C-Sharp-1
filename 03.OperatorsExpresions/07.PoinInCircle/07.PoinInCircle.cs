using System;
/*Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples*/
class Program
{
    static void Main()
    {
        double circleXX = 0;
           // 1;
        double circleYY = 0;
           // 1;//
        double radius = 2;
           // 1.5;
        
        

        //double[] pointXX = new double[] { 1, 2.5, 0, 2.5, 2, 4, 2.5, 1, -100 };
        //double[] pointYY = new double[] { 2, 2, 1, 1, 0, 0, 1.5, 2.5, -100 }; 

        double[] pointXX = new double[] { 0, -2, -1, 1.5, -1.5, 100, 0, 0.2, 0.9, 1 };
        double[] pointYY = new double[] { 1, 0, 2, -1, -1.5, -30, 0, -0.8, -1.93, 1.655 };
       
        // proverqwame s pitagorowate teorema dali tochkata leji na obryjnostta
        // kato wklu4wame i uslovieto 4e circleXX circleYY  i radius biha mogli da se
        //promenqt i pak rezultata da e weren
        // ako (x-a)^2 + (y-b)^2 = r^2 e izpylneno to tochkata leji na okryjnostta ili 
        // formulata s koreni ne raboti
        Console.WriteLine("X    Y     inside");
        for (int i = 0; i < pointXX.Length; i++)
        {
            double circleCheck = Math.Pow((pointXX[i] - circleXX), 2) + Math.Pow((pointYY[i] - circleYY), 2);//(x-a)^2 + (y-b)^2
            double radiusCheck = Math.Pow(radius, 2);
            
            bool inside = false;
            if (circleCheck <= radiusCheck)
            {
                inside = true;
            }
            else
            {
                inside = false;
            }

            Console.WriteLine(string.Format("{0,-5}{1,-6}{2,-5}", pointXX[i], pointYY[i], inside));
        }



    }
}

