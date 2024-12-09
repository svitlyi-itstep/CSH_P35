//using System.Text;

//// Для коректної роботи українських символів
//Console.OutputEncoding = UTF8Encoding.UTF8;
//Console.InputEncoding = UTF8Encoding.UTF8;

//void printArray(int[] array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write($"{array[i]}, ");
//    }
//    Console.WriteLine("\b\b.");
//}

//void fillArray(int[] array, int min, int max)
//{
//    Random rand = new Random();
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = rand.Next(min, max + 1);
//    }
//}

////int size = 5;
////int[] array = { 7, 4, 8, 3, 2 };
////int[] array2 = new int[size];


////printArray(array);
////fillArray(array2, 1, 10);
////printArray(array2);

//int offset = 3;
//char symb = 'A';
//char encoded = Convert.ToChar(symb + offset);

//Console.WriteLine($"{symb} + {offset} = {encoded}");

//string text = "HELLO";
//string encoded_text = "";

//encoded_text += Convert.ToChar(text[0] + offset);