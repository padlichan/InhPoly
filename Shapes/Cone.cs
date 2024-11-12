namespace Shapes;

public class Cone : Shape3D
{
    public Cone(Shape baseShape) : base(baseShape)
    {
    }

    public override double CalculateVolume()
    {
        return 0;
    }
}
