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



// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
int[] myArray = CreateRandomArray(45, 100, 1000);
int count = 0;
for (int i = 0; i < myArray.Length; i++)
{
    
    int num = myArray[i];
    if (num % 2 == 0)
    {
        count++;
    }
}
ShowArray(myArray); 
Console.Write(count);

