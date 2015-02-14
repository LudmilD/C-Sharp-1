using System;

class Program
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();
        int sum = 0;
        while (true)
        {
            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (!(inputNumber[i] == '.' || inputNumber[i] == '-'))// na4alna proverka
                {
                    sum += int.Parse(inputNumber[i].ToString());
                    // inputNumber[i] se qwqwa char , koito se konvertiryk ToString()
                    // i togawa moje da se parsne kym int za da se pribavi kym sum.
                }
            }
            if (sum < 10) break; //ako sum e po malko ot 9 prekuswa cikula i pe4ata sum
            inputNumber = sum.ToString();
            sum = 0;// danulqwa sum z da moje da se priswoqwat novi stoinosti
        }
        Console.WriteLine(sum);
    }
}

