namespace CSH_P35
{
    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point():this(0,0) { }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public static Point operator +(Point p1, int value)
        {
            return new Point(p1.x + value, p1.y + value);
        }
        public static Point operator +(Point p1, double value)
        {
            return p1 + (int)value;
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return (p1.x == p2.x && p1.y == p2.y);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
        public static implicit operator bool(Point p1)
        {
            return p1.x != 0 || p1.y != 0;
        }
        public static bool operator true(Point p1)
        {
            return p1.x != 0 || p1.y != 0;
        }
        public static bool operator false(Point p1)
        {
            return p1.x == 0 && p1.y == 0;
        }
    }
    internal class Lesson4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Point point1 = new Point(1, 3); Console.WriteLine($"point1 = (x={point1.x}, y={point1.y})");
            Point point2 = new Point(1, 3); Console.WriteLine($"point2 = (x={point2.x}, y={point2.y})");

            Point point3 = point1 + point2; Console.WriteLine($"point3 = (x={point3.x}, y={point3.y})");
            Point point4 = point1 + 3.4; Console.WriteLine($"point4 = (x={point4.x}, y={point4.y})");
            if( point1 == point2 ) { Console.WriteLine("Точки point1 та point2 однакові!"); }
            else { Console.WriteLine("Точки point1 та point2 не однакові!"); }

            if(point1 && point2)

        }
    }
}
