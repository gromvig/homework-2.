using System.Drawing;

namespace dots
{
    internal class Point
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }
        public Point(double x = 0 , double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public static double dist(Point p1,Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y) + (p1.Z - p2.Z) * (p1.Z - p2.Z));
        }
        public double dist0()
        {
            return Math.Sqrt((0 - X) * (0 - X) + (0 - Y) * (0 - Y) + (0 - Z) * (0 - Z));
        }
        public double scalar(Point p2)
        {
            return X * p2.X + Y * p2.Y + Z * p2.Z;
        }
        public double vectori(Point p2)
        {
            return (Y * p2.Z - Z * p2.Y);
        }
        public double vectorj(Point p2)
        {
            return (Z * p2.X - X * p2.Z);
        }
        public double vectork(Point p2)
        {
            return (X * p2.Y - Y * p2.X);
        }

        public double sumX(Point p2)
        {
            return X + p2.X;
        }
        public double sumY(Point p2)
        {
            return Y + p2.Y;
        }
        public double sumZ(Point p2)
        {
            return Z + p2.Z;
        }
        public string straight(Point p2)
        {
            double A = (p2.Y - Y) * (p2.Z - Z);
            double B = (p2.X - X) * (p2.Z - Z);
            double C = (p2.X - X) * (p2.Y - Y);
            double X1 = -X * A;
            double Y1 = -Y * B;
            double Z1 = -Z * C;
            double D = X1 - Y1 - Z1;
            return Convert.ToString(A) + "x + " + Convert.ToString(B) + "y + " + Convert.ToString(C) + "z + " + Convert.ToString(D) + " = 0";
           
        }
        public static string flat(Point p1,Point p2, Point p3)
        {
            double A = p1.Y * (p2.Z - p3.Z) + p2.Y * (p3.Z - p1.Z) + p3.Y * (p1.Z - p2.Z);
            double B = p1.Z * (p2.X - p3.X) + p2.Z * (p3.X - p1.X) + p3.Z * (p1.X - p2.X);
            double C = p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y);
            double D = -(p1.X * (p2.Y * p3.Z - p3.Y * p2.Z) + p2.X * (p3.Y * p1.Z - p1.Y * p3.Z) + p3.X * (p1.Y * p2.Z - p2.Y * p1.Z));
            return Convert.ToString(A) + "x + " + Convert.ToString(B) + "y + " + Convert.ToString(C) + "z + " + Convert.ToString(D) + " = 0";
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);
        }
        public static bool operator /(Point p1, Point p2)
        {
            return p1.X / p2.X >= 0 && p1.Y / p2.Y >= 0;
        }
    }
}

