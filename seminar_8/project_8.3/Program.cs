// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Кол-во строк первого массива: ");
int CountRowFirstMatrix = int.Parse(Console.ReadLine());

Console.Write("Кол-во столбцов первого массива: ");
int CountColumnFirstMatrix = int.Parse(Console.ReadLine());

Console.Write("Кол-во строк второго массива: ");
int CountRowSecondMatrix = int.Parse(Console.ReadLine());

Console.Write("Кол-во столбцов второго массива: ");
int CountColumnSecondMatrix = int.Parse(Console.ReadLine());

int[,] FirstArray = new int[CountRowFirstMatrix, CountColumnFirstMatrix];
int[,] SecondArray = new int[CountRowSecondMatrix, CountColumnSecondMatrix];
FillArrayRandom(FirstArray);
FillArrayRandom(SecondArray);
PrintArray(FirstArray);
System.Console.WriteLine();
PrintArray(SecondArray);

int[,] ResultArray = new int[CountRowFirstMatrix, CountColumnSecondMatrix];

for (int i = 0; i < ResultArray.GetLength(0); i++)
  {
    for (int j = 0; j < ResultArray.GetLength(1); j++)
    {
      int product = 0;
      for (int k = 0; k < FirstArray.GetLength(1); k++)
      {
        product += FirstArray[i,k] * SecondArray[k,j];
      }
      ResultArray[i,j] = product;
    }
  }
System.Console.WriteLine();
PrintArray(ResultArray);