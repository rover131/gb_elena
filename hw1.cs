// Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите 1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if(b > a)
    max = b;
if(c > a)
    max = c;    
 
Console.WriteLine(max);


﻿//  Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= n; i++)
    if (i % 2 == 0)
    Console.WriteLine($"{i}");


﻿//  Напишите программу, которая выводит
//третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n > 100)
    Console.WriteLine($"{n % 10}");
else
Console.WriteLine("третьей цифры нет");

﻿// Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n3 = n / 10 % 10;
int n4 = n % 10;
if(n1 == n4)
    if(n2 == n3)
    Console.WriteLine("да");
else
Console.WriteLine("нет");
