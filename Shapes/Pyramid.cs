namespace Shapes;

public class Pyramid : Shape3D
{
    public double Height { get; set; }

    public Pyramid(Shape triangleShape, double height) : base(triangleShape)
    {
        Height = height;
    }

    public override double CalculateVolume()
    {
        return BaseShape.CalculateArea() * Height / 3;
    }
}
