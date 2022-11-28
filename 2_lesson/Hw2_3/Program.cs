// 3: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

string Num(int n)
{
    if (n < 100)
        return "not have third number";
    else if (n < 1000)
        return $"Number is {n % 10}"; 
    else
    {
        while (n > 1000)
        {
            n = n / 10;
        }   
    }
        return $"Number is {n % 10}";  

}

Console.WriteLine("Input number:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Num(num));