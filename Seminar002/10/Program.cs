Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999){
    Console.WriteLine("Введено неправильное число");
    return;
}
int result = (num % 100) / 10;
Console.WriteLine($"2 цифра: {result}");