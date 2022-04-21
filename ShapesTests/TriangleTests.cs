using System;
using SquareShapes;
using Xunit;

namespace ShapesTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 3)]
    [InlineData(12, 13, 5)]
    public void IsSquareTriangleTestCorrect(double a, double b, double c)
    {
        double semiperimeter = (a + b + c) / 2;
        double square = Math.Sqrt(semiperimeter * (semiperimeter - a) * (semiperimeter - b) * (semiperimeter - c));
        
        Assert.Equal(square, GetSquareShapes.GetSquareTriangle(a, b, c));
    }
    
    [Theory]
    [InlineData(-1, 4, 3)]
    [InlineData(1, 13, 5)]
    public void IsSquareTriangleTestIncorrect(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => GetSquareShapes.GetSquareTriangle(a, b, c));
    }
}