using System;

namespace P10_CubeProperties
{
    class P10_CubeProperties
    {
        static void Main(string[] args)
        {
            var cubeEdgeLenght = double.Parse(Console.ReadLine());
            var cubeProperty = Console.ReadLine();
            double result = 0;
            switch (cubeProperty)
            {
                case "face":
                    result = GetCubeFaceDiagonal(cubeEdgeLenght);
                    break;
                case "space":
                    result = GetCubeSpaceDiagonal(cubeEdgeLenght);
                    break;
                case "volume":
                    result = GetCubeVolume(cubeEdgeLenght);
                    break;
                case "area":
                    result = GetCubeArea(cubeEdgeLenght);
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }

        private static double GetCubeSpaceDiagonal(double cubeEdgeLenght)
        {
            var faceDiagonal = GetCubeFaceDiagonal(cubeEdgeLenght);
            return Math.Sqrt(faceDiagonal * faceDiagonal + cubeEdgeLenght * cubeEdgeLenght);
        }

        private static double GetCubeFaceDiagonal(double cubeEdgeLenght)
        {
            return Math.Sqrt(cubeEdgeLenght * cubeEdgeLenght * 2);
        }

        static double GetCubeVolume(double cubeEdgeLenght)
        {
            return cubeEdgeLenght * cubeEdgeLenght * cubeEdgeLenght;
        }

        static double GetCubeArea(double cubeEdgeLenght)
        {
            return cubeEdgeLenght * cubeEdgeLenght * 6;
        }
    }
}