//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Console.Write("Введи число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write($"Сумма чисел от 1 до {A} равна {GetSum(A)}");

// //--------------Методы-----------------
// int GetSum (int A){
//     int sum = 0;
//     for(int i = 1; i <= A; i++){
//         sum = sum + i; // sum += i
//     }
//     return sum;
// }

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Число {num} имеет {GetNumbers(num)} символов(ла)");
// // -----Метод-----
// int GetNumbers (int A)
// {
//     int numbers = 0;
//     if (A == 0) 
//     return 1;
//     while (A > 0)
//     {
//         numbers = numbers + 1;
//         A = A / 10;
//     }
//     return numbers;
// }

// -------------Та же задача через метод string----------
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine()!;
// Console.WriteLine($"Число {number} имеет {GetNumb(number)} символов(ла)");

// int GetNumb (string number)
// {
//     int Numb = number.Length;
//     return Numb;
// }


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120
// Console.Write("Введи число: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.Write($"Произведение чисел от 1 до {N} равна {GetFactorial(N)}");

// // ------Метод------
// int GetFactorial(int N)
// {
//     int Factorial = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         Factorial = Factorial * i;
//     }
//     return Factorial;
// }



// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// ----------создаем МЕТОД------------
// int[] GetArray (int size)
// {
//     int[] Array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         Array[i] = new Random{}.Next(2); //так же можно в Next прописать от 0 до 1
//     }
//     return Array;
// }

// int[] massiv = GetArray(8);
// Console.Write($"[{string.Join(";", massiv)}]");