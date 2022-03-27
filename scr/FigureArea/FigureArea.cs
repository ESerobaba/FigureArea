using System;
using System.Linq;
namespace FigureArea
{
    /// <summary>
    /// Describes the class getting the area of shapes
    /// </summary>
    public class XFigureArea
    {
        /// <summary>
        /// Area figure
        /// </summary>
        public double Area { get; set; }
        public XFigureArea(string value)
        {
            GetValue getValue = new GetValue(value);
            string figure = getValue.FigureName;
            double[] args = getValue.argsDouble.ToArray();
            switch (figure)
            {
                case "Circle":
                    Circle circle = new Circle(args[0]);
                    if (args.Length > 1)
                        throw new NotCircle("Calculating the area " +
                            "of a circle requires one argument");
                    Area = circle.GetArea();
                    break;
                case "Triangle":
                    if (args.Length != 3)
                        throw new NotTriangle("Calculating the area " +
                            "of a triangle requires three arguments");
                    Triangle triangle = new Triangle(args.ToArray());
                    Area = triangle.GetArea();
                    break;
                default:
                    throw new ArgumentException("Data entered incorrectly");
                    break;
            }

        }

    }
}
