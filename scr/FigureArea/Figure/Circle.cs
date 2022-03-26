using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class Circle : IFigure
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("The radius of the " +
                    "circle cannot be zero or negative");
                else
                    radius = value;
            }
        }
        public Circle(double radius)
        {   try
            {
                this.Radius = radius;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                throw;
            }
        }
        public double GetArea()
        {
            
            return 2*Math.PI*Radius;
        }

    }
}
