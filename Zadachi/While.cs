using System;

//1. Даны положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество
//отрезков длины B (без наложений). Не используя операции умножения и деления, найти длину незанятой части отрезка A.

//Console.Write("Введите A: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = int.Parse(Console.ReadLine());
//while(a >= b)
//{
//    a -= b;
//}
//Console.WriteLine(a);


//2. Даны положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество
//отрезков длины B (без наложений). Не используя операции умножения и деления, найти количество
//отрезков B, размещенных на отрезке A.

//Console.Write("Введите A: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = int.Parse(Console.ReadLine());
//int c = 0;
//while(a >= b)
//{
//    a -= b;
//    c++;
//}
//Console.WriteLine(c);


//3.  Даны целые положительные числа N и K. Используя только операции сложения и вычитания,
//найти частное от деления нацело N на K, а также остаток от этого деления.

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите K: ");
int k = int.Parse(Console.ReadLine());
int result = 0, reminder = n;
while(reminder >= k)
{
    reminder -= k;
    result++;
}
Console.WriteLine($"частное от деления равно {result} остаток равен {reminder}");
