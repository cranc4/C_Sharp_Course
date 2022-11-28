// 2: Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.

int Num(int n)
{
    Console.WriteLine($"Random number: {n}");
   return n/100*10 + n%10;
}
Console.WriteLine(Num(new Random().Next(100,1000)));