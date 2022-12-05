// 2: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

int SumNums(int num)
{
    int sum = 0;
    int remaider = 0;
    while (num > 0)
    {
        remaider = num % 10;
        sum = sum + remaider;
        num = num / 10;
    }

    return sum;
}

Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));