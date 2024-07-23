// Задайте Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или 
// при вводе числа, сумма цифр которого чётная.

void Main()
{
    while (true)
    {
        Console.WriteLine("Введите целое число или 'q' для выхода:");
        string input = Console.ReadLine()!;

        if (input == "q")
            break;

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Введено некорректное значение. Попробуйте снова.");
            continue;
        }

        int sum = 0;
        foreach (char digit in Math.Abs(number).ToString())
            sum += digit - '0';

        if (sum % 2 == 0)
        {
            Console.WriteLine("Сумма цифр введенного числа чётная. Завершение программы.");
            break;
        }
        else
        {
            Console.WriteLine("Сумма цифр введенного числа нечетная. Продолжение программы.");
        }
    }
}
Main();
