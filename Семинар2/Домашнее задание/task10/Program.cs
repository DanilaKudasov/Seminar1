// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // // 918 -> 1


Console.WriteLine("Введите трехзначное число -> ");
int num = int.Parse(Console.ReadLine());

int lastDigit = num % 10;
int firstDigit = num % 100;

int result = (firstDigit - lastDigit) / 10;
Console.WriteLine(result);

// Второе решение
// Console.WriteLine("Введите трехзначное число -> ");
// string input = Console.ReadLine();
// Console.WriteLine("{0}->{1}",input, input[1]);