// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.

// создаем метод
double coordinates(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double coordinates = Math.Round(Math.Sqrt
        (Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)));
    return coordinates;
}

Console.Write("Введи x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write("Введи x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write("Введи y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write("Введи y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.Write("Введи z1: ");
int z1 = int.Parse(Console.ReadLine());

Console.Write("Введи z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = coordinates(x1, x2, y1, y2, z1, z2);

Console.WriteLine($"Расстояние = {result}");