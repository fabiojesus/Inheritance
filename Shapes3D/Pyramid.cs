using Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes3D
{
    public class Pyramid<T> : Shape3D where T : Shape2D, new()
    {
        public T Base { get; set; }
        public double Slope { get; set; }
        public double Height { get; set; }

        public override double Area => (1.0 / 2) * (Base.Perimeter) * Slope;

        public override double Volume => (1.0 / 3) * (Base.Area) * Height;

        public override string ToString()
        {
            return $"With a {Base.Name} as its base, with a slope of {Slope} and a height of {Height}, we can say that:\n" + base.ToString(); 
        }

        public Pyramid(T @base, double slope, double height, string texture) : base(Guid.NewGuid(), "Pyramid", texture)
        {
            Base = @base;
            Slope = slope;
            Height = height;
        }

        public Pyramid() : this(new T(), 100, 300, "reeeeeeeeeeeeeeeeeeeeeeee")
        {
        }

    }
}
