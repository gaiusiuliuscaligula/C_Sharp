// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Кол-во строк массива m: ");
int CountRow = int.Parse(Console.ReadLine());

Console.Write("Кол-во столбцов массива n: ");
int CountColumn = int.Parse(Console.ReadLine());

int[,] array = new int[CountRow, CountColumn];
for(int i = 0; i < CountRow; i++)
{
    for(int j = 0; j < CountColumn; j++)
    {
        array[i, j] = new Random().Next(-10, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

for (int j = 0; j < array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        avarage = (avarage + array[i, j]);
    }
    avarage = avarage / CountRow;
    Console.Write(avarage + "; ");
}
Console.WriteLine();


