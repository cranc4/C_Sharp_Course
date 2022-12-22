// 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void Nums(int m, int n)
{
    if (m > n) return;
    if (m % 2 == 0)
    {
        Console.Write($" {m} ");
        Nums(m + 2, n);
    }
    else
    {
        m += 1;
        Console.Write($" {m} ");
        Nums(m + 2, n);
    }
}

Console.WriteLine("Enter Numbers: ");
Nums(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));