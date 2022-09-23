using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currPrice = double.Parse(Console.ReadLine());
            double diffBetweenCurrAndLastPrice = CheckDifferenceBetweenPrices(lastPrice, currPrice); 
            bool isThereADiff = IsThereADiff(diffBetweenCurrAndLastPrice, significanceThreshold);
            
            string message = PrintResult(currPrice, lastPrice, diffBetweenCurrAndLastPrice, isThereADiff);
            Console.WriteLine(message);

            lastPrice = currPrice;
        }
    }
    
    private static string PrintResult(double currPrice, double lastPrice, double diffBetweenCurrAndLastPrice, 
        bool isThereADiff)
    {
        string result = "";
        double finalDiff = diffBetweenCurrAndLastPrice * 100;
        if (diffBetweenCurrAndLastPrice == 0)
        {
            result = string.Format($"NO CHANGE: {currPrice}");
        }
        else if (!isThereADiff)
        {
            result = string.Format($"MINOR CHANGE: {lastPrice} to {currPrice} ({finalDiff:f2}%)");
        }
        else if (isThereADiff && (diffBetweenCurrAndLastPrice > 0))
        {
            result = string.Format($"PRICE UP: {lastPrice} to {currPrice} ({finalDiff:f2}%)");
        }
        else if (isThereADiff && (diffBetweenCurrAndLastPrice < 0))
            result = string.Format($"PRICE DOWN: {lastPrice} to {currPrice} ({finalDiff:f2}%)");
        return result;
    }
    private static bool IsThereADiff(double diffBetweenCurrAndLastPrice, double significanceThreshold)
    {
        if (Math.Abs(diffBetweenCurrAndLastPrice) >= significanceThreshold)
        {
            return true;
        }
        return false;
    }

    private static double CheckDifferenceBetweenPrices(double lastPrice, double currPrice)
    {
        double result = (currPrice - lastPrice) / lastPrice;
        return result;
    }
}
