//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 6, 1, 33 -> [6, 1, 33]

namespace ConsoleApplication2
{
    class Laba1
    {
        public static void Main(string[] args)
        {
            int i;
            int[] a = new int[10];
            Console.WriteLine("Введите массив чисел: ");
            for (i = 0; i < 10; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);

            }
        }
    }
}

