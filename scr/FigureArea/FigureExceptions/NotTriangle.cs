using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    /// <summary>
    /// Exception if the shape is not a Triangle
    /// </summary>
    public class NotTriangle : Exception
    {
        public NotTriangle(string message)
                : base(message) { }
    }
}
