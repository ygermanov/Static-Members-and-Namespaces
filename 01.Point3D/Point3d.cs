using System;

namespace _01.Point3D
{
    class Point3D
    {
        static void Main()
        {
            Point point3D = new Point(4,6,7);

            Console.WriteLine("Starting point coordinates are: \n{0}", point3D.StartingPoint);
            Console.WriteLine("Point coordinates are: \n{0}", point3D.ToString());
        }
    }
}
