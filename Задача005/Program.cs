//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Последнее число от числа {num} равно {num % 10}");