// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели -> ");
int num = int.Parse(Console.ReadLine());
if (num == 6 || num == 7) Console.WriteLine ("Это выходной");
else if (num > 7) Console.WriteLine ("Это не день недели");
else Console.WriteLine("Это будний день");
