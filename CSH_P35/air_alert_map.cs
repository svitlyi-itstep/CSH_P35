﻿//using System.Text;

//namespace CSH_P35
//{
//    class Oblast
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public bool IsAlert { get; set; }

//        public Oblast(int id, string name, bool isAlert = false)
//        {
//            Id = id;
//            Name = name;
//            IsAlert = isAlert;
//        }

//        public Oblast() : this(0, "") { }
//    }

//    class AirAlertMap
//    {
//        public static string ShortenName(string name, int length) 
//        {
//            return name.Length > length ? name.Substring(0, length - 1) + "…" : name;
//        }

//        public static void Main(string[] args)
//        {
//            Console.OutputEncoding = UTF8Encoding.UTF8;
//            Console.InputEncoding = UTF8Encoding.UTF8;
            
//            List<Oblast> regions = new List<Oblast>()
//            {
//                new Oblast(0, ""),
//                new Oblast(1, ""),
//                new Oblast(2, ""),
//                new Oblast(3, "Хмельницька область"),
//                new Oblast(4, "Вінницька область"),
//                new Oblast(5, "Рівненська область"),
//                new Oblast(6, ""),
//                new Oblast(7, ""),
//                new Oblast(8, "Волинська область"),
//                new Oblast(9, "Дніпропетровська область"),
//                new Oblast(10, "Житомирська область"),
//                new Oblast(11, "Закарпатська область"),
//                new Oblast(12, "Запорізька область"),
//                new Oblast(13, "Івано-Франківська область"),
//                new Oblast(14, "Київська область"),
//                new Oblast(15, "Кіровоградська область"),
//                new Oblast(16, "Луганська область"),
//                new Oblast(17, "Миколаївська область"),
//                new Oblast(18, "Одеська область"),
//                new Oblast(19, "Полтавська область"),
//                new Oblast(20, "Сумська область"),
//                new Oblast(21, "Тернопільська область"),
//                new Oblast(22, "Харківська область"),
//                new Oblast(23, "Херсонська область"),
//                new Oblast(24, "Черкаська область"),
//                new Oblast(25, "Чернігівська область"),
//                new Oblast(26, "Чернівецька область"),
//                new Oblast(27, "Львівська область"),
//                new Oblast(28, "Донецька область"),
//                new Oblast(29, "Автономна Республіка Крим"),
//                new Oblast(30, "м. Севастополь"),
//                new Oblast(31, "м. Київ")
//            };

//            const int mapWidth = 8, mapHeight = 6, cellWidth = 13;
//            int[,] map = new int[mapHeight, mapWidth]
//            {
//                {0, 0, 0, 0, 31, 0, 0, 0 },
//                {0, 0, 0, 0, 0, 0, 0, 0 },
//                {0, 0, 0, 0, 0, 0, 0, 0 },
//                {0, 0, 0, 0, 0, 0, 0, 0 },
//                {0, 0, 0, 0, 0, 0, 0, 0 },
//                {0, 0, 0, 0, 0, 0, 0, 0 },
//            };

//            for (int column = 0; column < mapWidth; column++)
//            {
//                if (map[0, column] == 0) { Console.BackgroundColor = ConsoleColor.Black; }
//                else { Console.BackgroundColor = ConsoleColor.Red; }
//                Console.Write($" {"", cellWidth} ");

//            }
//            Console.WriteLine();
//            for (int column=0; column<mapWidth; column++)
//            {
//                if(map[0, column] == 0) { Console.BackgroundColor = ConsoleColor.Black; }
//                else { Console.BackgroundColor = ConsoleColor.Red;}
//                Console.Write($" {ShortenName("Хмельницька область", cellWidth),cellWidth} ");

//            }
//            Console.WriteLine();
//            for (int column = 0; column < mapWidth; column++)
//            {
//                if (map[0, column] == 0) { Console.BackgroundColor = ConsoleColor.Black; }
//                else { Console.BackgroundColor = ConsoleColor.Red; }
//                Console.Write($" {"",cellWidth} ");

//            }
//            Console.WriteLine();
//        }
//    }
//}
