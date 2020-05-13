using Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes2D
{
    public class Rhombus : Shape2D
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override double Area
        {
            get
            {
                return Base * Height;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 4 * Base;
            }
        }

        public Rhombus(double height, double @base, string color) : base("Rombo", color)
        {
            Base = @base;
            Height = height;
        }

        public Rhombus(string color) : this(1, 1, color)
        {

        }

    }
}
