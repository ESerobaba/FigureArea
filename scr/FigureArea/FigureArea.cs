using System;
using System.Linq;
namespace FigureArea
{
    public class XFigureArea
    {
        public double Area { get; set; }
        public XFigureArea(double radius)
        {
            Circle circle = new Circle(radius);
            Area = circle.GetArea();
        }
        public XFigureArea(double[] args)
        {
            Triangle triangle = new Triangle(args.ToArray());
            Area = triangle.GetArea();
        }
        public XFigureArea(string figure, double[] args)
        {
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

            }

        }

    }
}
