using System;
/*Problem 10.*  Beer Time
A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time 
 * in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
 * and prints “beer time” or “non-beer time” according to the definition above or “invalid time”
 * if the time cannot be parsed. Note that you may need to learn how to parse dates and times. */
class Program
{
    static void Main()
    {
        string time = "2:26 AM"; //hh:mm tt"
        DateTime beerTime;
        bool isTime = DateTime.TryParse(time, out beerTime);
        if (!isTime)
        {
            Console.WriteLine("invalid time");
        }
        else
        {
            int hour = beerTime.Hour;
            bool isBeerTime = (hour >= 13 || hour < 3);

            switch (isBeerTime)
            {
                case true:
                    Console.WriteLine("beer time");
                    break;
                case false:
                    Console.WriteLine("non-beer time");
                    break;
                default:
                    Console.WriteLine("no need of defoult ");
                    break;
            }            
        }
    }
}

