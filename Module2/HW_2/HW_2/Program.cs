using System;

namespace Task1
{

    class ConsolePlate
    {
        char plateChar;
        ConsoleColor plateColor = ConsoleColor.White; // цвет символа
        public ConsoleColor PlateColor
        {
            get
            {
                return plateColor;
            }
            set
            {
                plateColor = value;
            }
        }
        public char PlateChar
        {
            set
            {
                if (value > 31)
                    plateChar = value;
                else
                    plateChar = '+';
            }
            get { return plateChar; }
        }
        public ConsolePlate()
        {
            plateChar = '+';
        }
        public ConsolePlate(char plateChar, ConsoleColor plateColor)
        {
            this.plateChar = plateChar;
            this.plateColor = plateColor;
        }

    }

    class MyComplex
    {
        public double im { get; set; }
        public double re { get; set; }
        public MyComplex(double xre, double xim)
        {
            this.re = xre;
            this.im = xim;
        }
        public static MyComplex operator ++(MyComplex mc)
        {
            return new(mc.re + 1, mc.im + 1);
        }
        public static MyComplex operator --(MyComplex mc)
        {
            return new(mc.re - 1, mc.im - 1);
        }
        public double Mod()
        {
            return Math.Abs(re * re + im * im);
        }
        public static bool operator true(MyComplex f)
        {
            if (f.Mod() > 1)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1)
            {
                return true;
            }
            return false;
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new(a.re + b.re, a.im + b.im);
        }
        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new(a.re - b.re, a.im - b.im);
        }
        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new(a.re * b.re - a.im * b.im, a.im * b.re + b.im * a.re);
        }
        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            return new((a.re * b.im + b.re * a.im) / (b.im * b.im + b.re * b.re), (a.re * b.im - b.re * a.im) / (b.im * b.im + b.re * b.re));
        }

        public static implicit operator string(MyComplex a)
        {
            return a.im + " " + a.re + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
