// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

Console.Write("Кол-во строк массива m: ");
int CountRow = int.Parse(Console.ReadLine());

Console.Write("Кол-во столбцов массива n: ");
int CountColumn = int.Parse(Console.ReadLine());

double[,] array = new double[CountRow, CountColumn];
for(int i = 0; i < CountRow; i++)
{
    for(int j = 0; j < CountColumn; j++)
    {
        array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}