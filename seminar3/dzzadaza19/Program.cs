//Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

int a = number / 10000;
int b = (number / 1000) % 10;
int c = (number / 100) % 10;
int d = (number / 10) % 10;
int e = number % 10;

if (a == e && b == d)
{
    Console.WriteLine("Да, это число является палиндромом.");
}
else
{
    Console.WriteLine("Нет, это число не является палиндромом.");
}
