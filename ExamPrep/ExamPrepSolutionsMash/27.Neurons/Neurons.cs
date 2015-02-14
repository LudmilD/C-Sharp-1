using System;
//http://www.youtube.com/watch?v=OnRRd94NHv4
//http://bgcoder.com/Contest/Practice/131
class Neurons
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        // poneje nqma opredelena broika whodni danni 
        while (inputLine != "-1")// srawnqwame stringowe i ako pyrwiq e razli4en ot 0 po askii 39 maj shte wleze w cikyla
        {// sled kato wlezem sys stringa parswame pyrwoto 4islo
            uint inputNumber = uint.Parse(inputLine);
            //### string w char arr !!!
               char[] currentNumberBinaryDigits = Convert.ToString(inputNumber, 2).
                PadLeft(32, '0').ToCharArray();
            
            
            
            //Console.WriteLine(new string(currentNumberBinaryDigits));// prowerka za prestawqneto
            //Console.WriteLine(currentNumberBinaryDigits.Length);// prowerka za dyljinata
            bool isInsideNeuron = false;
            bool isOnBoundary = false;
            bool beenInNeuron = false; //##1 yyy nqkwa prezumciq 4e sme bili w newron 
            // za da oprawim byga s 111 ite sled izlizane ot nevrona 
            // if (!beenInNeuron && isOnBoundary) uslowie na red 36
            for (int i = 0; i < currentNumberBinaryDigits.Length; i++)
            {
                if (currentNumberBinaryDigits[i] == '1')
                {// ako sme nagranicata
                    isOnBoundary = true;
                    if (isInsideNeuron)
                    {// razlikata da ne ni dopiswa 11 sled izlizane ot granicata 
                        isInsideNeuron = false;
                        beenInNeuron = true;// ei go byga !!! kogato sme v nevron togawa sme bili :)
                    }
                    currentNumberBinaryDigits[i] = '0';
                }
                else if (currentNumberBinaryDigits[i] == '0')
                {
                    if (!beenInNeuron && isOnBoundary)//(beenInNeuron== false && isOnBoundary) 
                    {// ako sme na granicata no ne sme bili w nevron dekmek 11 slu4ei
                        isInsideNeuron = true;
                        isOnBoundary = false;
                        //beenInNeuron = false;// beshe true ##1//##2 mestime go na gore 31 red
                    }
                    if (isInsideNeuron)
                    {
                        currentNumberBinaryDigits[i] = '1';
                    }

                }
            }

            if (!beenInNeuron)
            {
                //currentNumberBinaryDigits[i] = '0';
                
                Console.WriteLine(0);//?
            }
            else
            {
                uint resultNumber = Convert.ToUInt32(new string(currentNumberBinaryDigits), 2);
                Console.WriteLine(resultNumber);
               // Console.WriteLine(new string(currentNumberBinaryDigits));
            }
            inputLine = Console.ReadLine();
        }
    }
}

