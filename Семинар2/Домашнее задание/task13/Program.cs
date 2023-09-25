// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.WriteLine("Введите число ->");

int num = int.Parse(Console.ReadLine());
string anyNumber = Convert.ToString(num);
if (anyNumber.Length > 2)
{
    Console.WriteLine($"Третья цифра числа {anyNumber[2]}");
}
else Console.WriteLine ("Третьей цифры нет");
