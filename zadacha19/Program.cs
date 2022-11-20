// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

void СheckForPalindrome(string number)
{
    while (number.Length != 5)
    {
        Console.WriteLine("Пожалуйста, введите пятизначное число");
        number = Console.ReadLine();
    }
    if (number[0] == number[4] && number[1] == number[3])
        Console.WriteLine("Число является палиндромом");
    else
        Console.WriteLine("Число не является палиндромом");
}
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
СheckForPalindrome(number);
