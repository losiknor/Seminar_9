// 68. Показать натуральные числа от M до N, N и M заданы
void PrintNumber(int n, int m)
{
    if (n < m) return;
    PrintNumber(n - 1, m);
    Console.Write(n + " ");
}
PrintNumber(new Random().Next(20, 99), new Random().Next(1, 19));
// PrintNumber(20, 2);