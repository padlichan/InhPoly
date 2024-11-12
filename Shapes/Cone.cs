namespace Shapes;

public class Cone : Shape3D
{
    public double Height { get; set; }

    public Cone(Circle circleShape, double height) : base(circleShape)
    {
        Height = height;
    }

    public override double CalculateVolume()
    {
        return BaseShape.CalculateArea() * Height / 3;
    }
}
