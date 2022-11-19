//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите цифру, обозначающую день недели: ");
int x = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int x) {
  if (x == 6 || x == 7) {
  Console.WriteLine("выходной день");
  }
  else if (x < 1 || x > 7) {
    Console.WriteLine("не правильно задано число");
  }
  else Console.WriteLine("рабочий день");
}

CheckingTheDayOfTheWeek(x);
 