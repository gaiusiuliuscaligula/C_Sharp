﻿// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

// // Просим пользователя ввести трехзначное число и 
// присваеваем введенному значению переменную
Console.Write("Введи трехзначное число: "); 
int number = int.Parse(Console.ReadLine());

// вводим ветвление для отсечения не трехзначных чисел
if(number < 100)
{
    Console.WriteLine("Миша давай по новой... число не трехзначное");
}
else
{
    Console.WriteLine((number / 10) - (number / 100 *10));
}

