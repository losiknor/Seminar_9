// 66. Показать натуральные числа от 1 до N, N задано
// int N = new Random().Next(10, 99)
// int showNat (int N)
// {
//     if (N < 1)
//         break;
//     Console.WriteLine(N);
//     return showNat(N-1);
// }
// showNat (new Random().Next(10, 99));

void PrintNumber(int n)
{
    if (n < 1) return;
    PrintNumber(n - 1);
    Console.Write(n + " ");
}
PrintNumber(new Random().Next(10, 99));