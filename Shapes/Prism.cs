namespace Shapes;

public class Prism : Shape3D
{
    public double Height { get; set; }

    public Prism(Shape triangleShape, double height) : base(triangleShape)
    {
        Height = height;
    }

    public override double CalculateVolume()
    {
        return BaseShape.CalculateArea() * Height;
    }
}
