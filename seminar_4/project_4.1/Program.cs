// Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

int Expo(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введи число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введи число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponent = Expo(numberA, numberB);
  Console.WriteLine("Ответ: " + exponent);

