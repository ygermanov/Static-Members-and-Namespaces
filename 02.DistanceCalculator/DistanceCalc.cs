using System;

namespace _02.DistanceCalculator
{
        static class DistanceCalc
        {
            public static double Distance(Point firstPoint, Point secondPoint)
            {
                double distance = 0d;
                distance = Math.Sqrt(
                    Math.Pow(firstPoint.coordX - secondPoint.coordX, 2) +
                    Math.Pow(firstPoint.coordY - secondPoint.coordY, 2) + 
                    Math.Pow(firstPoint.coordZ - secondPoint.coordZ, 2)
                    );
                return distance;
            }
        }
}
