//Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

// Просим пользователя ввести первое число и 
// присваеваем введенному значению переменную
Console.Write("Введи первое число: "); 
int number_1 = int.Parse(Console.ReadLine());
// Просим пользователя ввести второе число и 
// присваеваем введенному значению переменную
Console.Write("Введи второе число: ");
int number_2 = int.Parse(Console.ReadLine());

// вводим ветвление
if(number_1 > number_2)
{
    Console.WriteLine($"Первое число больше чем второе = {number_1}");
    Console.WriteLine($"Второе число меньше чем первое = {number_2}");
}

else if(number_1 < number_2)
{
    Console.WriteLine($"Второе число больше чем первое = {number_2}");
    Console.WriteLine($"Первое число меньше чем второе = {number_1}");
}

else
{
    Console.WriteLine($"Числа равны: {number_1} = {number_2}");
}

