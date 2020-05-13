using Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes;
using System;
namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes
{
    public class Square : Shape2D
    {
        public double Side { get; set; }
       

        public override double Area
        {
            get
            {
                return Math.Pow(Side, 2);
            }
        }

        public override double Perimeter
        {
            get
            {
                return 4 * Side;
            }
        }

        public override string ToString()
        {
            return $"With a Side size of {Side}, we can say that:\n" + base.ToString();
        }

        public Square(double side, string color) : base("Quadrado", color)
        {
            Side= side;
        }

        public Square(string color) : this(1, color)
        {

        }

        public Square() : this("red") { }

    }
}
