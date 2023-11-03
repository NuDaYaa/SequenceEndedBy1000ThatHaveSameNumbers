Console.WriteLine("Введите последовательность чисел порогом которой является 1000:");
int currentNumber = 0;
int previousNumber = 0;
int countEqualNumbers = 0;
int countDistinctNumbers = 0;

string input = Console.ReadLine();
while (!input.Equals("1000"))
{
    if (int.TryParse(input, out currentNumber))
    {
        if (currentNumber == previousNumber)
        {
            countEqualNumbers++;
        }
        else
        {
            countDistinctNumbers++;
        }
        previousNumber = currentNumber;
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
        Console.WriteLine("Ввод должен осуществлятся через ввод каждого числа на отдельную строку.");
    }

    input = Console.ReadLine();
}

Console.WriteLine("Количество чисел, идущих подряд и равных между собой: " + countEqualNumbers);
Console.WriteLine("Количество различных чисел в последовательности: " + countDistinctNumbers);