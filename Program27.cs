// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11  82 -> 10 9012-> 12

class Program
{
    static void Main(string[] args)
    {
        int num, sum = 0, r;
        Console.WriteLine("Введите цисло : ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            r = num % 10;
            num = num / 10;
            sum = sum + r;
        }
        Console.WriteLine("Сумма цифр в числе : " + sum);
        Console.ReadLine();

    }
}