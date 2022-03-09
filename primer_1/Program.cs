// Возвести 2 в степень N, применяя рекурсию
int func(int N)
{
    if (N < 1)
        return 1;

    return 2*func(N-1);
}

Console.WriteLine(func(0));
Console.WriteLine(func(2));
Console.WriteLine(func(3));
Console.WriteLine(func(4));
Console.WriteLine(func(10));