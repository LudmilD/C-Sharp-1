using System;
/*Which of the following values can be assigned to a variable of type float and which
 * to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091*/
// use F10 
class Program
{
    static void Main()
    {
        float floats = 3456.091f;// exact
        floats = 12.345f;// exact
        double doubles = 34.567839023;// exact
        doubles = 8923.1234857;// exact
        floats = 34.567839023f;//floats	34.56784
        floats = 8923.1234857f;//floats	8923.123
        floats = (float)34.567839023;  //floats	34.56784
        floats = (float)8923.1234857;  //floats	8923.123
        floats = float.Parse("34.567839023");  //floats	34.56784 // convert to string with ""
        floats = float.Parse("8923.1234857");  //floats	8923.123

    }
}

