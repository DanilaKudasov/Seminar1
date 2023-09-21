// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Число один - ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Число два - ");
int num2 = int.Parse(Console.ReadLine());

if (num % num2 == 0)
{
    Console.WriteLine("Число 1 кратно числу 2");
}
else
{
    Console.WriteLine($"Число 1 не кратно числу 2 остаток {num % num2}");
}