// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.Write("Введите элементы массива через пробел: "); // получили строку
string elements = Console.ReadLine(); // считали элементы строки
int[] baseArray = GetArrayFromString(elements); // конвертировали его в массив целых чисел
Console.Write("Введите число: "); // получили число
int n = int.Parse(Console.ReadLine());
if (FindElement(baseArray, n)) // воспользовались функцией FindElement, получили либо true либо false
{
Console.WriteLine("Да"); //если true - да
}
else
{
Console.WriteLine("Нет"); //если false - нет
}


int[] GetArrayFromString(string stringArray) // конвертировали его в массив целых чисел
{
string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] res = new int[nums.Length];

for (int i = 0; i < nums.Length; i++)
{
res[i] = int.Parse(nums[i]);
}
return res;
}

bool FindElement(int[] array, int el)//[1,2,3,4] 5   нашли элемент в массиве array или нет
{
foreach (var item in array)//
{
if (el == item) // 5 == 4
return true;
}
return false;
}