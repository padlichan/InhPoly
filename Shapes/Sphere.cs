namespace Shapes;

public class Sphere : Shape3D
{
    public Sphere(Circle circleShape) : base(circleShape)
    {
    }

    public override double CalculateVolume()
    {
        return 4 / 3 * Math.PI * Math.Pow( ((Circle)BaseShape).Radius, 3 );
    }
}
