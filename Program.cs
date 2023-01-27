﻿//-------------------Домашняя работа---------------------------------

//Задача 47
//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

/* Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
} */

//Задача 50. Напишите программу, которая на вход принимает число, 
//проверяя есть ли такое число в двумерном массиве и возвращает сообщение о том, 
//что оно найдено или же указание, что такого элемента нет.

/* Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение: ");
int b = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, colums, a, b);
PrintArray(array);
ElArray(array);
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
void ElArray(int[,] array)
{
    bool res = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j])
            {
                res = true;
            }
        }
    }
    if (res == true)
    {
        Console.WriteLine($"{num} -> Такое число в массиве есть");
    }
    else
    {
        Console.WriteLine($"{num} -> Такого числа в массиве нет");
    }
} */

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

/* int[,] array = GetArray(3, 4, 1, 10);
PrintArray(array);

for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{sum / array.GetLength(0)} ");
}
Console.ReadLine();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}");
            Console.Write($" ");
        }
        Console.WriteLine();
    }
} */