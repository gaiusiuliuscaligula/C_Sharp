// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели,
// и проверяет, является ли этот день выходным.


// просим пользователя ввести номер дня недели и
// присваеваем введенному значению переменную
Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());

// используем метод
void day (int number) 
{
  if (number == 6 || number == 7) 
  {
    Console.WriteLine("Это выходной день.");
  }
  else if (number < 1 || number > 7) 
  {
    Console.WriteLine("Это не день недели.");
  }
  else Console.WriteLine("Это не выходной день.");
}

day(number);