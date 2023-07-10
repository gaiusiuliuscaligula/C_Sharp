// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве

// метод для заполнения массива трехзначными случайными числами
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

// метод для печати массива
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

//-----------------------------------------------------------------------

// заполняем массив
Console.Write("Введи размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

// ищем четные
int count = 0;
for (int j = 0; j < numbers.Length; j++)
if (numbers[j] % 2 == 0)
count++;


Console.WriteLine($"В массиве {numbers.Length} чисел, {count} чётных");
