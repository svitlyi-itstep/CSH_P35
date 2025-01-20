using CSH_P35.ConsoleGame.Game;
using System.Drawing;

namespace CSH_P35.ConsoleGame
{
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Player player = new Player();
    //        player.Pos = new Point(3, 3);
    //        Console.CursorVisible = false;

    //        List<Coin> coinList = new List<Coin>();
    //        coinList.Add(new Coin(13, 6));

    //        while (true)
    //        {
    //            Console.Clear();
                
    //            foreach(var coin in coinList.ToList()) {
    //                if (player.Distanse(coin.Pos) < 1)
    //                {
    //                    coinList.Remove(coin);
    //                }
    //                else
    //                {
    //                    coin.Draw();
    //                }
    //            }
    //            player.Draw();
                

    //            ConsoleKey key = Console.ReadKey(true).Key;

    //            if (key == ConsoleKey.D) { player.Move(1, 0); }
    //            else if (key == ConsoleKey.A) { player.Move(-1, 0); }
    //            else if (key == ConsoleKey.W) { player.Move(0, -1); }
    //            else if (key == ConsoleKey.S) { player.Move(0, 1); }
    //        }
    //    }
    //}
}
