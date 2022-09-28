using System;

namespace P11GeometryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string figureType = Console.ReadLine();
            double result = 0;

            switch (figureType)
            {
                                
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    result = GetTriangleArea(side, height);
                    break;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());
                    result = GetSquareArea(squareSide);
                    break;
                case "rectangle":
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    result = GetRectangleArea(rectangleWidth, rectangleHeight);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    result = GetCircleArea(radius);
                    break;
            }

            Console.WriteLine($"{result:f2}");
        }

        static double GetTriangleArea(double side, double height)
        {
            double area = 0.5 * (side * height);
            return area;
        }

        static double GetSquareArea(double squareSide)
        {
            double area = squareSide * squareSide;
            return area;
        }

        static double GetRectangleArea(double rectangleWidth, double rectangleHeight)
        {
            double area = rectangleHeight * rectangleWidth;
            return area;
        }

        static double GetCircleArea(double radius)
        {
            double area = radius * radius * Math.PI;
            return area;
        }
    }
}
