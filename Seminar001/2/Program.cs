Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2){
    Console.WriteLine($"Большее число: {number1}, меньшее число: {number2}");
    }
else
{
    Console.WriteLine($"Большее число: {number2}, меньшее число: {number1}");
}