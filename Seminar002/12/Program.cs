﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int num1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Int32.Parse(Console.ReadLine());
if (num1 % num2 == 0){
Console.WriteLine("кратно");
}
else{
Console.WriteLine($"не кратно, остаток - {num1 % num2}");
}