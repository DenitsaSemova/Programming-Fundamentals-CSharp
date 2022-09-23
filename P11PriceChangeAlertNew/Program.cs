using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double significanceThreshold = double.Parse(Console.ReadLine());

        double currPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double lastPrice = double.Parse(Console.ReadLine());
            double div = Proc(currPrice, lastPrice);
            bool isSignificantDifference = imaliDif(div, significanceThreshold);


            string message = Get(lastPrice, currPrice, div, isSignificantDifference);
            Console.WriteLine(message);

            currPrice = lastPrice;
        }
    }

    private static string Get(double lastPrice, double currPrice, double razlika, bool etherTrueOrFalse)

    {
        string to = "";
        if (razlika == 0)
        {
            to = string.Format("NO CHANGE: {0}", lastPrice);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", currPrice, lastPrice, razlika * 100);
        }
        else if (etherTrueOrFalse && (razlika > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", currPrice, lastPrice, razlika * 100);
        }
        else if (etherTrueOrFalse && (razlika < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", currPrice, lastPrice, razlika * 100);
        return to;
    }
    private static bool imaliDif(double significanceThreshold, double isDiff)
    {
        if (Math.Abs(significanceThreshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double currPrice, double lastPrice)
    {
        double difference = (lastPrice - currPrice) / currPrice;
        return difference;
    }
}
