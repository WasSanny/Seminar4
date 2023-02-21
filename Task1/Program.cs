//             Решаем задачи с помощью функций!!!
//
// Программа, принимает на вход два числа и выдает какое
//            из них больше, какое меньше.

Task_1();                     /// Вызываем работу метода!

void Task_1()
{
  int firstNumber = ReadInt("First number");    // читаем первое число
  int secondNumber = ReadInt("Second number");  // читаем второе число

  PrintMore (firstNumber, secondNumber);        // и печатаем большее!
}


int ReadInt(string argument)        // создаем функцию (метод) которая
{                                    // будет принимать на вход и выдавать значения
  Console.Write($"Input {argument}: ");
  int number;

  while (!int.TryParse(Console.ReadLine(), out number)) // если это не число!...
  {
      Console.WriteLine("Error! Try again.");           // тогда: ошибка,попробуйте еще раз!
  }

  return number;                                        // выводим значение
}

void PrintMore (int firstNumber, int secondNumber)        // создаем вторую функцию: будет получать число большее
{
  if (firstNumber > secondNumber)
  {
      Console.WriteLine($"{firstNumber} > {secondNumber}");
  }
  else
  {
      Console.WriteLine($"{secondNumber} > {firstNumber}");
  }
}