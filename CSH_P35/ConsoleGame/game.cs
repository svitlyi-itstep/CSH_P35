using System.Drawing;

namespace CSH_P35.ConsoleGame.Game
{
    class Player
    {
        private Point pos;
        public ConsoleColor color = ConsoleColor.White;
        public Point Pos { 
            get { return pos; } 
            set { 
                pos.X = Math.Max(value.X, 0);
                pos.Y = Math.Max(value.Y, 0);
            } 
        }

        public void Move(Point pos)
        {
            this.pos.X = Math.Max(this.pos.X + pos.X, 0);
            this.pos.Y = Math.Max(this.pos.Y + pos.Y, 0);
        }

        public void Move(int x, int y)
        {
            this.Move(new Point(x, y));
        }

        public void Draw()
        {
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.ForegroundColor = color;
            Console.Write("██");
            Console.ResetColor();
        }

        public int Distanse(Point point)
        {
            return (int)Math.Sqrt(
                Math.Pow(this.pos.X - point.X, 2) + 
                Math.Pow(this.pos.Y - point.Y, 2)
            );
        }
    }

    class Coin
    {
        private Point pos;
        public ConsoleColor color = ConsoleColor.Yellow;
        public Point Pos
        {
            get { return pos; }
            set
            {
                pos.X = Math.Max(value.X, 0);
                pos.Y = Math.Max(value.Y, 0);
            }
        }
        public Coin(Point pos) { this.pos = pos; }
        public Coin(int x, int y) : this(new Point(x, y)) { }
        public void Draw() 
        {
            Console.SetCursorPosition(pos.X, pos.Y);
            Console.ForegroundColor = this.color;
            Console.Write("■");
            Console.ResetColor();
        }
    }
}
