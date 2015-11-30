using System;
using System.Collections.Generic;

namespace _03.Path3D
{
    class Path
    {
        public List<Point> points { get; set; }

        public Path()
        {
            this.points = new List<Point>();
        }

        //static private Path userPath = new Path();

        public void AddPointToPath(Point userPoint)
        {
            this.points.Add(userPoint);
        }
        //public List<string> TakePoints()
        //{
        //    List<string> takePoints = new List<string>();
        //    foreach (Point v in points)
        //    {
        //        string temp = "" + v.coordX.ToString() + v.coordY.ToString() + v.coordZ.ToString();
        //        takePoints.Add(temp);
        //    }
        //    return takePoints;
        //}
        public override string ToString()
        {
            int count = 1;
            foreach (Point v in points)
            {
                Console.WriteLine("{0} point is with coordinates {1} {2} {3}", count, v.coordX, v.coordY, v.coordZ);
                count++;
            }
            return "";
        }
        
    }
}
