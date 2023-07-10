// Напишите программу, которая задаёт массив из 8 элементов и
// выводит их на экран

int Prompt(string message)
{
    System.Console.Write(message);
    string ReadInput = System.Console.ReadLine();
    int result = int.Parse(ReadInput);
    return result;
}

int[] G_array(int Lenght, int minValue, int maxValue)
{
    int[] array = new int[Lenght];
    Random random = new Random();
    for (int i = 0; i < Lenght; i++);
        {
        array[i] = random.Next(minValue, maxValue + 1);
        }
    return array;
}

void printarray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++);
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

int lenght = Prompt("Длина массива: ");
int min = Prompt("Начальное значение: ");
int max = Prompt("Конечное значение: ");
int [] array = G_array(lenght, min, max);

printarray(array);
