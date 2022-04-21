using SquareShapes.Shapes;

namespace SquareShapes;

public static class GetSquareShapes
{
    public static double GetSquareCircle(double radius)
    {
        return new Circle(radius).GetSquare();
    }

    public static double GetSquareTriangle(double a, double b, double c)
    {
        return new Triangle(a, b, b).GetSquare();
    }
}