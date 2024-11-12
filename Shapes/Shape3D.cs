namespace Shapes;

public abstract class Shape3D
{
    public Shape BaseShape { get; set; }
    protected Shape3D(Shape baseShape)
    {
        BaseShape = baseShape;
    }

    public abstract double CalculateVolume();
}
