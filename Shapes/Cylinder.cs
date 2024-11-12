namespace Shapes;

public class Cylinder : Shape3D
{
    public Cylinder(Shape baseShape) : base(baseShape)
    {
    }

    public override double CalculateVolume()
    {
        return 0;
    }
}
