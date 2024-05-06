using System;

//1. Даны десять вещественных чисел. Найти их сумму.

//double sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//	Console.Write($"Введите {i} число: ");
//	sum += double.Parse(Console.ReadLine());
//}
//Console.WriteLine(sum);


//2. Даны десять вещественных чисел. Найти их произведение.

//double product = 1;
//for (int i = 1; i <= 10; i++)
//{
//	Console.Write($"Введите {i} число: ");
//	product *= double.Parse(Console.ReadLine());
//}
//Console.WriteLine(product);


//3. Даны десять вещественных чисел. Найти их среднее арифметическое.

//double sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//	Console.Write($"Введите {i} число: ");
//	sum += double.Parse(Console.ReadLine());
//}
//Console.WriteLine(sum / 10);


//4. Дано целое число N и набор из N вещественных чисел. Вывести сумму и произведение чисел
//из данного набора.

//Console.Write($"Введите число N: ");
//int n = int.Parse(Console.ReadLine());
//double sum = 0, product = 1, numbers;
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"Введите {i} число: ");
//    numbers = double.Parse(Console.ReadLine());
//    sum += numbers;
//    product *= numbers;
//}
//Console.WriteLine($"сумма равна {sum}, произведение равно {product}");


//5. Дано целое число N и набор из N положительных вещественных чисел. Вывести в том же порядке
//целые части всех чисел из данного набора (как вещественные числа с нулевой дробной частью), а также
//сумму всех целых частей.

//Console.Write($"Введите число N: ");
//int n = int.Parse(Console.ReadLine());
//double integer = 0, sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"Введите {i} число: ");
//    double number = double.Parse(Console.ReadLine());
//    while (number >= 1)
//    {
//        number--;
//        integer++;
//    }
//    Console.WriteLine($"целая часть от {i}-го числа равна {integer},0");
//    sum += integer;
//    integer = 0;
//}
//Console.WriteLine("сумма всех целых частей равна " + sum);

//Console.Write($"Введите число N: ");
//int n = int.Parse(Console.ReadLine());
//double integer = 0, sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"Введите {i} число: ");
//    double number = Math.Floor(double.Parse(Console.ReadLine()));
//    Console.WriteLine($"целая часть от {i}-го числа равна {number},0");
//    sum += number;
//}
//Console.WriteLine("сумма всех целых частей равна " + sum);


//8.  Дано целое число N и набор из N целых чисел. Вывести в том же порядке все четные числа из данного набора
//и количество K таких чисел

//Console.Write($"Введите число N: ");
//int n = int.Parse(Console.ReadLine());
//int number = 0, countEven = 0;
//for (int i = 1; i <= n; i++)
//{
//    Console.Write($"Введите {i} число: ");
//    number = int.Parse(Console.ReadLine());
//    if (number % 2 == 0)
//    {
//        countEven++;
//        Console.WriteLine($"число {number} четное");
//    }

//}
//Console.WriteLine("количество четных чисел равно " + countEven);


//10. Дано целое число N и набор из N целых чисел. Если в наборе имеются положительные числа, то вывести TRUE;
//в противном случае вывести FALSE.

Console.Write($"Введите число N: ");
int n = int.Parse(Console.ReadLine());
int number = 0;
for (int i = 1; i <= n; i++)
{
    Console.Write($"Введите {i} число: ");
    number = int.Parse(Console.ReadLine());
}
if (number > 0)
{
    Console.WriteLine("TRUE");
}
else
{
    Console.WriteLine("FALSE");
}