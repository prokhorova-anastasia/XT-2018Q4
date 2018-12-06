using System;
namespace Epam.Task2.Round
{
    public class Round
    {
        private double x;
        private double y;
        private double radius;

        public double X
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception();
                }

                this.radius = value;
            }
        }

        public Round()
        {
            this.x = X;
            this.y = Y;
            this.radius = Radius;
        }

        public double LengthRound
        {
            get
            {
                if (this.radius >= 0)
                {
                    return Math.PI * 2 * this.radius;
                }
                else
                {
                    Console.WriteLine("This is bad round, it doesn't have length:(");
                    return -1;
                }
            }
        }

        public double Area
        {
            get
            {
                if (this.radius >= 0)
                {
                    return Math.PI * this.radius * this.radius;
                }
                else
                {
                    Console.WriteLine("This is bad round, it doesn't have area:(");
                    return -1;
                }
            }
        }
    }
}
