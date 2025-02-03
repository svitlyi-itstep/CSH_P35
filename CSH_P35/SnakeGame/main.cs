

using System.Drawing;

namespace CSH_P35.SnakeGame
{
    class SnakeGame
    {
        public static void Main(string[] args)
        {
            Game game = new Game(new Point(10, 10));

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.UpArrow || key == ConsoleKey.W) { game.ChangeSnakeDirection(Direction.UP); }
                if (key == ConsoleKey.DownArrow || key == ConsoleKey.S) { game.ChangeSnakeDirection(Direction.DOWN); }
                if (key == ConsoleKey.LeftArrow || key == ConsoleKey.A) { game.ChangeSnakeDirection(Direction.LEFT); }
                if (key == ConsoleKey.RightArrow || key == ConsoleKey.D) { game.ChangeSnakeDirection(Direction.RIGHT); }

                game.Update();
                game.Draw();

                if (game.IsGameOver) break;
                Thread.Sleep(100);
            }
            List<Point> s = new List<Point>();
            s.Insert(0, new Point(0, 0));
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