﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0 && number % 23 == 0)
    {
        Console.Write($"Число {number} делится на 7 и на 23");
    }
else 
    {
        Console.Write($"Число {number} не делится одновременно на 7 и на 23");
    }