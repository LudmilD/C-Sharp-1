using System;

class Program
{
    static void Main()
    {
       int? intNull=null;
       int one = 1;
       double? doubleNul=null;
       double two = 2.1;
       //intNull = intNull+one; // nul+number = null ; ako imame aritmetichni dejstwiq tqbwa da inicializirame sotijnost dori tq da e null
        
       doubleNul=intNull;// nullable object must have a value
        intNull = one;
       // one = null; //err
       doubleNul = two;
       Console.WriteLine("resuylt int? intNull={0} double?={1}",intNull,doubleNul);
      
    }
}

