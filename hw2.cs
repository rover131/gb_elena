// Напишите программу, которая принимает на 
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)

Console.WriteLine($"{Math.Pow(i, 3)}");




﻿//Напишите программу, которая будет создавать массив из 8
// символов и заполнять значениями от пользователя

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

void printArray(int[] array)
{
   System.Console.WriteLine($"[{string.Join(", ", array)}]"); 
}

System.Console.Clear();
int[] array = new int[8];
int index = 0;
int n = 8;

for (int i = 0; i < 8; i++)
{
    Console.WriteLine("number: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}




﻿// // Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10,90);
}

void ReleaseArray(int[] array)
{
    int s = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0) 
            s = s + array[i];

    Console.WriteLine ($" Сумма нечетных позиций = {s}");
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Clear();
Console.WriteLine ($"n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
ReleaseArray(array);

