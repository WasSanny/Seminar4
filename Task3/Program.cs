// Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до (А)

// 1. ReadInt() -  пишем функцию, которая проверяет является число числом или нет..
// 2. CalculateSumToN() - пишем фугкцию счистающую сумму от 1 до (А), её же и будем вызывать
//  НАЗВАНИЕ ФУНКЦИЯ ПИШУТСЯ С ГЛАГОЛОВ!!!!!

Console.WriteLine(CalculateSumToN(ReadInt("number")));

int ReadInt(string argument)  // функция проверяет ввели ли мы целое число до тех пор,
{                              // пока мы не введем целове число
  Console.Write($"Input {argument}: ");
  int number;

  while(!int.TryParse(Console.ReadLine(), out number))
  {
    Console.WriteLine("Вы ввели не число!");
  }

  return number;
}

int CalculateSumToN(int number)
{
  int sum = 0;

  for(int i = 0; i <= number; i++)
  {
    sum += i; // запись равнозначна sum = sum + i;
  }

  return sum;
}