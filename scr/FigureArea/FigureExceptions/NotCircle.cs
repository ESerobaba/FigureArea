using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    /// <summary>
    /// Exception if the shape is not a Circle
    /// </summary>
    public class NotCircle : Exception
    {
        public NotCircle(string message)
                : base(message) { }
    }
}
