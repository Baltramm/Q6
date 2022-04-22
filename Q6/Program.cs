using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }
    class Triangle
    {
        private int a;
        private int b;
        private int c;
        public int A
        {
            get 
            {
                return a;
            }
            set 
            {
                if ((a<=0)&&(b+c>a))
                {
                    Console.WriteLine("Неверное значение");

                }
                else
                {
                    a = value;
                }
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                if ((b <= 0) && (a + c > b))
                {
                    Console.WriteLine("Неверное значение");

                }
                else
                {
                    b = value;
                }
            }
        }
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                if ((c <= 0) && (b + a > c))
                {
                    Console.WriteLine("Неверное значение");

                }
                else
                {
                    c = value;
                }
            }
        }


        public int P()
        {
            return a + c + b;
        }
        public double S()
        {
            int p = P();
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
    class Circle
    {
        public int r;
        public double S()
        {
            return r * r * Math.PI;
        }
        public double P()
        {
            return 2 * Math.PI * r;
        }
    }
    class Square
    {
        public int a;
        public int P()
        {
            return a * 4;
        }
        public double S()
        {
            return a * a;
        }
    }
}
