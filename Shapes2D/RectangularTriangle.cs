using Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes;
using System;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes
{
    class RectangularTriangle : Shape2D
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double Hypotnuse => Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Base, 2));
        public override double Area
        {
            get
            {
                return Height * Base / 2;
            }
        }

        public override double Perimeter
        {
            get
            {
                return Height + Base + Hypotnuse;
            }
        }

        public RectangularTriangle(double height, double @base, string color) : base("Triângulo Rectângulo", color)
        {
            Base = @base;
            Height = height;
        }

        public RectangularTriangle(string color) : this(1, 1, color) 
        { 
        
        }
    }
}
