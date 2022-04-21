using SquareShapes.Interface;

namespace SquareShapes.Shapes;

public class Circle: IShapes
{
    private double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException($"Окружность с радиусом {radius} не может сущестовать!");
        
        _radius = radius;
    }
    
    public double GetSquare()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}