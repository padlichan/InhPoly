namespace Shapes;

public class Prism : Shape3D
{
    public Prism(Shape baseShape) : base(baseShape)
    {
    }

    public override double CalculateVolume()
    {
        return 0;
    }
}