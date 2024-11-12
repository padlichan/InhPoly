namespace Shapes;

public class Sphere : Shape3D
{
    public Sphere(Shape baseShape) : base(baseShape)
    {
    }

    public override double CalculateVolume()
    {
        return 0;
    }
}
