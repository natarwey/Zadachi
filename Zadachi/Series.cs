using System;

//1. Даны десять вещественных чисел. Найти их сумму.

int sum = 0;
for(int i = 1; i <= 10; i++)
{
	Console.Write($"Введите {i} число");
	sum += int.Parse(Console.ReadLine());
}
Console.WriteLine(sum);



	