using System.Text;
using System.Threading;
using CSH_P35.Game;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        Console.InputEncoding = UTF8Encoding.UTF8;
        Character player1 = new Character();
        player1.print();
        Console.WriteLine();
        player1.Health = -100;
        player1.print();
        Console.WriteLine();


        Character player2 = new Character("Anton", 90, 8, 0);
        player2.print();

        while (player1.isAlive() && player2.isAlive() )
        {
            player1.attack(player2);
            player2.attack(player1);
            Thread.Sleep(1000);
        }

        Console.WriteLine("\n");
        player1.print();
        Console.WriteLine();
        player2.print();

    }
}