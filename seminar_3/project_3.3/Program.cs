// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введи число: ");
int cube = int.Parse(Console.ReadLine());

void Cube(int[] cube)
{
  int count = 0;
  int length = cube.Length;
  while (count <  length)
  {
    cube[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}

void PrintArry(int[] coll)
{
  int count2 = coll.Length;
  int index = 0;
  while(index < count2)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
