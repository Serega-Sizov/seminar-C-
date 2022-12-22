// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
Console.Write("Введите значение четверти: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 1)
{
    Console.WriteLine("x > 0 и y > 0 (первая четверть)");
}
else if (num == 2)
{
    Console.WriteLine("x < 0 и y > 0 (вторая четверть)");
}
else if (num == 3)
{
    Console.WriteLine("x < 0 и y < 0 (третья четверть)");
}
else if (num == 4)
{
    Console.WriteLine("x > 0 и y > 0 (четвертая четверть)");
}
else
{
    Console.WriteLine("Такой четверти не существует");
}