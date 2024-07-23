void Main()
{
    int M = ReadInt("Введите число M: ");
    int N = ReadInt("Введите число M: ");

    if (M > N)
    {
        Console.WriteLine("Число M должно быть меньше или равно числу N.");
    }
    else
    {
        Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}:");
        PrintNumbers(M, N);
    }
}

void PrintNumbers(int M, int N)
{
    if (M > N)
    {
        return;
    }

    Console.Write(M);

    if (M < N)
    {
        Console.Write(", ");
    }

    PrintNumbers(M + 1, N);
}


int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine());
}


Main();