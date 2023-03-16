// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
WriteLine($"Сумма цифр = {SumNums(num)}");
int sum = 0;

// решение циклом
/* while (num > 0){
    sum += num % 10; // sum = sum + num % 10
    num /= 10; // num = num + num / 10
}
WriteLine($"{sum}"); */

// решение рекурсией
int SumNums(int number)
{
    if (number == 0)
        return 0;
    return (number % 10 + SumNums(number / 10));
}