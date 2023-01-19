/*Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)*/
int[] array = GetArray(5, 0, 20);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] resultArray = ReverseArray2(array);
Console.WriteLine($"[{String.Join(",", resultArray)}]");

ReverseArray1(array);
Console.WriteLine($"[{String.Join(",", array)}]");


// ------Методы------------------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReverseArray1(int[] array){
    for(int i = 0; i < array.Length/2; i++){
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}

int[] ReverseArray2(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array[array.Length - i - 1];
    }
    return result;
}