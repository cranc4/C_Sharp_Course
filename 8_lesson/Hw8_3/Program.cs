//  3: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

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

void MultiMass(int[,] arr1, int[,] arr2, int[,] arr3)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(0); k++)
            {
                arr3[i, j] += (arr1[i, k] * arr2[k, j]);
            }
        }
    }
}

Console.Write("The size of squared matrix: ");

int size = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(size, size,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
int[,] arr_2 = MassNums(size, size,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
int[,] arr_3 = new int[size, size];                        
Print(arr_1);
Print(arr_2);
MultiMass(arr_1, arr_2, arr_3);
Console.WriteLine("Multiplication matrix:");
Print(arr_3);