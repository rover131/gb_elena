// Пользователь вводит с клавиатуры M чисел 
// посчитайте сколько чисел больше 0 ввел пользователь
// 0, 7, 8, -2, -2->2
//1,-7, 567, 89, 223 ->3
Console.Clear();
Console.Write("Введите M чисел: ");
int[]array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count =0;

for (int i = 0; i<array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Колличество чисел больше 0 :{count}");








﻿// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2*x +b2;
// значения b1, k1, b2 и k2 задаются пользователем
// b1=2, k1 =5, b2= 4, k2 =9 -> (-0,5;-0,5)
Console.Clear();
Console.Write("Введите значения b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значения k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значения b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значения k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = -(b1-b2)/ (k1-k2);
double y = k2*x +b2;
x=Math.Round(x,3);
y=Math.Round(y,3);
Console.WriteLine($"Пересечение в точке: ({x};{y})");

