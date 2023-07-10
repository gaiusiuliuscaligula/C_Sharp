// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N

int InputNumber(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Sum(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + Sum(m, n);
        return result;
    }
}

int m = InputNumber("Введи число M: ");
int n = InputNumber("Введи число N: ");

if (m > n)
{
    int temp = m;
    m = n;
    n = temp;
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m - 1, n)}");



