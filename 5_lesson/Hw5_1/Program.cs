// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);
    return arr;
}

void Chet(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i] % 2 == 0)
            sum++;
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {sum}");
}

int[] arr_1 = MassNums(int.Parse(Console.ReadLine()));
Print(arr_1);
Chet(arr_1);