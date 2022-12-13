// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] MassNums(int size)
{
    Console.WriteLine("Введите числа: ");

    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = int.Parse(Console.ReadLine());
    return array;
}

void Count(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {   
        if(arr[i] > 0)
            sum++;
    }
    Console.WriteLine($"Чисел больше 0: {sum}");
}

Console.WriteLine("Введите количество чисел М: ");
int[] arr_1 = MassNums(int.Parse(Console.ReadLine()));
Count(arr_1);