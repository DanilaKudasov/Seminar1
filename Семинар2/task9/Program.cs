﻿// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 10;

if (firstDigit > lastDigit)
{
    Console.WriteLine($"Первая цифра больше второй. Наибольшая цифра = {firstDigit}");
}
else if(firstDigit < lastDigit)
{
    Console.WriteLine($"Вторая цифра больше первой. Наибольшая цифра = {lastDigit}");
}
else
{
    Console.WriteLine("Цифры равны");
}