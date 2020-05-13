using Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes;
using System;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes
{
    public class Circle : Shape2D
    {
       

        public double Radius { get; set; }

        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public override string ToString()
        {
            return $"With a radius of {Radius}, we can say that:\n" + base.ToString();
        }

        public Circle(double radius, string color) : base("Circulo", color)
        {
            Radius = radius;
        }

        public Circle(string color) :this(1, color)
        {

        }

        public Circle(double radius) : this(radius, "yellow")
        {

        }

        public Circle() : this("yellow")
        {

        }

    }
}
