
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
         * Напрям голови (enum)*/
          public List<Point> segments = new List<Point>();
        // Список координат сегментів
        /* Символ голови (char)
        * Символ сегменту (char)
        * Колір змії (ConsoleColor)
        * 
        * Методи:
        * GetHead() — Отримати координати голови
        * public Point GetHead() {}
        * 
        * GetTail() — Отримати координати хвосту
        * IsCollide() — Перевірити чи є координата у 
        *              списку сегментів
        * Update() (оновлення стану змії)
        */
    }

    class Game
    {
        /* Властивості:*/
        Snake snake = new Snake(); //— Об'єкт змії (Snake) 
        List<Point> food = new List<Point>(); //— Список елементів їжі
        Point fieldSize = new Point(); // — Розмір поля (Point)
        bool IsGameOver = false;
        /* Методи:
         * Update()
         * Draw()
         * ChangeSnakeDirection() — Змінити напрям руху змії
         */

        public void Update()
        {
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
                for (int col = 0; col < this.fieldSize.X; col++)
                {
                    Point current = new Point(row, col);
                    if(current == snake.GetHead())
                    { Console.WriteLine(snake.headSymbol); }
                    else if(snake.IsCollide(current))
                    { Console.WriteLine(snake.segmentSymbol)}
                    else if (food.Contains(current))
                    { Console.WriteLine("F"); }
                    else { Console.WriteLine(" "); }
                }
            }
        }

    }
}
