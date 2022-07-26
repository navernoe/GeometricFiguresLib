using GeometricFigures;

namespace GeometricFiguresUnitTests;

public class CircleTest
{
    [Theory]
    [InlineData(5, 78.53981633974483)]
    [InlineData(1.2, 4.523893421169302)]
    public void CircleSquareShouldCalculatedCorrectly(double radius, double expectedSquare)
    {
        Assert.Equal(new Circle(radius).Square, expectedSquare);
    }

    [Fact]
    public void CircleCreationWithLessOrZeroRadiusShouldThrowError()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-10));
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }
}
