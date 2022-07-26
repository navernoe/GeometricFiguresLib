namespace GeometricFigures;

/// <summary>
/// Круг.
/// </summary>
public class Circle : IGeometricFigure
{
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Значение длины радиуса круга должно быть больше нуля");

        Radius = radius;
    }

    public double Square => Math.PI * Math.Pow(Radius, 2);
    public double Radius { get; init; }
}