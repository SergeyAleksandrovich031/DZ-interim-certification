using System;
using Microsoft.VisualBasic;
/* Задача 68: Напишите программу вычисления функции Аккермана 
 * с помощью рекурсии. Даны два неотрицательных числа m и n.
 *
 * m = 2, n = 3 -> A(m,n) = 9
 * m = 3, n = 2 -> A(m,n) = 29
 *

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackerman(int n, int m)
{
    while (n != 0)
    {
        m = m == 0 ? 1 : Ackerman(n, (m - 1));
        n--;
    }
    return m + 1;
}
int first = ReadInt("Введите первое число: ");
int second = ReadInt("Введите второе число: ");

Console.WriteLine();
Console.WriteLine(Ackerman(first, second));
*/
int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int ack(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return ack(m - 1, 1);
    }
    return ack(m - 1, ack(m, n - 1));
}
Console.WriteLine(ack(ReadInt("Введите m: "), ReadInt("Введите n: ")));
Console.ReadLine();