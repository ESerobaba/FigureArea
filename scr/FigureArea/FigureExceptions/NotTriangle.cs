using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class NotTriangle : Exception
    {
        public NotTriangle(string message)
                : base(message) { }
    }
}
