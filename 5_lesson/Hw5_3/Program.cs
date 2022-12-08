// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100);
    return arr;
}

void Max_Min(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine($"Разность между максимальным и минимальным элементом массива: {Math.Round(max - min)}");
}

Console.WriteLine("Введите количество элементов массива:");

double[] arr_1 = MassNums(int.Parse(Console.ReadLine()));
Print(arr_1);
Max_Min(arr_1);