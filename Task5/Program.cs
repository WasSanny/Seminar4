// Программа, которая принимает на вход число (N), и
// выдает произведение от 1 до (N)

Console.WriteLine(CalculateResaltToN(ReadInt("number")));

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

int CalculateResaltToN(int number)
{
  int result = 1;

  for(int i = 1; i <= number; i++)
  {
    result = result * i;
  }

  return result;
}