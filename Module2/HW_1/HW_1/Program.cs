using System;

namespace HW_1
{
    class Point
    {
        private double X { get; set; }
        private double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point() : this (0,0) { }

        public double Ro
        {
            get
            {
                return Math.Sqrt(Y * Y + X * X);
            }
        }

        public double Fi
        {
            get
            {
                if (X > 0 && Y >= 0)
                {
                    return Math.Atan(Y / X);
                }
                else if (X > 0 &&  Y < 0)
                {
                    return Math.Atan(Y / X) + 2 * Math.PI;
                }
                else if (X < 0)
                {
                    return Math.Atan(Y / X) + Math.PI;
                }
                else if (X == 0 && Y > 0)
                {
                    return Math.PI / 2;
                }
                else if (X == 0 && Y < 0)
                {
                    return 3 * Math.PI / 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        public String PointData
        {
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }

        public static void Main()
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c.X = x; c.Y = y;
                Point[] points = new Point[3];
                points[0] = a;
                points[1] = b;
                points[2] = c;
            } while (x != 0 | y != 0);
        }
    }
}
