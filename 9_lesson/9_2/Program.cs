// 2: Задайте значения M и N. Напишите программу, которая
// рекурсивно выведет все натуральные числа в промежутке от M до N.

void Nums(int m, int n)
{
    if (m > n) return;
    Console.WriteLine($" {m} ");
    Nums(m + 1, n);
}
Nums(5, 8);