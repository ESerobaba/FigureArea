using System;
using Xunit;
using Xunit.Abstractions;

namespace FigureArea.Tests
{
    public class TestArea
    {
        protected readonly ITestOutputHelper Output;
        public TestArea(ITestOutputHelper tempOutput)
        {
            Output = tempOutput;
        }
        [Fact]
        public void GetCircleArea()
        {
            double radius = 5.0;
            double area = 2 * Math.PI * radius;
            XFigureArea figureAreaCircle = new XFigureArea("Circle",new double[]
            {
                radius
            });
            Output.WriteLine($"Radius={radius} Area={area}");
            Assert.Equal(figureAreaCircle.Area, area);
            
        }
        [Fact]
        public void GetCircleAreaThrowNull()
        {
            double radius = -5.0;
            Output.WriteLine($"Radius={radius}");
            Assert.Throws<ArgumentException>(() => new XFigureArea("Circle", new double[]
            {
                radius
            }));

        }
        [Fact]
        public void GetCircleAreaThrowNotCircle()
        {
            
            Assert.Throws<NotCircle>(() => new XFigureArea("Circle", new double[]
            {
                1,1,1
            }));

        }
        [Fact]
        public void GetTriangleArea()
        {
            
            double p = (5.0 + 5.0 + 1.0) / 2.0;
            double area = Math.Sqrt(p * (p - 5.0) * (p - 5.0) * (p - 1.0));
            XFigureArea figureAreaTriangle = new XFigureArea("Triangle",new double[]
            {
                5.0,5.0,1.0
            });
            Output.WriteLine($"P/2 = {p} Area={area}");
            Assert.Equal(area, figureAreaTriangle.Area);
        }
        [Fact]
        public void GetTriangleAreaNullOrNegative()
        {
            Assert.Throws<ArgumentException>(() => new XFigureArea("Triangle",new double[]
            {
                -5.0,5.0,1.0
            }));
            Assert.Throws<ArgumentException>(() => new XFigureArea(new double[]
            {
                0.0,5.0,1.0
            }));
        }
        [Fact]
        public void GetTriangleAreaNotTriangle()
        {
            Assert.Throws<NotTriangle>(() => new XFigureArea("Triangle",new double[]
            {
                1.0,1.0,5.0
            }));
            
        }
        [Fact]
        public void GetRightTriangle()
        {
            Triangle triangle = new Triangle(new double[]
            {
                4.0,3.0,5.0
            });
            Assert.True(triangle.rightTriangle);

        }
    }
}
