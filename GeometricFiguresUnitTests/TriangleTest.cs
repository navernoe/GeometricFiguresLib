using GeometricFigures;

namespace GeometricFiguresUnitTests;

public class TriangleTest
{
    [Theory]
    [InlineData(12, 11, 10, 51.521233486786784)]
    [InlineData(3.3, 2.4, 1.7, 1.961631973638276)]
    [InlineData(4, 2.88, 5, 5.757298241362868)]
    public void TriangleSquareShouldCalculatedCorrectly(
        double aSideLength,
        double bSideLength,
        double cSideLength,
        double expectedSquare)
    {
        var actualSquare = new Triangle(aSideLength, bSideLength, cSideLength).Square;

        Assert.Equal(expectedSquare, actualSquare);
    }

    [Fact]
    public void TriangleCreationWithInvalidSidesShouldThrowError()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(12, 3, 6));
    }

    [Fact]
    public void TriangleCreationWithLessOrZeroSideShouldThrowError()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(12, -10, 11));
        Assert.Throws<ArgumentException>(() => new Triangle(12, 10, 0));
    }

    [Theory]
    [InlineData(12, 11, 10, false)]
    [InlineData(3, 5, 4, true)]
    public void TriangleCheckRightShouldWork(
        double aSideLength,
        double bSideLength,
        double cSideLength,
        bool expectedIsRightValue)
    {
        var actualIsRightValue = new Triangle(aSideLength, bSideLength, cSideLength).IsRight();

        Assert.Equal(actualIsRightValue, expectedIsRightValue);
    }
}