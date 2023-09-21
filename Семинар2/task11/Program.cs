// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int lastDigit = num % 10;
int firstDigit = num / 100;
int result = firstDigit * 10 + lastDigit;

Console.WriteLine(result);