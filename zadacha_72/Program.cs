// 70. Написать программу возведения числа А в целую стень B
int DegreeOfNumber(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * DegreeOfNumber(numberA, numberB-1);
}
Console.WriteLine(DegreeOfNumber(2, 10));
//Console.WriteLine(DegreeOfNumber(new Random().Next(2, 9), new Random().Next(2, 9)));
