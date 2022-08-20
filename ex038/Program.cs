// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();

int[] myArray = CreateRandomArray(6, 1, 1000);
ShowArray(myArray);
int min = myArray[0];
int max = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (max < myArray[i])
    {
        max = myArray[i];
    }
    if (min > myArray[i])
    {
        min = myArray[i];
    }
}
Console.WriteLine($"Максимальное значение {max} и минимальное значение {min}. Разница между ними равна {max - min}");

