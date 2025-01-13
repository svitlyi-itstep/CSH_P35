
interface IShape
{
    public double GetArea();
}

class Square : IShape
{
    double side;
    public Square(double side) { this.side = side; }
    public double GetArea() { return this.side * this.side; }
    public override string ToString()
    {
        return $"Square(side={this.side})";
    }

}

class Rectangle : IShape
{
    double a, b;
    public Rectangle(double a, double b) { this.a = a; this.b = b; }
    public double GetArea() { return this.a * this.b; }

}

class Circle : IShape
{
    double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public double GetArea()
    {
        return Math.PI * Math.Pow(this.radius, 2);
    }
}

//class Program
//{
//    public static void Main(string[] args)
//    {

//        //int i = 0;
//        //foreach (int s in i) { }

//        IShape[] shapes = { new Square(4), new Square(10) , new Rectangle(5,3), new Rectangle(10, 2),
//                new Circle(5)};

//        foreach (IShape shape in shapes)
//        {
//            Console.WriteLine($"Area of {shape} is {shape.GetArea()}");
//        }
//    }
//}


