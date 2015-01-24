using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyGame
{
    struct Rock
    {
        public int x;// lenta
        public int y;// kolko blizo
        public char c;
        public ConsoleColor color;

    }
    class Program
    {//poziciq, x,y, simwol, cwqt po podrazbirane
        static void PrintOnPosition(int x, int y, char c,
            ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);// koorinati na koito slaga simwol
            Console.ForegroundColor = color;
            Console.Write(c);
        }
        static void PrintStringOnPosition(int x, int y, string str,
            ConsoleColor color = ConsoleColor.Gray)
        {
            Console.SetCursorPosition(x, y);// koorinati na koito slaga simwol
            Console.ForegroundColor = color;
            Console.Write(str);
        }
        static void Main()
        {
            double increceSpeed = 0;
            double acceleration = 0.5;


            int playfieldWidth = 5; // shirina na igralnoto pole
            int livesCOunt = 5;
            Console.BufferHeight = Console.WindowHeight = 30;
            Console.BufferWidth = Console.BufferWidth = 50;

            //usercar
            Rock userCar = new Rock();
            userCar.x = 2;//start position
            userCar.y = Console.WindowHeight - 1;//start position
            userCar.c = '@';//symbol car
            userCar.color = ConsoleColor.Yellow;// color
            Random randomGenerator = new Random();

            List<Rock> cars = new List<Rock>();// list of cars with Cars property x ,y, c,colour but in addition we use add option form list property
            while (true)
            {
                if (increceSpeed > 400)
                {
                    increceSpeed += acceleration;
                }

                bool hitted = false;
                //create car
                {//skobite otdelqt newCar ot tuk s newcCar w for cikyla kydeto promenqme y za da dwijime kolichkite
                    Rock newCar = new Rock();
                    newCar.color = ConsoleColor.Green;
                    newCar.x = randomGenerator.Next(0, playfieldWidth);//0-4 beside pW=5
                    newCar.y = 0;//appear on the top
                    newCar.c = '%';
                    cars.Add(newCar);// dobavqme nowata kolichka zapisana w spisyk
                }
                //## Move your car (keyread)// read key = drive car
                if (Console.KeyAvailable)// check is key is pressed if pressed - read key else go down the code
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);//read key
                    while (Console.KeyAvailable) Console.ReadKey(true);/*read buffer if there are any*/ /*clear buffer keys and read the ast key*/
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (userCar.x - 1 >= 0)// we wont get out of the console buffer/field
                        {
                            userCar.x--;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (userCar.x + 1 < playfieldWidth)// we wont get out of the console buffer/field
                        {
                            userCar.x++;
                        }
                    }
                }
                //##  Move other Cars
                List<Rock> newList = new List<Rock>(); // zaradi neadekwatnoto dvijenie prawime now spisyk s koli4ki
                // kato swyrshime dobavqneto na nowi elementi na novite kolichki ot stariq spisyk
                // naj nakraq smenqme referenciqta cars = newList; t.e. kym stariq spisyk dobavqme nowi kolichki 
                for (int i = 0; i < cars.Count; i++)
                {// uwelichawa Y koordinatite na wsqka kolichka
                    Rock oldCar = cars[i];// wzimame elemnt ot masiwa s kolichkire
                    Rock newCar = new Rock();// nowa kolichka sys sy]ite swojstwa na starata
                    newCar.x = oldCar.x;
                    newCar.y = oldCar.y + 1;//samo za radi towa pisahme wsi4ko ostanalo :D
                    newCar.c = oldCar.c;
                    //## CHeck if Hitted
                    newCar.color = oldCar.color;
                    if (newCar.y == userCar.y && newCar.x == userCar.x)
                    {//prowerka dali nowata kolichka sywpada s mqstoot na nashata ako da maha jiwoti
                        livesCOunt--;
                        hitted = true;// flad za ubyr
                        if (increceSpeed < 400)
                        {
                            increceSpeed += 50;// uweli4awame skorosta pri umirane
                        }
                        
                        if (hitted)
                        {
                            PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);
                        }
                        if (livesCOunt <= 0)
                        {// proverka za priklu4wane na igrata
                            PrintStringOnPosition(8, 7, " GAY OVER ! ! !", ConsoleColor.Red);
                            PrintStringOnPosition(8, 12, " Pres ENTER to exit! ! !", ConsoleColor.Red);
                           
                            Console.ReadLine();// iz4akwasht operator i4akwa da se natisne nqkoj key
                            return; // spirame main metoda
                            // Environment.Exit(0);
                        }
                    }
                    if (newCar.y < Console.WindowHeight)
                    {// za da ne hwyrlq exeption kogato generiranite kolichki stignat  do dolu
                        newList.Add(newCar);
                    }
                }
                cars = newList;// dobavqne na nowite kolichki s novi elementi kym stariq spisyk

                //## Clear the console
                Console.Clear();
                //

                if (hitted)
                {
                    cars.Clear();
                    PrintOnPosition(userCar.x, userCar.y, 'X', ConsoleColor.Red);// pri udyr registrira s druc simvol i cwqt
                }
                else
                {
                    PrintOnPosition(userCar.x, userCar.y, userCar.c, userCar.color);
                }
                foreach (Rock car in cars)
                {//## draw othe cars
                    PrintOnPosition(car.x, car.y, car.c, car.color);
                }
                //## Draw INfo //## score
                PrintStringOnPosition(10, 4, "Lives: " + livesCOunt, ConsoleColor.White);
                PrintStringOnPosition(10, 5, "Speed: " + increceSpeed, ConsoleColor.White);
                PrintStringOnPosition(10, 7, "Speed: " + acceleration, ConsoleColor.White);
                 
                //## Slow fown
                SpeedUP(increceSpeed);


            }
        }
        //## speed up
        private static double SpeedUP(double increceSpeed)
        {
            double speed = 100 + increceSpeed;
            Thread.Sleep((int)(600 - speed));
            return speed;
        }
    }
}
