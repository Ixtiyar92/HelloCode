Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 || num > 999){
    Console.WriteLine("Введено неправильное число: ");
    return;
}
int otvet = num % 10;
Console.WriteLine($"3 цифра: {otvet}");
Console.WriteLine("-----------------");
Console.WriteLine("Второй метод");
string number = Console.ReadLine();
string otvet2 = Convert.ToString(number[2]);
Console.WriteLine($"3 цифра: {otvet2}");
