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