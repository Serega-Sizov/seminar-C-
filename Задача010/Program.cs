// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого. 

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 * num1 == num2 || num2 * num2 == num1)
    {
        Console.Write("Одно число является квадратом другого числа");
    }
else
    {
        Console.Write("Одно число НЕ является квадратом другого числа");
    }