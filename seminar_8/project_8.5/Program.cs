// Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] SpiralArray = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= SpiralArray.GetLength(0) * SpiralArray.GetLength(1))
{
  SpiralArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < SpiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= SpiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > SpiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(SpiralArray);

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
