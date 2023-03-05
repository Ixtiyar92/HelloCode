// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
Console.Write("Введите элементы массива через пробел: "); // получили строку
string elements = Console.ReadLine(); // считали элементы строки
int[] baseArray = GetArrayFromString(elements); // строку отправляем в функцию GetArrayFromString и записываем результат в массив baseArray (конвертировали его в массив целых чисел)
Console.Write("Введите число: "); // ввели число
int n = int.Parse(Console.ReadLine()); 
if (FindElement(baseArray, n)) // воспользовались функцией FindElement (в скобках массив baseArray, число n)
{
Console.WriteLine("Да"); //если true - да
}
else
{
Console.WriteLine("Нет"); //если false - нет
}


int[] GetArrayFromString(string stringArray) // функция GetArrayFromString на вход принимает строку, которую пользователь ввёл с консоли
{
string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); // создали массив строк string[] nums, методом Split разъединили изначальную строку на пробелы и записали в массив nums
int[] res = new int[nums.Length]; // создали массив res на количество элементов, которое находится в массиве nums

for (int i = 0; i < nums.Length; i++) // запускаем цикл, в котором перебираем все элементы массива nums
{
res[i] = int.Parse(nums[i]); // переводим их в число, используя int.Parse и записываем их на ту же позицию в массив res
}
return res; // выводим массив res
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