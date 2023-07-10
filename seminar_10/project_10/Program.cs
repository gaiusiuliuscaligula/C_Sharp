// Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] FilterArray(string[] input)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            count++;
        }
    }

    string[] output = new string[count];
    int j = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= 3)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}


Console.Write("Введите элементы массива через пробел: ");
string[] input = Console.ReadLine().Split(' ');

string[] output = FilterArray(input);

Console.WriteLine("Результат:");
Console.Write("[ ");
for (int i = 0; i < output.Length; i++)
{
    Console.Write(output[i]);
    if (i < output.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.Write(" ]");