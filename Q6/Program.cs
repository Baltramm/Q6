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
        public int a;
        public int b;
        public int c;

        public int P()
        {
            return a + c + b;
        }
        public double S()
        {
            int p = P();
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
    class Circle
    {
        public int r;
        public double S()
        {
            return r*r*Math.PI;
        }
        public double P()
        {
            return 2*Math.PI*r;
        }
    }
    class Square
    {
        public int a;
        public int P()
        {
            return a*4;
        }
        public double S()
        {
            return a*a;
        }
    }

    }
