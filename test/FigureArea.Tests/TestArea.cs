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
            XFigureArea figureAreaCircle = new XFigureArea($"Circle {radius}");
            Output.WriteLine($"Radius={radius} Area={area}");
            Assert.Equal(figureAreaCircle.Area, area);
            
        }
        [Fact]
        public void GetCircleAreaNull()
        {
            double radius = -5.0;
            Output.WriteLine($"Radius={radius}");
            Assert.Throws<ArgumentException>(() => new XFigureArea($"Circle {radius}"));
        }
        [Fact]
        public void GetCircleAreaNotCircle()
        {

            Assert.Throws<NotCircle>(() => new XFigureArea("Circle 1.0 1.0 1.0"));
        }
        [Fact]
        public void GetTriangleArea()
        {
            
            double p = (5.0 + 5.0 + 1.0) / 2.0;
            double area = Math.Sqrt(p * (p - 5.0) * (p - 5.0) * (p - 1.0));
            XFigureArea figureAreaTriangle = new XFigureArea("Triangle 5.0 5.0 1.0");
            Output.WriteLine($"P/2 = {p} Area={area}");
            Assert.Equal(area, figureAreaTriangle.Area);
        }
        [Fact]
        public void GetTriangleAreaNullOrNegative()
        {
            Assert.Throws<ArgumentException>(() => new XFigureArea("Triangle -5.0 5.0 1.0"));
            Assert.Throws<ArgumentException>(() => new XFigureArea("Triangle 0.0 5.0 1.0"));
        }
        [Fact]
        public void GetTriangleAreaNotTriangle()
        {
            Assert.Throws<NotTriangle>(() => new XFigureArea("Triangle 1.0 1.0 5.0"));

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
        [Fact]
        public void GetValueTrue()
        {
            GetValue getValue = new GetValue("Circle 2.0 3.0 5.0");
            Assert.Equal("Circle", getValue.FigureName);
            Assert.Equal(3, getValue.Count);
        }
        [Fact]
        public void GetValueNotDouble()
        {
            Assert.Throws<ArgumentException>(() => new GetValue("Circle s1 3.0 5.0"));
        }
        [Fact]
        public void NotCorrectData()
        {
            Assert.Throws<ArgumentException>(() => new GetValue("ass das dse "));
            Assert.Throws<ArgumentException>(() => new GetValue(" "));
            Assert.Throws<ArgumentException>(() => new GetValue("A"));
        }
    }
}
