using System;

namespace P10CubeProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double calculation = PrintCubeCalculation(side, parameter);
            Console.WriteLine($"{calculation:f2}");
        }

        static double PrintCubeCalculation(double side, string parameter)
        {

            double result = 0;

            if (parameter == "face")
            {
                double face = Math.Sqrt(2 * side * side);

                result = face;
            }
            else if (parameter == "space")
            {
                double space = Math.Sqrt(3 * side * side);

                result = space;
            }
            else if (parameter == "volume")
            {
                double volume = side * side * side;

                result = volume;
            }
            else if (parameter == "area")
            {
                double area = 6 * (side * side);

                result = area;
            }  

            return result;
        }
       
    }
}
