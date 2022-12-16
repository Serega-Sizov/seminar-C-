// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Вариант 1.
// Console.Write("Введите число которое надо проверить: ");
// int num = int.Parse(Console.ReadLine()!);

// Console.Write("Введите число которое необходимо возвести в квадрат: ");
// int num1 = int.Parse(Console.ReadLine()!);

// int sqr = num1 * num1;

// if (sqr == num)
// {
//     Console.WriteLine($"Число {num} является квадратом числа {num1}");
// }
// else
// {
//     Console.WriteLine($"Число {num} НЕ является квадратом числа {num1}");
// }


// Вариант 2. Применение библиотеки
Console.WriteLine("Введи первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введи второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
// библиотека Math.Pow(number2, 2) возводит переменную number2 в степень, которую поставим после запятой.
if (Math.Pow(number2, 2) == number1 ) {
    Console.WriteLine ($"Число {number1} является квадратом числа {number2} ");}
    else
    {
       Console.WriteLine ($"Число {number1} не является квадратом числа {number2} ");
    }