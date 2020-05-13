using Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes.BaseShapes;

namespace Recodme.Academy.Worksheets.Module6.Worksheet36.Shapes
{
    public class Rectangle : Shape2D
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Length + Width);
            }
        }


        public override string ToString()
        {
            return $"With a length of {Length} and a width of {Width}, we can say that:\n"+base.ToString();
        }

        public Rectangle(double length, double width, string color) : base("Rectangle", color)
        {
        }

        public Rectangle(string color) : this(1,1, color)
        {

        }

        public Rectangle() : base() { }
    }
}
