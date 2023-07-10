// Задайте значение N. Напишите программу, которая выведет все
// четные натуральные числа в промежутке от m до N. Выполнить с помощью рекурсии.

int InputNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void NaturalEvenNumber(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 2 == 0)
    {
        Console.WriteLine(m);
    }
    NaturalEvenNumber(m + 1, n);
}

int m = InputNumber("Введи число M: ");
int n = InputNumber("Введи число N: ");

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

NaturalEvenNumber(m, n);
