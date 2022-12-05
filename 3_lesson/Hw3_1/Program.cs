// Задача 19 Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

string Num (int num)
{
    if ((10000 > num && num > 99999) || (-10000 < num && num< -99999))
        return $"The number is not five-digit!";
        else if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10 )
            return "Palindromic";

        return "The number is not Palindromic";   
}
Console.WriteLine(Num(int.Parse(Console.ReadLine())));