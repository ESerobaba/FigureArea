using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FigureArea
{
    /// <summary>
    /// Describes the class getting the 
    /// name and arguments for getting the area of the shapes
    /// </summary>
    public class GetValue
    {
        /// <summary>
        /// Figure name
        /// </summary>
        public string FigureName { get; set; }
        /// <summary>
        /// Arguments for calculating the area of the figure
        /// </summary>
        public List<double> argsDouble { get; set; }
        /// <summary>
        /// Number of arguments, not counting the name
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Getting Shape arguments
        /// </summary>
        /// <param name="stringValue">Argument string</param>
        public GetValue(string stringValue)
        {
            List<double> argsDouble = new List<double>();
            double d = 0.0;
            string[] value = stringValue.Split(" ");
            Count = value.Length - 1;
            if (value.Length <= 1 || value == null)
                throw new ArgumentException("The string cannot be empty or have no argumets");
            else
            {
                FigureName = value[0];
                for (int i = 1; i < value.Length; i++)
                {
                    try
                    {
                        d = Convert.ToDouble(value[i].ToString(), CultureInfo.InvariantCulture);
                        argsDouble.Add(d);
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException($"{e.Message}");
                    }
                }
                this.argsDouble = argsDouble;
            }
        }
    }
}
