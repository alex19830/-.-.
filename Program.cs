// Задача 1 
/*int number = new Random().Next(10, 100);
Console.WriteLine($"{number}");
int number1 = number/10;
int number2 = number%10;
if(number1>number2)
Console.WriteLine($"Большая цифра {number1}");
else
Console.WriteLine($"Большая цифра {number2}");*/

// Задача 2 
/*Console.WriteLine("Введите число a: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int number1 = int.Parse(Console.ReadLine());
if(number%number1==0)
{
Console.WriteLine($"Число {number} кратно числу {number1} ");
}
else
{
    Console.WriteLine($"Число {number} и число {number1} - Не кратные с остатком {number%number1} ");
}*/

// Задача 3 
/*Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if((number % 7 == 0) && (number % 23 == 0)){
    Console.WriteLine($"Число {number} кратно 7 и 23 одновременно !");
}
else{
    Console.WriteLine($"Число {number} не кратно 7 и 23 одновременно!");
}*/

// Задача 4 
/*Console.Write("Введите первое число: ");
int first_number = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int second_number = int.Parse(Console.ReadLine()!);
if((first_number == Math.Pow(second_number, 2)) || (second_number == Math.Pow(first_number, 2))){
    Console.WriteLine("Одно чило является квадратом второго!");
}
else{
    Console.WriteLine("Числа не являются квадратом друг друга.");
}*/

// Домашняя работа (Базовые алгоритмы)------------------------------------------------------------------------------------------------------------------

// Задача 1++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*Console.WriteLine ("Введите целое число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number < 100||number > 999){
  Console.Write ("Вы ввели не трехзначное число");
}
else{
    Console.WriteLine($"Вторая цифра данного числа {number = number / 10%10}");
}*/

// Задача 2++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = num;
int i = 0;
if (num > 99 || num < -99){
    while (num != 0){
    num /= 10;
    i++;
    }
while (i > 3){
    res /= 10;
    i--;
    }
res %= 10;
Console.WriteLine(res);
}
else { Console.WriteLine("Третьей цифры нет!");
}*/

// Задача 3+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*Console.WriteLine("Введите номер дня недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day <= 5) Console.WriteLine("Будний день");
if (day == 6 || day == 7) Console.WriteLine("Выходной день");
if (day > 7 || day <= 0) Console.WriteLine("День недели не найден (нумерация дней недели от 1 до 7)");*/

// Базовые алгоритмы урок 2

/*Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine()!);
switch (num)
{
    case 1: {
        Console.WriteLine("x > 0, y > 0");
        break;
    }case 2: {
        Console.WriteLine("x < 0, y > 0");
        break;
    }case 3: {
        Console.WriteLine("x < 0, y < 0");
        break;
    }case 4: {
        Console.WriteLine("x > 0, y < 0");
        break;
    }
    default:{
        Console.WriteLine("Введено не верное число");
        break;
    }
}*/

/*Console.WriteLine("Введите координату X точки1: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X точки2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки2: ");
int yb = int.Parse(Console.ReadLine()!);
double res = Math.Sqrt(Math.Pow(xb = xa, 2) + Math.Pow(yb = ya, 2));
Console.WriteLine($"Расстояние между точками: {res:f2}");*/

/*Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++){
    Console.Write($"{Math.Pow(i, 2)}, ");
}*/

// Домашняя работа 2 (Базовые алгоритмы часть 2)----------------------------------------------------

// Задача 1+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
if (number is not null){
    if (number.Length == 5){
        if ((number[0] == number[4]) && (number[1] == number[3])){
            Console.WriteLine($"{number} - палиндром");
        }
        else{
            Console.WriteLine($"{number} - не палиндром");
        }
    }
    else{
        Console.WriteLine("Введено некорректное значение");
    }
}*/

// Задача 2++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*double X1, Y1, Z1, X2, Y2, Z2;
Console.WriteLine("Введите координаты первой точки X1:");
X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Y1:");
Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Z1:");
Z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки X2:");
X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Y2:");
Y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Z2:");
Z2 = Convert.ToDouble(Console.ReadLine());
double distance;
distance = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
                Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
                Console.ReadKey();*/

// Задача 3++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

/*Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
for (int i = 1; i <= n; i++){
    Console.Write($"{Math.Pow(i, 3)}, ");
}*/

// ФУНКЦИИ ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

// Напишите программу, которая принимает на ввод число (А) и выдает сумму чисел от до А.
/* Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {limit} равна {GetSum(limit)}");
Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {Num} равна {GetSum(Num)}");

//------------------МЕТОДЫ------------------------------
int GetSum(int A){
    int sum = 0;
    for(int i = 1; i <= A; i++){
        sum += i; // sum + i
    }
    return sum;
} */

/* c
Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetMultiply(N)}");

//-------метод-----------
int GetMultiply(int N){
    int m = 1;
    for ( int i = 1; i <= N; i++ ){
        m = m * i;
    }
    return m;
} */

/* Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр {N} равно {CountNums(N)}");
string M = N.ToString();
Console.Write($"Количество цифр {M} равно {CountNums2(M)}");
//----------метод---------------
int CountNums(int num){
    int count = 0;
    if (num == 0) return 1;
    while (num > 0){
        count++;
        num = num / 10;
    }
    return count;
}
int CountNums2(string num){
    int count = num.Length;
    return count;
} */

/* int[] myArray = GetArray(8); 
Console.WriteLine($"[{String.Join(",", myArray)}]");
// -----------метод----------------
int[] GetArray (int size){
    int[] myArray = new int[size];
    for(int i = 0; i < size; i++){
        myArray[i] = new Random().Next(2);
    }
    return myArray;
} */

//+++++++++++++++++Урок 4. Функции. Домашняя работа. +++++++++++++++++++++++++++++++++++++++++++++++++++++++
//------------------Задача. 1

//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/* Console.Clear();
Console.WriteLine("программа, принимающая два числа А и В и возводящая число А в натуральную степень В");
int numA = 0;
int numB = 0;
int sum = 0;
// ввод числа А
while(true){
    Console.WriteLine("Введите целое число А:");
    if(int.TryParse(Console.ReadLine(), out int number)){
        numA = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}
// ввод числа В
while(true){
    Console.WriteLine("Введите целое натуральное число В:");
    if(int.TryParse(Console.ReadLine(), out int number)){
        if(number < 0){
            Console.WriteLine("Вами введено НЕ натуральное число (отрицательное)!");
            continue;
        }
        else numB = number; break;
    }
    else Console.WriteLine("Некорректно указано число!\n");
}
Console.WriteLine("число " + numA + " в степени " + numB + " = " + Calculate(numA, numB));
int Calculate(int a, int b){
    if (a == 0 && b == 0){
        sum = 1;
    }
    else{
        sum = a;
        for(int i = 1; i < b; i++){
            sum = sum * a;
        }
    }
    return sum;
} */
//----------------------Задача. 2

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/* internal class Program{    
    private static void Main(string[] args){
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine()!);
        int sum(int number){
            int count = Convert.ToString(number).Length;
            int a = 0;
            int result = 0;
            for (int i = 0; i < count; i++){
                a = number - number % 10;
                result = result + (number - a);
                number = number / 10;
            }
            return result;
        }
        int sumNumber = sum(number);
        Console.WriteLine("Сумма цифр в числе: " + sumNumber);
    }
} */

//--------------------Задача 3
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/* int[] array = new int[8];
void RandomArray(int[] array){
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rnd.Next(0, 7);
    }
}
void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}
RandomArray(array);
PrintArray(array);
 */

/* int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array){
    if(el > 0){
        positiveSum += el;
    }
    else{
        negativeSum += el;
    }
}
 Console.WriteLine($"Сумма положительных чисел равна {positiveSum}, а сумма отрицательных равна {negativeSum}");
 //-------------Метод----------------------
 int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue = 1);
    }
    return res;
 } */

/* /***Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

/* int[] array = GetArray(6, -100, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
for(int i = 0; i < array.Length; i++){
    array[i] *= -1;
}

Console.WriteLine($"[{String.Join(",", array)}]"); */

/* int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}  */

/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да */


/* int[] array = GetArray(10, 1, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if(findElement(array, a)){
    Console.WriteLine("Данный элемент в массиве есть");
}
else{
    Console.WriteLine("Данный элемент в массиве не существует");
}
bool findElement(int[] array, int a){
    foreach (int el in array){
    if(el == a){
        return true;
    }
} return false;
} */

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

/* int[] array = GetArray(123, 0, 1000);
Console.WriteLine($"[{String.Join(",", array)}]");
int CountElement(int[] array){   
    int count = 0;
    foreach(int el in array){
        if(el >= 10 && el <= 99){
            count++;
        }
    } 
    return count;
}
Console.WriteLine($"Количество элементов в отрезке от 10 до 99 {CountElement(array)}"); */

/* Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.*/
/* int[] array = GetArray(10, -10, 10);
Console.WriteLine($"[{String.Join(",", array)}]");
int DifNums(int[] array){
    int min = array[0];
    int max = array[0];
    foreach (int el in array){
    if(el > max){
        max = el;
    }
    if(el < min){
        min = el;
    }
} return max - min;
}
Console.WriteLine(DifNums(array)); */

//++++++++++++Домашняя работа+++++++++++++++
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2

/* int[] Array = getGenerateArray(10, 100, 999);
printArr(Array);
int count = getCountPositive(Array);
int[] getGenerateArray(int length, int start, int end){
    int[] result = new int[length];
    for (int i = 0; i < length; i++){
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
void printArr( int[] array )
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i]);
        if (i  < array.Length -1){
           Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int getCountPositive(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            count = count + 1;
        }
    }
    return count;
}
Console.WriteLine($"Сумма положительных чисел в массиве равна {count}"); */

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
System.Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Arraywithrandomnumbers(array);
int sum= 0;
for (int k = 1; k < array.Length; k+=2){
    sum += array[k];
}
void Arraywithrandomnumbers(int[] array){
Random rnd = new Random();
for (int i = 1; i < array.Length; i++){
    array[i] = rnd.Next(-99,100);
    }
}
System.Console.WriteLine("Наш массив: [" + string.Join(", ", array) + "]");
System.Console.WriteLine($"Сумма чисел на нечетных индексах {sum}");

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21
/* Console.Clear();
void FillArray(int[] arr){
    for (int i = 0; i < arr.Length; i++){
        arr[i] = new Random().Next(100);
    }
}
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }
}
Console.WriteLine("Задайте длину массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] nums = new int[length];
int[] result = new int[nums.Length / 2];

FillArray(nums);
PrintArray(nums);

Console.WriteLine();
for (int i = 0; i < result.Length; i++){
    result[i] = nums[i] * nums[nums.Length - 1 - i];
}
PrintArray(result); */