// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Clear();
int[] startArray = GetArray(10, 0, 10);
Console.WriteLine(String.Join(", ", startArray));
Console.WriteLine(String.Join(", ", InversArray(startArray)));

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}

int[] InversArray(int[] array){
for (int i = 0; i < array.Length - i; i++)
{
    int t = array[i];
    array[i] = array[array.Length - 1 - i];
    array[array.Length - 1 - i] = t;
}
return array;
}