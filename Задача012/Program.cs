// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты точки А(x): ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки А(y): ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки B(x): ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки B(y): ");
int y2 = int.Parse(Console.ReadLine()!);

double result = Math.Round(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)),1);

Console.Write($"расстояние между двумя точками: {result}");