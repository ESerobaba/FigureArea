using System;
using System.Collections.Generic;
using System.Text;


namespace FigureArea
{
    /// <summary>
    /// Class for calculating the area of a Circle
    /// </summary>
    public class Circle : IFigure
    {
        
        private double radius;
        /// <summary>
        /// Radius
        /// </summary>
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
        /// <summary>
        /// Calculating the area of a circle
        /// </summary>
        /// <returns>Area</returns>
        public double GetArea()
        {
            
            return 2*Math.PI*Radius;
        }

    }
}
