//using System.Text;
//using System.Threading;
//using CSH_P35.Game;

//class Program
//{
//    static void ShowAttackMessage(Character attacker, Character target, int damage)
//    {
//        Console.WriteLine($"{attacker.Name} атакував {target.Name} і наніс {damage} шкоди.");
//        Console.WriteLine($"У {target.Name} лишилося {target.Health} здоров`я.");
//    }
    
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = UTF8Encoding.UTF8;
//        Console.InputEncoding = UTF8Encoding.UTF8;

//        Berserk player1 = new Berserk();
//        Console.WriteLine(player1);
//        Console.WriteLine(player1.GetHashCode());
//        player1.print();
//        Console.WriteLine();

//        Character player2 = new Character("Anton", 90, 8, 0, Race.Human);
//        player2.print();

//        while (player1.isAlive() && player2.isAlive())
//        {
//            Console.WriteLine();
//            int pl1Damage = player1.attack(player2);
//            ShowAttackMessage(player1, player2, pl1Damage);
//            int pl2Damage = player2.attack(player1);
//            ShowAttackMessage(player2, player1, pl2Damage);

//            Thread.Sleep(1000);
//        }

//        Console.WriteLine("\n");
//        player1.print();
//        Console.WriteLine();
//        player2.print();

//    }
//}

/*
    Реалізувати механіку "Останнього шансу" для Берсерка: коли Берсерк отримує смертельну шкоду,
    одноразово його здоров`я встановлюється як 1. Після цього наступна смертельна шкода має залишити
    здоров`я на рівні 0.

 */
