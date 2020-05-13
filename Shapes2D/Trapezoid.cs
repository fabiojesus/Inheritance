using Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes;
using System;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes2D
{
    public class Trapezoid : Shape2D
    {
        public double InferiorBase { get; set; }
        public double SuperiorBase { get; set; }
        public double Height { get; set; }
        public double SideOne { get; set; }
        public double SideTwo { get; set; }

        public override double Area => (InferiorBase + SuperiorBase) * Height / 2;
        public override double Perimeter => (InferiorBase + SuperiorBase + SideOne + SideTwo);

        public override string ToString()
        {
            return $"With an inferior base of {InferiorBase}, a superior base of {SuperiorBase}, " +
                   $" side one of {SideOne}, side two of {SideTwo} and a height of {Height} we can say that:\n" + base.ToString();
        }

        public Trapezoid(double infBase, double supBase, double height, double sideOne, double sideTwo, string color) : base(Guid.NewGuid(), "Trapezóide", color)
        {
            InferiorBase = infBase;
            SuperiorBase = supBase;
            Height = height;
            SideOne = sideOne;
            SideTwo = sideTwo;
        }

        public Trapezoid( double infBase, double supBase, double height, double side, string color) : this(infBase, supBase, height, side, side, color)
        {

        }

        public Trapezoid() : this(1,2,4,4, "yellow")
        {

        }

    }
}
