Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Введён неправильный номер");
    return;
}

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник - не выходной");
}
if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник - не выходной");
}
if (numberDayOfWeek == 3)
{
    Console.WriteLine("Среда - не выходной");
}
if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг - не выходной");
}
if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница - не выходной");
}
if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота - наконец то выходной!!!");
}
if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье - наконец то выходной!!!");
}