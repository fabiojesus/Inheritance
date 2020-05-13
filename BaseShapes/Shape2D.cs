using Recodme.Academy.Worksheets.Module6.Worksheet36.Interfaces;
using System;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes
{
    public abstract class Shape2D : Shape, I2DShape
    {
        public string Color { get; protected set; }
        public virtual double Area { get; }

        public virtual double Perimeter { get; }

        public override string ToString()
        {
            return base.ToString() + $"\nArea = {Area}\nPerimeter = {Perimeter}";
        }

        protected Shape2D(Guid id, string name, string color) : base(id, name)
        {
            Color = color;
        }

        protected Shape2D(string name, string color) : base(name)
        {
            Color = color;
        }

        protected Shape2D() : base() { }
    }
}
