﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine("Число является квадратом");
}
else
{
    Console.WriteLine("Числа не являются квадратом");
}