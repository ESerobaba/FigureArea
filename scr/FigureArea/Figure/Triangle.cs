using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace FigureArea
{
    public class Triangle : IFigure
    {
        private double x1;
        private double x2;
        private double x3;
        public double X1
        {
            get
            {
                return x1;
            }
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("The side of the triangle" +
                        " cannot be zero or negative");
                else
                    x1 = value;
            }
        }
        public double X2
        {
            get
            {
                return x2;
            }
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("The side of the triangle" +
                        " cannot be zero or negative");
                else
                    x2 = value;
            }
        }
        public double X3
        {
            get
            {
                return x3;
            }
            set
            {
                if (value <= 0.0 )
                    throw new ArgumentException("The side of the triangle" +
                        " cannot be zero or negative");
                else
                    x3 = value;
            }
        }
        public bool rightTriangle { get; set; }
        
        public Triangle(params double[] sides)
        {
            try
            {
                var sortSides =sides.OrderByDescending(x => x).ToArray();
                this.X1 = sortSides[0];
                this.X2 = sortSides[1];
                this.X3 = sortSides[2];
                if (X1 > (X2 + X3))
                    throw new NotTriangle("The sum of the lengths of the two" +
                        " sides of the triangle must be greater than the third long side.");
                if (Math.Pow(x1, 2) == (Math.Pow(x2, 2) + Math.Pow(x3, 2)))
                    rightTriangle = true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }
        public double GetArea()
        {
            double p = (X1 + X2 + X3) / 2;
            double area = Math.Sqrt(p * (p - X1) * (p - X2) * (p - X3));
            return area;
        }

        
    }
}
