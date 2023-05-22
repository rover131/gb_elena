// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void InputArray (int[] array)
{
	for (int i = 0;  i < array.Length; i++)
		array[i] = new Random().Next (100, 1000); 
}

int RealeseArray (int[] array)
{
	int count = 0;
for (int i = 0; i < array.Length; i++) 
	if (array[i] >= 0 && array [i]%2 == 0)
		count ++;
return count;
}

void PrintArray (int[] array)
{
	Console.WriteLine ($"[{string.Join (",",  array)}]");
}
Console.Clear();
Console.Write($"n =");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray (array);
PrintArray (array);
Console. WriteLine(RealeseArray(array));















﻿// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void InputArray (int[] array)
{
	for (int i = 0;  i < array.Length; i++)
		array[i] = new Random().Next (0, 1000); 
}

int RealeseArray (int[] array)
{
	int sum = 0;
for (int  i = 1;  i <array.Length; i+=2) 
    sum = sum + array[i];
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {sum}");
return sum;
}

void PrintArray (int[] array)
{
	Console.WriteLine ($"[{string.Join (",",  array)}]");
}
Console.Clear();
Console.Write($"n =");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
InputArray (array);
PrintArray (array);
RealeseArray(array);














﻿// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InputArray (double[] array, double avg=0)
{
	for (int i = 0; i < array.Length; i++)
		array[i] = Math.Round(new Random().NextDouble () *(50-10)+10); 
}

double ReleaseArray (double[] array, double avg)
{
    double max1= array[0];
    double min1= array[0];
for (int i = 0; i < array.Length; i++) 
	if (array[i] > max1)
        max1 = array[i];
for (int i = 0; i < array.Length; i++) 
    if (array[i] < min1)
        min1= array[i];
avg= max1 - min1; 
return avg;
}       

void PrintArray (double[] array)
{
	Console.WriteLine ($"[{string.Join (",",  array)}]");
}
Console.Clear();
Console.Write($"n =");
int n = Convert.ToInt32(Console.ReadLine()); 
double avg = 0;
double[] array = new double [n];

InputArray (array);
PrintArray (array);
Console. WriteLine(ReleaseArray(array, avg));
