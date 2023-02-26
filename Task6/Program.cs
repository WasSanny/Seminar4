// Программа, которая выводит массив из 8 элементов,
// заполненный нулями и еденицами в случайном порядке!

// Random random = new Random();   /// Через цикл While
// int min = 0;
// int max = 2;
// int index = 0;
// int[] array = new int[8];

// while(index < 8)
// {
//   array[index] = random.Next(min, max);
//   Console.Write(array[index]);
//   index++;
// }

Random random = new Random();   /// Через цикл for
int min = 0;
int max = 2;
int[] array = new int[8];

for (int index = 0; index < 8; index++)
{
  array[index] = random.Next(min, max);
  Console.Write(array[index]);
}