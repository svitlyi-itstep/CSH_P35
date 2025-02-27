﻿

using System.Drawing;

namespace CSH_P35.SnakeGame
{
    class SnakeGame
    {
        public static void Main(string[] args)
        {
            Game game = new Game(new Point(40, 20));
            // Console.WriteLine("Snake Game...");
            Console.CursorVisible = false;
            game.snake.direction = Direction.RIGHT;
            while (true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.UpArrow || key == ConsoleKey.W) { game.ChangeSnakeDirection(Direction.UP); }
                    if (key == ConsoleKey.DownArrow || key == ConsoleKey.S) { game.ChangeSnakeDirection(Direction.DOWN); }
                    if (key == ConsoleKey.LeftArrow || key == ConsoleKey.A) { game.ChangeSnakeDirection(Direction.LEFT); }
                    if (key == ConsoleKey.RightArrow || key == ConsoleKey.D) { game.ChangeSnakeDirection(Direction.RIGHT); }

                }

                game.Update();
                game.Draw();
                Console.SetCursorPosition(0, game.fieldSize.Y + 1);
                foreach (var segment in game.snake.segments)
                {
                    Console.Write($"{segment} ");
                }

                if (game.IsGameOver) break;
                Thread.Sleep(100);
            }
        }
        
    }
}
// https://github.com/svitlyi-itstep/CSH_P35

/*
 *     *******+
 *     *+**
 *     ****
 * 
 * 
 */