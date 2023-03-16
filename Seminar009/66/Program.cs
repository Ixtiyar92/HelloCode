// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();
Write("Введите start: ");
int n = int.Parse(ReadLine());
Write("Введите end: ");
int m = int.Parse(ReadLine());

WriteLine(SumNums(n, m));

int SumNums(int start, int end)
{
    if (end == start)
    return start;
    int s = (start + SumNums(start + 1, end));
    return (s);
}
