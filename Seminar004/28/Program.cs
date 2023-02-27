// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 5 - 120 == 1 * 2 * 3 * 4 * 5

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");

long GetMultiply(long n){ // n=3
    long result = 1;
    long i = 2;
    if( n < 0){
        i = n;
        n = -1;
    }
    for (; i <= n; i++){ // i <= n; 2 <= 3
        result *= i; // result
    }
    return result;
}