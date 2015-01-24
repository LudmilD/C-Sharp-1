using System;
/*Problem 10.	Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is
 * within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 
*/
class Program
{
    static void Main()
    {
        bool inCircle = true;
        bool inRectangle = true;
        decimal circleXX = 1;//define cirgle center
        decimal circleYY = 1;//define circle center
        decimal radius = 1.5m;

        decimal rectLeftX = -1;// ima se predwid most left stranata po x
        decimal rectTopY = 1; //ima se predvid nai wisokata 4ast t.e. cqlata strana
        decimal rertWidhtX = 6;// po X dostigashta koordinati (rertWidhtX -rectLeftX)
        decimal rectHeightY = 2;// po Y (rectTopY-rectHeightY)

        decimal[] dotX = new decimal[] { 1, 2.5m, 0, 2.5m, 2, 4, 2.5m, 1, -100 };
        //{ 0, -2, -1, 1.5, -1.5, 100, 0, 0.2, 0.9, 1 };
        decimal[] dotY = new decimal[] { 2, 2, 1, 1, 0, 0, 1.5m, 2.5m, -100 };
        //{ 1, 0, 2, -1, -1.5, -30, 0, -0.8, -1.93, 1.655 };
        for (int i = 0; i < dotX.Length; i++)
        {
            inCircle = IsDotInCircle(circleXX, circleYY, radius, dotX, dotY, i);
            inRectangle = IsDotOutRectangle(rectLeftX, rectTopY, rertWidhtX, rectHeightY, dotX, dotY, i);
            if (inCircle == true && inRectangle == false)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
    //###
    static bool IsDotInCircle(decimal circleXX, decimal circleYY, decimal radius,
            decimal[] dotX, decimal[] dotY, int i)
    {
        double circleCheck = Math.Pow((double)(dotX[i] - circleXX), 2) + Math.Pow((double)(dotY[i] - circleYY), 2);//(x-a)^2 + (y-b)^2
        double radiusCheck = Math.Pow((double)(radius), 2);
        if (circleCheck <= radiusCheck)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    static bool IsDotOutRectangle(decimal rectLeftX, decimal rectTopY, decimal rertWidhtX,
       decimal rectHeightY, decimal[] dotX, decimal[] dotY, int i)
    {
        if ((dotX[i] >= rectLeftX && dotX[i] <= rertWidhtX + rectLeftX) && (dotY[i] <= rectTopY && rectTopY - rectHeightY <= dotY[i]))
        {
            return true;//IN
        }
        else
        {
            return false;//OUT
        }
    }
}