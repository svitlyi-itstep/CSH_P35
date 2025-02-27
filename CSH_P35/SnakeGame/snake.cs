﻿
using System.Drawing;

namespace CSH_P35.SnakeGame
{
    enum Direction
    {
        UP, DOWN, LEFT, RIGHT 
    }
    class Snake
    {
        /* Властивості:
         * */
        public Direction direction = Direction.UP; // Напрям голови (enum)
        public List<Point> segments = new List<Point>(); // Список координат сегментів
        public char headSymbol = '@'; // Символ голови (char)
        public char segmentSymbol = '*'; // Символ сегменту (char)
        public ConsoleColor color = ConsoleColor.Gray; // Колір змії(ConsoleColor)

        public Snake(Point startPoint)
        {
            segments.Add(startPoint);
        }
        public Snake():this(new Point(0, 0)) { }

        public Point GetHead() // Отримати координати голови
        { 
            return segments[0];
        }
        public Point GetTail() // Отримати координати хвосту
        {
            return segments[this.segments.Count - 1];
        }
        public bool IsCollide(Point point) // Перевірити чи є координата у списку сегментів
        {
            return this.segments.GetRange(1, this.segments.Count - 1).Contains(point);
        }         
        public void Update() // (оновлення стану змії)
        {

            Point head = this.GetHead();
            if (this.direction == Direction.UP) { head.Offset(new Point(0, -1)); }
            else if (this.direction == Direction.DOWN) { head.Offset(new Point(0, 1)); }
            else if (this.direction == Direction.LEFT) { head.Offset(new Point(-1, 0)); }
            else if (this.direction == Direction.RIGHT) { head.Offset(new Point(1, 0)); }
            else return;
            this.segments.Insert(0, head);
        }

        public void RemoveTail()
        {
            this.segments.RemoveAt(this.segments.Count - 1);
        }
    }

    class Game
    {
        /* Властивості:*/
        public Snake snake = new Snake(); //— Об'єкт змії (Snake) 
        List<Point> food = new List<Point>(); //— Список елементів їжі
        public Point fieldSize = new Point(); // — Розмір поля (Point)
        public ConsoleColor bg = ConsoleColor.DarkGray;
        public bool IsGameOver = false;
        /* Методи:
         * Update()
         * Draw()
         * ChangeSnakeDirection() — Змінити напрям руху змії
         */

        public Game(Point size)
        {
            this.fieldSize = size;
        }

        public void ChangeSnakeDirection(Direction direction)
        {
            if(
                (direction == Direction.UP && snake.direction != Direction.DOWN)
                || (direction == Direction.DOWN && snake.direction != Direction.UP)
                || (direction == Direction.LEFT && snake.direction != Direction.RIGHT)
                || (direction == Direction.RIGHT && snake.direction != Direction.LEFT)
                )
            snake.direction = direction;
        }

        public void Update()
        {
            if(this.food.Count == 0)
            {
                Random rnd = new Random();
                this.food.Add(new Point(
                    rnd.Next(this.fieldSize.X), 
                    rnd.Next(this.fieldSize.Y)
                    )
                );
            }
            
            snake.Update();
            Point snakeHead = snake.GetHead();
            if (food.Contains(snakeHead)) food.Remove(snakeHead);
            else snake.RemoveTail();

            if(snake.IsCollide(snakeHead)) this.IsGameOver = true;
            if(snakeHead.X < 0 || snakeHead.X >= this.fieldSize.X
                || snakeHead.Y < 0 || snakeHead.Y >= this.fieldSize.Y) 
                this.IsGameOver = true;

            /*
             * Запустити Update змії
             * Зробити перевірки на їжу, зіткнення голови
             * з тілом та вихід за рамки поля
             */
        }
        public void Draw()
        {
            Console.SetCursorPosition(0, 0);
            for(int row = 0; row < this.fieldSize.Y; row++)
            {
                Console.BackgroundColor = this.bg;
                for (int col = 0; col < this.fieldSize.X; col++)
                {
                    Point current = new Point(col, row);
                    if(current == snake.GetHead())
                    { Console.Write(snake.headSymbol); }
                    else if(snake.IsCollide(current))
                    { Console.Write(snake.segmentSymbol); }
                    else if (food.Contains(current))
                    { Console.Write("F"); }
                    else { Console.Write(" "); }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }

    }
}
