//-------------------Домашняя работа---------------------------------

// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// int GetNumber(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine() ?? "");
//     return number;
// }
// void RecursionNum(int n)
// {
//     if (n < 1)
//     {
//         return;
//     }
//     Console.Write($"{n}, ");
//     RecursionNum(n - 1);
// }
// int n = GetNumber("Введите число:");
// RecursionNum(n);



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int GetNumber(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine() ?? "");
//     return number;
// }
// int RecursionNum(int m, int n, int sum = 0)
// {
//     if (m > n)
//     {
//         int tmp;
//         tmp = n;
//         n = m;
//         m = tmp;
//     }
//     if (m == n)
//     {
//         return sum + m;
//     }
//     sum += m;
//     return RecursionNum(m + 1, n, sum);
// }
// int m = GetNumber("Введите число m:");
// int n = GetNumber("Введите число n:");
// Console.Write($"{RecursionNum(m, n)}");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int GetNumber(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine() ?? "");
//     return number;
// }
// int Akkerman(int n, int m)
// {
//     if (n == 0) return m + 1;
//     else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
//     else return Akkerman(n - 1, Akkerman(n, m - 1));
// }
// int m = GetNumber("Введите число m:");
// int n = GetNumber("Введите число n:");
// Console.Write($"{Akkerman(m, n)}");