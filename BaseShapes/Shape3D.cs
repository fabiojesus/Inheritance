using Recodme.Academy.Worksheets.Module6.Worksheet36.Interfaces;
using System;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes
{
    public abstract class Shape3D : Shape, I3DShape
    {
        public string Texture { get; set; }
        public virtual double Area { get; }

        public virtual double Volume { get; }

        public override string ToString()
        {
            return base.ToString() + $"\nArea = {Area}\nVolume = {Volume}";
        }

        public Shape3D(Guid id, string name, string texture) : base(id, name)
        {
            Texture = texture;
        }

        protected Shape3D() : base() { }
    }
}
