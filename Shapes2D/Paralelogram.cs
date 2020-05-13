using Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes2D
{
    public class Parallelogram : Shape2D
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double SideAB { get; set; }
        public double SideBC { get; set; }
        public double SideCD { get; set; }
        public double SideDA { get; set; }

        public override double Area => Base * Height;
        public override double Perimeter => SideAB + SideBC + SideCD + SideDA;

        public Parallelogram(double @base, double height, double sideAB, double sideBC, double sideCD, double sideDA, string color) : base("Paralelograma", color)
        {
            Base = @base;
            Height = height;
            SideAB = sideAB;
            SideBC = sideBC;
            SideCD = sideCD;
            SideDA = sideDA;
        }

        public override string ToString()
        {
            return $"With a base of {Base}, and a height of {Height} we can say that:\n" + base.ToString();
        }

        public Parallelogram(double @base, double side, double height, string color) : this(@base, height, @base, side, @base, side, color)
        {

        }

    }
}
