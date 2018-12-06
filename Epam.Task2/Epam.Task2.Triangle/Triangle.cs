using System;
namespace Epam.Task2.Triangle
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get
            {
                return this.a;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                this.a = value;
            }
        }

        public double B
        {
            get
            {
                return this.b;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                this.b = value;
            }
        }

        public double C
        {
            get
            {
                return this.c;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }
                this.c = value;
            }
        }

        public Triangle()
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }

        public double Perimeter
        {
            get
            {
                return this.a + this.b + this.c;
            }
        }

        public double Area
        {
            get
            {
                double p = 0.5 * (this.a + this.b + this.c);
                double area = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 3);
                return area;
            }
        }
    }
}
