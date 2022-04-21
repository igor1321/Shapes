using SquareShapes.Shapes;

namespace SquareShapes;

public class GetSquareShapes
{
    public double GetSquareCircle(double radius)
    {
        return new Circle(radius).GetSquare();
    }

    public double GetSquareTriangle(double a, double b, double c)
    {
        return new Triangle(a, b, b).GetSquare();
    }
}