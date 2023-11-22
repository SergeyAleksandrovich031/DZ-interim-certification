using System;
/* Задача 64: Задайте значения M и N. 
 * Напишите программу, которая выведет все чётные натуральные
 * в числа в промежутке от M до N с помощью рекурсии.
 *
 * M = 1; N = 5 -> "2, 4"
 * 
 * M = 4; N = 8 -> "4, 6, 8"
 */

int ReadInt(string msg)

{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintEvenNumbersInRange(int rangeStart, int rangeEnd)
{
    if (rangeStart % 2 != 0) rangeStart++;
    if (rangeStart > rangeEnd) return;
    Console.Write($"{rangeStart}\t");
    PrintEvenNumbersInRange(rangeStart + 2, rangeEnd);
}
int start = ReadInt("Введите начало диапазона M: ");
int end = ReadInt("Введите конец диапазона N: ");
Console.WriteLine();

PrintEvenNumbersInRange(start, end);
Console.ReadLine();