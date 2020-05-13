using System;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes
{
    public abstract class Shape
    {
        public Guid Id { get; protected set; }

        public string Name { get; protected set; }

        public override string ToString()
        {
            return $"It's a {Name}";
        }

        protected Shape(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        protected Shape(string name)
        {
            Id = Guid.NewGuid();
        }

        protected Shape() { }
    }
}
