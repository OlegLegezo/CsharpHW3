// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.WriteLine("введите целое положительное пятизначное число:");
int a = int.Parse(Console.ReadLine());
int oldValue = a;

int TurnOverValue(int b) //метод переворота цифр числа
{
    int newValue = 0;
    while (b > 0)
    {
        int part = b % 10;
        newValue = newValue * 10 + part;
        b = b / 10;
    }
    return newValue;
}

int newValue = TurnOverValue(oldValue); //использую свой метод переворота

Console.WriteLine(newValue + " - перевернутое число"); //просто для самопроверки

if (newValue == oldValue)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");


