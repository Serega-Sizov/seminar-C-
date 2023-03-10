// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
//Числа Фибоначчи — числовая последовательность, каждый элемент которой равен сумме двух предыдущих.
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"[{string.Join(", ", Fibonacci(N))}]");;

//-----метод-----
int[] Fibonacci (int N)
{
    int[] f = new int[N];
    f[0] = 0;
    f[1] = 1;
    for (int i = 2; i < N; i++)
    {
        f[i] = f[i-1] + f[i - 2];
    }
    return f;
}