using System;

namespace CW_2
{
    class MyComplex
    {
        private double re { get; set; }
        private double im { get; set; }
        public MyComplex(double xre, double xim)
        {
            re = xre; im = xim;
        }
        public static MyComplex operator ++(MyComplex mc)
        {
            return new MyComplex(mc.re + 1, mc.im + 1);
        }
        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.re - 1, mc.im - 1);
        }
        public double Mod() 
        { 
            return Math.Abs(re * re + im * im);
        }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }

        public static MyComplex operator +(MyComplex m1, MyComplex m2)
        {
            return new MyComplex(m1.re + m2.re, m1.im + m2.im);
        }

        public static MyComplex operator -(MyComplex m1, MyComplex m2)
        {
            return new MyComplex(m1.re - m2.re, m1.im - m2.im);
        }

        public static MyComplex operator *(MyComplex m1, MyComplex m2)
        {
            return new MyComplex(m1.re * m2.re - m1.im * m2.im, m1.im * m2.re + m1.re * m2.im);
        }

        public static MyComplex operator /(MyComplex m1, MyComplex m2)
        {
            return new MyComplex((m1.re * m2.re + m1.im * m2.im) / (m2.re * m2.re + m2.im + m2.im), (m1.im * m2.re - m1.re * m2.im) 
                / (m2.re * m2.re + m2.im + m2.im));
        }

        static void Main(string[] args)
        {
            MyComplex myComplex1 = new MyComplex(1, 2);
            MyComplex myComplex2 = new MyComplex(1, 2);
            Console.WriteLine((myComplex1 + myComplex2).re);
            Console.WriteLine((myComplex1 - myComplex2).re);
            Console.WriteLine((myComplex1 * myComplex2).re);
            Console.WriteLine((myComplex1 / myComplex2).re);
        }
    }
}
