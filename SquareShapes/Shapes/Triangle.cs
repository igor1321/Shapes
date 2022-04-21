using SquareShapes.Interface;

namespace SquareShapes.Shapes;

public class Triangle: IShapes
{
    private double sideFirst;
    private double sideSecond;
    private double sideThird;
    public Triangle(double a, double b, double c)
    {
        if ((a <= 0 || b <= 0 || c <= 0) && (a + b < c || b + c < a || a + c < b))
        {
            throw new ArgumentException($"Треугольник со сторонами {a}, {b}, {c} не может существовать!");
        }

        sideFirst = a;
        sideSecond = b;
        sideThird = c;
    }
    public double GetSquare()
    {
        double semiperimeter = (sideFirst + sideSecond + sideThird) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - sideFirst) * (semiperimeter - sideSecond)
                         * (semiperimeter - sideThird));
    }
}