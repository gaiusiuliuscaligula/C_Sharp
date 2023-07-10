// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// Просим пользователя ввести пятизначное число и
// присваеваем числу строковую переменную
Console.Write("Введи пятизначное число: ");
string number = Console.ReadLine();


// создаем метод для определения палиндромности числа 
void palindromos(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Это число палиндром: {number}");
  }
  else
  {
    Console.WriteLine($"Это число не палиндром: {number}");
  } 
}

// работаем с методом и создаем предупреждение о неправильных значениях
if (number.Length == 5)
{
  palindromos(number);
}
else Console.WriteLine("Это не пятизначное число");
