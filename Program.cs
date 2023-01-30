//-------------------Домашняя работа---------------------------------

/*Задача 54:
Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/* int m, n;
int value = 1;
Console.Write("Введите кол-во строк: ");
m = Int32.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
n = Int32.Parse(Console.ReadLine());
Random rnd = new Random();
int[,] numbs = new int[m, n];
int row = rnd.Next(numbs.GetLength(0) + 1);
int col = rnd.Next(numbs.GetLength(1) + 1);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        numbs[i, j] = value;
        Console.Write(numbs[i, j] + " ");
        value++;
    }
    Console.WriteLine();
}
void PrintArray(int[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] newArray = ChangeArray(array: numbs, m: row, n: col);
int[,] ChangeArray(int[,] array, int m, int n)
{
    int temp = new int();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1) - 1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if ((array[i, j] < array[i, k]))
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }

        }
    }
    return array;
}
PrintArray(newArray); */

/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */
/* int m, n;
int value = 1;
Console.Write("Введите кол-во строк: ");
m = Int32.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
n = Int32.Parse(Console.ReadLine());
Random rnd = new Random();
int[,] numbs = new int[m, n];
int row = rnd.Next(numbs.GetLength(0) + 1);
int col = rnd.Next(numbs.GetLength(1) + 1);
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        numbs[i, j] = value;
        Console.Write(numbs[i, j] + " ");
        value++;
    }
    Console.WriteLine();
}
void PrintUnivariateArray(int[] tempArray)
{
    Console.WriteLine($"Суммы элементов строк массива: {string.Join(", ", tempArray)}");
}
int[] StringsValue(int[,] tempArray)
{
    int[] result = new int[tempArray.GetLength(0)];
    int stringSum = new int();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            stringSum += tempArray[i, j];
        }
        result[i] = stringSum;
        stringSum = 0;
    }
    return result;
}
void MinStringNumber(int[] tempArray)
{
    int result = new int();
    int min = tempArray.Min();
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] == min) result = i + 1;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}");
}
int[] stringsValue = StringsValue(tempArray: numbs);
PrintUnivariateArray(tempArray: stringsValue);
MinStringNumber(tempArray: stringsValue); */

/*
Задача 58:
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/* (int, int, int, int) GetValues()
{
    (int, int, int, int) result = (0, 0, 0, 0);
    while (true)
    {
        Console.Write("Введите число строк первой матрицы: ");
        int stringsNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число столбцов первой матрицы: ");
        int columnsNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число строк второй матрицы: ");
        int stringsNumber2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число столбцов второй матрицы: ");
        int columnsNumber2 = Convert.ToInt32(Console.ReadLine());
        result = (stringsNumber1, columnsNumber1, stringsNumber2, columnsNumber2);
        if (CheckArray(a: columnsNumber1, b: stringsNumber2) == true) break;
    }
    return result;
}
bool CheckArray(int a, int b)
{
    if (a == b)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Произведение матриц невозможно (число столбцов первой матрицы не равно числу строк второй)\n");
        return false;
    }
}
int[,] InitArray(int arrayStrings, int arrayColumns)
{
    int[,] tempArray = new int[arrayStrings, arrayColumns];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = rnd.Next(0, 10);
        }
    }
    return tempArray;
}
void PrintMultivariateArray(int[,] tempArray, int number)
{
    if (number <= 2)
        Console.WriteLine($"Матрица {number}: ");
    else
        Console.WriteLine($"Результирующая матрица: ");
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int MatrixCount(int number)
{
    int result = new int();
    result = number + 1;
    return result;
}
int[,] MatrixMultiplication(int[,] tempArray1, int[,] tempArray2)
{
    int[,] result = new int[tempArray1.GetLength(0), tempArray2.GetLength(1)];
    for (int i = 0; i < tempArray1.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray2.GetLength(1); j++)
        {
            for (int k = 0; k < tempArray1.GetLength(1); k++)
            {
                result[i, j] += tempArray1[i, k] * tempArray2[k, j];
            }
        }
    }
    return result;
}
(int, int, int, int) arrayParameters = GetValues();
Console.WriteLine();
int matrixNumber = 0;
int[,] matrix1 = InitArray(arrayStrings: arrayParameters.Item1, arrayColumns: arrayParameters.Item2);
matrixNumber = MatrixCount(number: matrixNumber);
PrintMultivariateArray(tempArray: matrix1, number: matrixNumber);
Console.WriteLine();
int[,] matrix2 = InitArray(arrayStrings: arrayParameters.Item3, arrayColumns: arrayParameters.Item4);
matrixNumber = MatrixCount(number: matrixNumber);
PrintMultivariateArray(tempArray: matrix2, number: matrixNumber);
Console.WriteLine();
int[,] matrix3 = MatrixMultiplication(tempArray1: matrix1, tempArray2: matrix2);
matrixNumber = MatrixCount(number: matrixNumber);
PrintMultivariateArray(tempArray: matrix3, number: matrixNumber); */

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
/* int n = 4;
int[,] spiraleMatrix = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= spiraleMatrix.GetLength(0) * spiraleMatrix.GetLength(1))
{
    spiraleMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < 3)
        j++;
    else if (i < j && i + j >= 3)
        i++;
    else if (i >= j && i + j > 3)
        j--;
    else
        i--;
}
WriteArray(spiraleMatrix);
void WriteArray(int[,] array)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
} */