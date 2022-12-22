// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= num; i++) // вариант решения через цикл for
{
    Console.Write(Math.Pow(i,2)+" ");
}

// int count = 1;  // вариант решения через цикл while
// while (count <= num)
// {
//     Console.WriteLine(Math.Pow(count,2));
//     count++;
// }