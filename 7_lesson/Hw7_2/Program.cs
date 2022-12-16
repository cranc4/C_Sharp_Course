// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void FindElem(int[,] arr, int row1, int column1)
{
    if (row1 > arr.GetLength(0) || column1 > arr.GetLength(1))
        Console.WriteLine($"Element not found");
    else
        Console.WriteLine($"Еlement at position [{row1}, {column1}] = {arr[row1 - 1, column1 - 1]}");
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.Write("Enter the row number: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the column number: ");
int column1 = int.Parse(Console.ReadLine());
FindElem(arr_1, row1, column1);