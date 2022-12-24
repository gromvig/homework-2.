using System.Drawing;

namespace dots
{
    internal class Quadrilateral : Point
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        public Quadrilateral(Point A, Point B, Point C, Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public static double P(Quadrilateral QR)
        {
            return (dist(QR.A,QR.B) + dist(QR.B, QR.C) +dist(QR.C, QR.D) + dist(QR.D, QR.A));
        }
        public static double S(Quadrilateral QR)
        {
            return Math.Abs(dist(QR.A, QR.D) * dist(QR.B, QR.D) * Sin(QR.A - QR.C, QR.B - QR.D) / 2);
        }
       
        public static double Sin(Point p1, Point p2)
        {
            return Math.Sqrt(1 - Math.Pow(p1.scalar(p2) / (p1.dist0() * p2.dist0()), 2));
        }
        public static Point VectMult(Point p1, Point p2)
        {
            Point p3 = new Point(p1.Y * p2.Z - p1.Z * p2.Y, -(p1.X * p2.Z - p1.Z * p2.X), p1.X * p2.Y - p1.Y * p2.X);
            return p3;
        }
        public static double[] Diagon(Quadrilateral QR)
        {
            double D1 = dist(QR.A, QR.C);
            double D2 = dist(QR.B, QR.D);
            double[] Diagon = new double[2] { D1, D2 };
            return Diagon;
        }
        public static bool Сonvex(Quadrilateral Qr)
        {
            if (VectMult(Qr.B - Qr.A, Qr.C - Qr.B) / VectMult(Qr.A - Qr.D, Qr.B - Qr.A) &&
                VectMult(Qr.C - Qr.B, Qr.D - Qr.C) / VectMult(Qr.A - Qr.D, Qr.B - Qr.A) &&
                VectMult(Qr.D - Qr.C, Qr.A - Qr.D) / VectMult(Qr.A - Qr.D, Qr.B - Qr.A))
            {
                return true;
            }

            return false;
        }

    }
}
