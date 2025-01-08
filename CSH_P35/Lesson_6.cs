using System.Drawing;
using System.Text;


class Program
{
    public static void DrawBoard(Point chessman, Point[] possibleMoves)
    {
        for (int i = 0; i < 8; i++) {
            for(int j = 0; j < 8; j++)
            {
                var currentPoint = new Point(j + 1, i + 1);
                if (chessman == currentPoint) { Console.BackgroundColor = ConsoleColor.Red; }
                else if(Array.IndexOf(possibleMoves, currentPoint) != -1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.BackgroundColor = Convert.ToBoolean((j + i) % 2) ? ConsoleColor.DarkGray
                    : ConsoleColor.Gray;
                }
                
                Console.Write("  ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }
    //public static void Main(string[] args)
    //{
    //    Console.OutputEncoding = UTF8Encoding.UTF8;
    //    Console.InputEncoding = UTF8Encoding.UTF8;
    //    Point[] possibleMoves = { new Point(1, 1), new Point(5, 1) };
    //    DrawBoard(new Point(3, 3), possibleMoves);
    //}
}
/*
    Зробити абстрактний клас, що описує шахову фігуру. Мінімальні вимоги до класу:
    — поля для збереження позиції фігури;
    — поле, яке відповідає за команду (білі/чорні);
    — метод, який повертає перелік позицій, куди може походити фігура;
    — метод, який перевіряє, чи може фігура походити в конкретну позицію.

    Зробити класи на кожну шахову фігуру (пішак, тура, кінь, офіцер, ферзь, король), успадкувавши
    їх від абстрактного класу, описаного вище. Реалізувати всі методи базового класу.

    Приклад роботи:

    Chessman horse = new ChessHorse(3, 3);

    horse.PossibleMoves(); // Має повернути масив {{1, 2}, {2, 1}, {1, 4}, {4, 1}, 
                           //   {5, 2}, {2, 5}, {4, 5}, {5, 4}}
    horse.IsCanMove(1, 4); // Має повернути true
    horse.IsCanMove(6, 2); // Має повернути false

*/