//using System;

//class Program
//{
//    static void Main()
//    {
//        decimal rectLeftX = -1;// ima se predwid most left stranata po x
//        decimal rectTopY = 1; //ima se predvid nai wisokata 4ast t.e. cqlata strana
//        decimal rertWidhtX = 6;// po X dostigashta koordinati (rertWidhtX -rectLeftX)
//        decimal rectHeightY = 2;// po Y (rectTopY-rectHeightY)
//        decimal[] dotX = new decimal[] { 1, 2.5m, 0, 2.5m, 2, 4, 2.5m, 1, -100 };
//        //{ 0, -2, -1, 1.5, -1.5, 100, 0, 0.2, 0.9, 1 };
//        decimal[] dotY = new decimal[] { 2, 2, 1, 1, 0, 0, 1.5m, 2.5m, -100 };

//        bool xInside = false;
//        bool yINSIDE = false;
//        bool rectIN = false;
//        for (int i = 0; i < dotX.Length; i++)
//        {
//            if ((dotX[i] >= rectLeftX && dotX[i] <= rertWidhtX + rectLeftX) && (dotY[i] <= rectTopY && rectTopY - rectHeightY <= dotY[i]))
//            {
//                rectIN = true;
//            }
//            else
//            {
//                rectIN = false;
//            }
//             if (rectIN)
//             {
//                 Console.WriteLine("IN");
//             }
//             else
//             {
//                 Console.WriteLine("OUT");
//             }
//        }
//        //for (int i = 0; i < dotX.Length; i++)
//        //{
//        //    decimal dotXX = dotX[i];
//        //    decimal dotYY = dotY[i];
//        //    if ((dotXX >= -1) && dotXX <= 5)  /* rertWidhtX + rectLeftX*/
//        //    {
//        //        // isOUT X dimention
//        //        xInside = true;//inside
//        //    }
//        //    else
//        //    {
//        //        xInside = false;//in
//        //    }

//        //    if (dotYY <= 1 && -1 <= dotYY /*rectTopY - rectHeightY*/)
//        //    {
//        //        //isOUT Y dunebtuib
//        //        yINSIDE = true;//out
//        //    }
//        //    else
//        //    {
//        //        yINSIDE = false;//in
//        //    }

//        //    if (/*! isoutY && isoutX*/xInside && yINSIDE)
//        //    {
//        //        // is in 
//        //        rect = true;
//        //    }
//        //    else
//        //    {
//        //        rect = false;
//        //    }

//        //    if (rect)
//        //    {
//        //        Console.WriteLine("IN");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("OUT");
//        //    }
//        //}


//    }
//}

///*((Point.X <= Rect.topLeftX) && (Point.X >= Rect.width)) ||
//             ((Point.Y >= Rect.topLeftY) && (Point.Y <= Rect.height)))*/
