using System;

namespace _02.DistanceCalculator
{
        class DistanceCalculator
        {
            static void Main(string[] args)
            {
                Point firstPoint = new Point(7, 8, 10);
                Point secondPoint = new Point(6, 9, 3);
                Console.WriteLine(DistanceCalc.Distance(firstPoint, secondPoint));
            }
        }
}
