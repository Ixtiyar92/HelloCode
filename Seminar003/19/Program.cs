// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
int i = num / 10000;
int j = num % 10;

if (i == j){
Console.WriteLine("Это число является палиндромом");
}else{
Console.WriteLine("Это число не является палиндромом");
}
*/

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5){
    if (number[0] == number[4] && number[1] == number[3]){
        Console.WriteLine("Это число является палиндромом");
    }else{
        Console.WriteLine("Это число не является палиндромом");
    }
}else{
    Console.WriteLine($"ОШИБКА: {number} - число не является пятизначным");
}