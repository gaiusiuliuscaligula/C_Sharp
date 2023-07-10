// Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.

// Просим пользователя ввести число и 
// присваеваем введенному значению переменную
Console.Write("Введи число: "); 
int number = int.Parse(Console.ReadLine());

// переводим число в строку
string numberTXT = Convert.ToString(number);

// вводим ветвление для нахождения третьей цыфры
if (numberTXT.Length > 2)
{
  Console.WriteLine("третья цифра -> " + numberTXT[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}

