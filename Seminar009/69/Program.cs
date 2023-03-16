// //Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5-> 243(3⁵)
// A = 2; B = 3-> 8

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int A = int.Parse(Console.ReadLine());
Write("Введите степень: ");
int B = int.Parse(Console.ReadLine());

WriteLine($"{A} в степени {B} = {Pow(A,B)}");

int Pow(int num, int rank)
{
    if(rank == 0)
    return 1;
    return (num * Pow(num, rank - 1));
}