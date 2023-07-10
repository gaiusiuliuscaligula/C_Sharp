// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// метод для заполнения массива числами
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100,100);
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

// ищем сумму на нечетных позициях
int sum = 0;

for (int j = 0; j < numbers.Length; j+=2)
    sum = sum + numbers[j];

    Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");