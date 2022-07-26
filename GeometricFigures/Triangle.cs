using System.Linq;

namespace GeometricFigures;

/// <summary>
/// Треугольник.
/// </summary>
public class Triangle : IGeometricFigure
{
    public Triangle(double aSideLength, double bSideLength, double cSideLength)
    {
        EnsureSidesValid(aSideLength, bSideLength, cSideLength);
        ASideLength = aSideLength;
        BSideLength = bSideLength;
        CSideLength = cSideLength;
    }

    public double Square => Math.Sqrt(HalfPerimeter * (HalfPerimeter - ASideLength) * (HalfPerimeter - BSideLength) * (HalfPerimeter - CSideLength));

    /// <summary>
    /// Является ли треугольник прямоугольным.
    /// </summary>
    public bool IsRight()
    {
        var orderedSides = new[] { ASideLength, BSideLength, CSideLength }.OrderBy(x => x).ToArray();
        var hypotenuse = orderedSides.Last();

        return Math.Pow(hypotenuse, 2) == (Math.Pow(orderedSides[0], 2) + Math.Pow(orderedSides[1], 2));
    }

    public double ASideLength { get; init; }
    public double BSideLength { get; init; }
    public double CSideLength { get; init; }

    private double Perimeter => ASideLength + BSideLength + CSideLength;
    private double HalfPerimeter => Perimeter / 2;

    private void EnsureSidesValid(double aSideLength, double bSideLength, double cSideLength)
    {
        if (aSideLength <= 0 || bSideLength <= 0 || cSideLength <= 0)
            throw new ArgumentException("Значение длины стороны треугольника должно быть больше нуля");

        if (aSideLength + bSideLength < cSideLength)
            throw new ArgumentException("Треугольник с указанными сторонами не существует");

        if (aSideLength + cSideLength < bSideLength)
            throw new ArgumentException("Треугольник с указанными сторонами не существует");

        if (bSideLength + cSideLength < aSideLength)
            throw new ArgumentException("Треугольник с указанными сторонами не существует");
    }
}