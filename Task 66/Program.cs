using System;
using Microsoft.VisualBasic;
/* Задача 66: Задайте значения M и N. Напишите программу,
 * которая найдёт сумму натуральных элементов в промежутке 
 * от M до N с помощью рекурсии.
 *
 *  M = 1; N = 15 -> 120
 *  M = 4; N = 8. -> 30
 *

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int CalcSumOfNumbersInRange(int rangeStart, int rangeEnd)
{
    return rangeStart > rangeEnd ? 0 : rangeStart + CalcSumOfNumbersInRange(rangeStart + 1, rangeEnd);
}
int start = ReadInt("Введите начало диапазона M: ");
int end = ReadInt("Введите конец диапазона N: ");

Console.WriteLine();
Console.WriteLine(CalcSumOfNumbersInRange(start, end));
 */

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int CalcSumm(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    return M + CalcSumm(M + 1, N);
}
int M = ReadInt("Введите первое число M: ");
int N = ReadInt("Введите второе число N: ");

if (M > N)
{
    int temp = M;
    M = N = temp;
}
Console.WriteLine(CalcSumm(M, N));
Console.ReadLine();