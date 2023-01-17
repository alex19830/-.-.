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