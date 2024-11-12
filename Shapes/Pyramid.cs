namespace Shapes;

public class Pyramid : Shape3D
{
    public Pyramid(Shape baseShape) : base(baseShape)
    {
    }

    public override double CalculateVolume()
    {
        return 0;
    }
}
