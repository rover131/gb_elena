// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число" );
string n = Console.ReadLine();
{
  if (n [0]==n[4] || n[1]==n[3])
  {
    Console.WriteLine($"Ваше число: {n} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {n} - НЕ палиндром.");
}


﻿// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.Write("x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1 = ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2 = ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine( Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2)+ Math.Pow(z1-z2, 2)));





﻿// Напишите программу, которая принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число n =");
int n = Convert.ToInt32(Console.ReadLine());

for (int i=1; i <= n; i++)
    Console.Write($"{Math.Pow(i, 3)} ");
