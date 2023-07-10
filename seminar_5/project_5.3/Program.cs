// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(10,1000)) / 100;
        }
}

void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + ", ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введи размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
        {
            max = numbers[j];
        }
    if (numbers[j] < min)
        {
            min = numbers[j];
        }
}


Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");