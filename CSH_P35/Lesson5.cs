
class Shape
{
    public virtual double GetArea() { return 0; }
}

class Square:Shape
{
    double side;
    public Square(double side) { this.side = side; }
    public override double GetArea() { return this.side * this.side; }
    public override string ToString()
    {
        return $"Square(side={this.side})";
    }

}

class Rectangle : Shape
{
    double a, b;
    public Rectangle(double a, double b) { this.a = a; this.b = b; }
    public override double GetArea() { return this.a * this.b; }

}

class Program
{
    public static void Main(string[] args)
    {
        Shape[] shapes = { new Square(4), new Square(10) , new Rectangle(5,3), new Rectangle(10, 2)};

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area of {shape} is {shape.GetArea()}");
        }
    }
}


