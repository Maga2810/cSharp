//for (int i = 1; i < 10; i++)
//{
 //   Console.WriteLine($"{i + 10} - Я всегда прав");
//}

//int k = 0;
//while (k < 10 || k < 20)
//
//     k += 2;
 //   if(k==8)
  //  {
   //     break;
    //}
    //Console.WriteLine($"{k} - I am always");
    
//}

//int i = -1;
//int j = 3;
//Console.WriteLine(i);
//int result = Math.Max(i, j);
//Console.WriteLine(result);

//double i = -1.56789;
//int j = 3;
//Console.WriteLine(i);
//double result = Math.Round(i);
//Console.WriteLine(result);

// int i = new Random().Next(1, 3);
// Console.WriteLine(i);

// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую его цифру.
// 78 -> 8
// 12 -> 2
// 85 -> 8

int num = new Random().Next(10, 99);
Console.WriteLine(num);
int n1 = num / 10;
int n2 = num % 10;
if (n1 > n2) Console.WriteLine(n1);
else Console.WriteLine(n2);
