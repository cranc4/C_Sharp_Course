// 4: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

string Week(int data)
{
    if (data > 7)
        return "Not a week day";
    else if (data == 6 || data == 7)
        return "Weekend";
    else
        return "Weekday";           
}

Console.WriteLine("Input  day number:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Week(num));