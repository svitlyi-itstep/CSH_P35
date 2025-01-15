
interface IDrawable
{
    void Draw();
}

abstract class Shape
{
    public abstract double GetArea();
}

class Square : Shape, IDrawable
{
    double side;
    public Square(double side) { this.side = side; }
    public override double GetArea() { return this.side * this.side; }
    public override string ToString()
    {
        return $"Square(side={this.side})";
    }
    public void Draw()
    {
        for (int j = 0; j < this.side; j++)
            for (int i = 0; i < this.side; i++)
            {
                Console.Write("*");
            }
    }

}

class Rectangle : Shape
{
    double a, b;
    public Rectangle(double a, double b) { this.a = a; this.b = b; }
    public override double GetArea() { return this.a * this.b; }

}

class Circle : Shape
{
    double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(this.radius, 2);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Shape[] shapes = { new Square(4), new Square(10) , new Rectangle(5,3), new Rectangle(10, 2),
                new Circle(5)};

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area of {shape} is {shape.GetArea()}");
        }

        foreach (IDrawable shape in shapes)
        {
            shape.Draw();
        }
    }
}


