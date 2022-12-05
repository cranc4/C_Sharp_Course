// 1: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = int.Parse(Console.ReadLine());

int Degree (int A, int B)

{
    int A_degree_B = 1;

    for (int i = 1; i <= B; i++)
    {
        A_degree_B*= A;
    }
    return A_degree_B;
}
Console.WriteLine($"А в степени В = {Degree(numA, numB)}");