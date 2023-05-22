// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
string OutPutNumber(int Number)
{
    if(Number> 1)
    { 
        return Number +  ", " + OutPutNumber(Number-1).ToString();  
    }
 return Number.ToString();
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write(OutPutNumber(number));












﻿// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
int SumDigital(int m, int n)
{
    if(m == n)
    {   
         return m;
    }
    return SumDigital(m+1,n)+m;
}

Console.Write("Введите число M: ");//просим пользователя ввести число
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");//просим пользователя ввести число
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SumDigital(m,n));
















﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
int Akkerman(int m, int n)
{
    if(m == 0)
    {   
         return n+1;
    }
    if (m > 0 && n == 0)
    {
         return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Введите число M: ");//просим пользователя ввести число
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");//просим пользователя ввести число
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Akkerman(m,n));
