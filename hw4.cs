// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Promt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power(int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }
    return power;
}

bool ValidateExponent (int exponent)
{
    if (exponent <0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Promt ("Введите основание: ");
int exponent = Promt ("Введите показатель: ");
if (ValidateExponent(exponent))
{
    System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power (powerBase, exponent)}");
}










﻿// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int SumAllDigit (int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Promt ("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number}= {SumAllDigit(number)}");











﻿// Задача 29:Напишите программу, которая будет создавать массив 
// из 8 символов и заполнять значениями от пользователя
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void PrintArray(int[]array)
{
    System.Console.WriteLine($"[{String.Join(",", array)}]");
}

System.Console.Clear();
int[] array = new int [8];
int index = 0;

while (true)
{
    System.Console.WriteLine ("Press Enter for quit or enter number: ");
    string a = Console.ReadLine();

    if (a == string.Empty)
    {
        break;
    }
    array[index] = ConvertToInt32(a);
    index ++;
    PrintArray(array);
    if (index== array.Length)
    {
        index = 0;
    }
}
System.Console.WriteLine("Finish");
