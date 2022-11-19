// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
string xText = Convert.ToString(x);
if (xText.Length > 2){
  Console.WriteLine("третья цифра - " + xText[2]);
}
else {
  Console.WriteLine("- третьей цифры нет");
}