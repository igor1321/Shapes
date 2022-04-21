using System;
using SquareShapes;
using Xunit;

namespace ShapesTests;

public class CircleTests
{
    [Theory]
    [InlineData(3)]
    [InlineData(12)]
    [InlineData(0)]
    [InlineData(-3)]
    public void SquareCircleTest(double radius)
    {
        if (radius > 0)
            Assert.Equal(Math.PI * Math.Pow(radius, 2), GetSquareShapes.GetSquareCircle(radius));

        else
            Assert.Throws<ArgumentException>(() => GetSquareShapes.GetSquareCircle(radius));
    }
    
}