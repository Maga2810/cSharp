// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введи трёхзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
string a = Convert.ToString(x);
Console.WriteLine("вторая цифра этого числа -> "+a[1]);