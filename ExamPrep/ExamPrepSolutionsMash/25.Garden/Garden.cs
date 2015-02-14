using System;
//http://www.youtube.com/watch?v=gq_18w_iqSI
//http://bgcoder.com/Contest/Practice/133
//C:\Users\Galleon\Desktop\C# 1\BgCoderC#1\Exam 1 2013 Jun - C Sharp 1\Variant 2 (2013-06-24)
class Garden
{
    static void Main()
    {
        decimal totalArea = 250;

        decimal tomatoPrise = 0.5m;
        decimal cucumberPrise = 0.4m;
        decimal potatoPrise = 0.25m;
        decimal carrotPrise = 0.6m;
        decimal cabbagePrise = 0.3m;
        decimal beansPrise = 0.4m;

        decimal tomatoSeeds = decimal.Parse(Console.ReadLine());
        decimal tomatoArea = decimal.Parse(Console.ReadLine());

        decimal cucumberSeeds = decimal.Parse(Console.ReadLine());
        decimal cucumberArea = decimal.Parse(Console.ReadLine());

        decimal potatoSeeds = decimal.Parse(Console.ReadLine());
        decimal potatoArea = decimal.Parse(Console.ReadLine());

        decimal carrotSeeds = decimal.Parse(Console.ReadLine());
        decimal carrotArea = decimal.Parse(Console.ReadLine());

        decimal cabbageSeeds = decimal.Parse(Console.ReadLine());
        decimal cabbageArea = decimal.Parse(Console.ReadLine());

        decimal beansSeeds = decimal.Parse(Console.ReadLine());

        decimal totalSeedCost =
            tomatoSeeds * tomatoPrise +
            cucumberSeeds * cucumberPrise +
           potatoSeeds*potatoPrise+
            carrotPrise * carrotSeeds +
            cabbagePrise * cabbageSeeds +
            beansPrise * beansSeeds;


        Console.WriteLine("Total costs: {0}", totalSeedCost);

        decimal resultArea = totalArea - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
        if (resultArea > 0)
        {
            Console.WriteLine("Beans area: {0}", resultArea);
        }
        else if (resultArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        else if (resultArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }

    }
}

