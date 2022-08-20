// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
int sum = 0;
for (int i = 0; i < myArray.Length; i++)
{
    if (i % 2 == 0) 
    {
        sum += myArray[i]; 
    }
}
Console.WriteLine(sum);

