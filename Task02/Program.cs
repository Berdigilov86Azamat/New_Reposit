void Main()
{
    int m = ReadInt("Введите неотрицательное число m: ");
    int n = ReadInt("Введите неотрицательное число n: ");
   
    int result = AckermannFunction(m, n);
    Console.WriteLine($"AckermannFunction({m}, {n}) = {result}");
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else
    {
        return 0; // Это условие никогда не выполнится для неотрицательных m и n
    }
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();