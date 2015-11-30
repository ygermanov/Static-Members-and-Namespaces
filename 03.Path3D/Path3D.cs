using System;
using System.Collections.Generic;

namespace _03.Path3D
{
    class Path3D
    {
        static void Main(string[] args)
        {
            Path points = new Path();
            List<string> pointsFromFile = Storage.FillFromFile("points.txt");
            foreach (string v in pointsFromFile)
            {
                if (v != "")
                {
                    Point point = new Point();
                    point.ChangePoint(v);
                    points.AddPointToPath(point);
                }
            }
            string newPoint = string.Empty;
            Console.WriteLine("Enter X coordinate for new point: ");
            newPoint += Console.ReadLine() + " ";
            Console.WriteLine("Enter Y coordinate for new point: ");
            newPoint += Console.ReadLine() + " ";
            Console.WriteLine("Enter Z coordinate for new point: ");
            newPoint += Console.ReadLine();
            Storage.SaveToFile("points.txt", newPoint);

            Console.WriteLine(points.ToString());
        }
    }
}
