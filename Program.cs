//Задача №41. 
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

/* Console.WriteLine(" Введите числа (через пробел!): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($" Количество чисел больше 0: {count}"); */

//Задача №43. 
//Написать программу, 
//которая на вход принимает массив из любого количества элементов (не менее 6) в промежутке от 0 до 100, 
//а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

/* Console.WriteLine("Введите кол-во элементов массива:");
int size = int.Parse(Console.ReadLine());
int[] Array1 = new int[size];
int tmp = 0;
Random r = new Random();

for (int i = 0; i < size; i++)
    Array1[i] = r.Next(0, 100);

foreach (int x in Array1)
    Console.Write(x + " ");

for (int i = 0; i < size; i++)
    for (int j = i + 1; j < size; j++)

        if (Array1[i] > Array1[j])
        {
            tmp = Array1[j];
            Array1[j] = Array1[i];
            Array1[i] = tmp;
        }
Console.WriteLine();
foreach (int x in Array1)
    Console.Write(x + " "); */