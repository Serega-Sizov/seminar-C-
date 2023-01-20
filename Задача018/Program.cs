// Определить, является ли заданное шестизначное число счастливым. 
// (Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).

Console.Write("Введите шестизначное число: ");
string num = Console.ReadLine()!;

isHappy(num);


// ------МЕТОД-----
void isHappy (string num)
{
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < num.Length/2; i++)
    {
        sum1 += Convert.ToInt32(Convert.ToString(num[i]));
        sum2 += Convert.ToInt32(Convert.ToString(num[num.Length - i - 1]));
    }
    if (sum1 == sum2)
    {
        Console.WriteLine("Число является счастливым!!!");
    }
    else
    {
        Console.WriteLine("Попробуйте еще раз");
    }
}