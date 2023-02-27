// 26 Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр = {CountNumbers(s)}");


int CountNumbers(int n) //123
{
    int count = 0; // count 0

    if (n < 0)
        n *= (-1); // n = n * (-1) 
    while (n > 0) // 0 > 0
    {
        n /= 10; // n = n / 10    n = 0
        count++; // count 3
    }
    //double a = Math.Pow(123, 2);
    return count;
}