// Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание,
// что такого элемента нет.

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

Console.Write("Введи номер позиции в строке: ");
int PosRow = int.Parse(Console.ReadLine());

Console.Write("Введи номер позиции в столбце: ");
int PosColumn = int.Parse(Console.ReadLine());

if (PosRow > array.GetLength(0) || PosColumn > array.GetLength(1))
{
    Console.WriteLine("Элемента нет");
}
else
{
    Console.WriteLine($"Значение элемента {PosRow} строки и {PosColumn} столбца = {array[PosRow - 1,PosColumn - 1]}");
}