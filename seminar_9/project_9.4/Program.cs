// Найти второй максимум в массиве.
// 4, 4, 3, 0, 2 => 3

int[] array = { 4, 4, 3, 0, 2 };

int max1 = array[0];
int max2 = int.MinValue;

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max1)
    {
        max2 = max1;
        max1 = array[i];
    }
    else if (array[i] > max2 && array[i] != max1)
    {
        max2 = array[i];
    }
}

Console.WriteLine("Второй максимум: " + max2);