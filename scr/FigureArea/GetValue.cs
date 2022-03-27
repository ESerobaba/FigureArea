using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FigureArea
{
    public class GetValue
    {
        public string FigureName { get; set; }
        public List<double> argsDouble { get; set; }
        public int Count { get; set; }
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
