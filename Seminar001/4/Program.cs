Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
if (number1 > number2 && number1 > number3){
    Console.WriteLine($"Максимальное число: {number1}");
    }
if (number2 > number1 && number2 > number3){
    Console.WriteLine($"Максимальное число: {number2}");
    }
if (number3 > number1 && number3 > number2){
    Console.WriteLine($"Максимальное число: {number3}");
    }