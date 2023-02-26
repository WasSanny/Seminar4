// Программа, которая принмает на вход число,
// и выдает количество чисел входящего числа

Console.WriteLine(CalculateNumberToNumber(ReadInt("number")));

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

int CalculateNumberToNumber(int numb)
{
  int length = numb.ToString().Length;
  return length;
}

