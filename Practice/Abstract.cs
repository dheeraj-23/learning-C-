public abstract class Figure
{
    public double Width, Height, Radius;
    public const float Pi = 3.14f;

    public abstract double getArea();
}

public class Rectange : Figure
{
    public Rectange(double Width, double Height)
    {
        this.Width = Width;
        this.Height = Height;
    }

    public override double getArea()
    {
        return Width * Height;
    }
}

public class Circle : Figure
{
    public Circle (double Radius)
    {
        this.Radius = Radius;  
    }

    public override double getArea()
    {
        return Pi * Radius * Radius;
    }
}

public class Cone : Figure
{
    public Cone(double Radius, double Height)
    {
        this.Radius = Radius;
        this.Height = Height;
    }

    public override double getArea()
    {
        return Pi * Radius * (Radius + Math.Sqrt(Height*Height + Radius*Radius));
    }
}