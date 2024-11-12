namespace Shapes;

public class Cylinder : Shape3D
{
    public double Height { get; set; }

    public Cylinder(Circle circleShape, double height) : base(circleShape)
    {
        Height = height;
    }

    public override double CalculateVolume()
    {
        return BaseShape.CalculateArea() * Height;
    }
}
