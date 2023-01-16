// //Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// //Найдите сумму отрицательных и положительных элементов массива.
// int[] array = GetArray(12,-9,9);
// Console.WriteLine($"[{String.Join(",", array)}]");

// int positiveSum = 0;
// int negativeSum = 0;

// foreach (int el in array)
// {
//     if(el > 0){
//         positiveSum += el;
//     }
//     else{
//         negativeSum += el;
//     }
// }

// Console.WriteLine($"Сумма положительных равна {positiveSum}, сумма отрицательных равна {negativeSum}");

// // ------Метод------
// int[] GetArray (int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for(int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }



// **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// ------------создаем метод-------
// int[] GetArray (int size)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(-10, 11);
//     }
//     return res;
// }

// int[] array = GetArray(6);
// Console.WriteLine($"[{String.Join(",", array)}]");
// for (int i = 0; i < array.Length; i++)
// {    
//         array[i] = array[i] * (-1);
// }
// Console.WriteLine($"[{String.Join(",", array)}]");



// **Задача 33:** Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// int[] GetArray (int size) 
// { 
//     int[] Array = new int[size]; 
//     for (int i =0; i < size; i++) 
//     { 
//       Array[i] = new Random().Next(-10, 11);   
//     } 
//     return Array; 
// } 
 
// int[] Array = GetArray(10); 
// int Find = -5; 
// Console.WriteLine($"[{String.Join(", ",Array)}]"); 

// if (FindElement(Array, Find)) 
//     { 
//         Console.WriteLine($"Данный элемент найден"); 
//     } 
// else 
//     { 
//         Console.WriteLine($"Данный элемент не найден"); 
//     } 
 
// bool FindElement (int[] Array, int Find) 
// { 
// foreach (int ArrayEl in Array)
//     {
//         if (ArrayEl == Find)
//         {
//             return true;
//         }
//     }
//     return false;
// }



// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// int[] Array = GetArray(123); 
 
// int[] GetArray (int size) 
// { 
//     int[] Array = new int[size]; 
//     for (int i =0; i < size; i++) 
//     { 
//       Array[i] = new Random().Next(0, 1001);   
//     } 
//     return Array; 
// } 

// Console.WriteLine($"[{String.Join(", ",Array)}]"); 

// int count = 0; 
// for (int i = 0; i <= 122; i++) 
// { 
//     if (Array[i] >= 10 && Array[i] < 100) 
//     { 
//         count = count + 1;  
//     } 
// } 
// Console.WriteLine($"Количество цифр в данном диапазоне {count}");
