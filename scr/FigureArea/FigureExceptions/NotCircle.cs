using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class NotCircle : Exception
    {
        public NotCircle(string message)
                : base(message) { }
    }
}
