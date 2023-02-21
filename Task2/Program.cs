//         Решаем задачи с помощью функций!

// Программа, которая на вход принимает 3 числа и выдает,
// какое из них максимальное

//Task_1();                     /// Вызываем работу метода!
//Task_2();
Task_3();

void Task_1()
{
  int firstNumber = ReadInt("First number");    // читаем первое число
  int secondNumber = ReadInt("Second number");  // читаем второе число

  PrintMoreFromTwo(firstNumber, secondNumber);        // и печатаем большее!
}

void Task_2()
{
  int[] array = new int[] {ReadInt("First number"), ReadInt("Second number"), ReadInt("Thirst number")}; // созжали массив из трех элементов

  PtintMoreFromArray(array);
}

void Task_3()
{
  int digital = GetThirdDigital(ReadInt("Number"));
  Console.WriteLine(digital);
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

void PrintMoreFromTwo (int firstNumber, int secondNumber)        // создаем вторую функцию: будет получать число большее
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

void PrintMoreFromThree (int firstNumber, int secondNumber, int thirdNumber) // добавляем новый метод
{
  int max = secondNumber;

  if (secondNumber > max)
  {
    max = secondNumber;
  }
  
  if (thirdNumber > max)
  {
    max = thirdNumber;
  }

  Console.WriteLine($"The bigger number - {max}");
}

void PtintMoreFromArray(int[] array)  // метод поиска максимального числа с помощью массива
{
  int max = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (max < array[i])
    {
      max = array[i];
    }
  }

    Console.WriteLine($"The bigger number - {max}");
}

int GetThirdDigital(int number) //   для выводацифры из трехзначного числа
{
  if (number < 99)
  {
    return -1;
  }

  while (number >= 100)
  {
    number /= 10;
  }

  return number%10;
}