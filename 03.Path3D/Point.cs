using System;

namespace _03.Path3D
{
    class Point
    {
        public int coordX { get; set; }
        public int coordY { get; set; }
        public int coordZ { get; set; }
        public Point()
            : this(0, 0, 0)
        {

        }
        public Point(int CoordX, int CoordY, int CoordZ)
        {
            this.coordX = CoordX;
            this.coordY = CoordY;
            this.coordZ = CoordZ;
        }
        public void ChangePoint(string str)
        {
            string[] temp = str.Split(' ');
            this.coordX = int.Parse(temp[0]);
            this.coordY = int.Parse(temp[1]);
            this.coordZ = int.Parse(temp[2]);
        }
        public override string ToString()
        {
            string pointPosition = string.Format("X coordinate: {0}\nY coordinate: {1}\nZ coordinate: {2}",
                this.coordX, this.coordY, this.coordZ);

            return pointPosition;
        }
        static readonly Point startingPoint = new Point(0, 0, 0);
        public Point StartingPoint 
        {
            get { return startingPoint; }
        }
    }
}
