using System;

//1. Даны целые числа K и N (N > 0). Вывести N раз число K

//Console.Write("Введите K ");
//int k = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите N ");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n > 0)
//{
//    for (int i = 0; i < n; i++)
//    {
//        Console.WriteLine(k);
//    }
//}
//else
//{
//    Console.WriteLine("N должно быть больше 0");
//}


//2.Даны два целых числа A и B (A < B). Вывести в порядке возрастания все
//целые числа, расположенные между A и B (включая сами числа A и B), а
//также количество N этих чисел.

//Console.Write("Введите A ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите B ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a < b)
//{
//    int i = a;
//    int j = 0;
//    for (; i <= b; i++, j++)
//    {
//        Console.WriteLine(i);
//    }
//    Console.WriteLine("количество чисел " + j);
//}
//else
//{
//    Console.WriteLine("А должно быть меньше В");
//}


//3. Даны два целых числа A и B (A < B). Вывести в порядке убывания все
//целые числа, расположенные между A и B (не включая числа A и B), а
//также количество N этих чисел.

//Console.Write("Введите A ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите B ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a < b)
//{
//    int i = b - 1;
//    int j = 0;
//    for (; i > a; i--, j++)
//    {
//        Console.WriteLine(i);
//    }
//    Console.WriteLine("количество чисел " + j);
//}
//else
//{
//    Console.WriteLine("А должно быть меньше В");
//}


//4. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1,
//2, . . . , 10 кг конфет.

//Console.Write("Введите цену за 1 кг конфет ");
//int a = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i * a);
//}


//5. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 0.1,
//0.2, . . . , 1 кг конфет.

//Console.Write("Введите цену за 1 кг конфет ");
//int a = Convert.ToInt32(Console.ReadLine());
//for (double i = 0.1; i <= 1; i += 0.1)
//{
//    Console.WriteLine(i * a);
//}


//6. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2,
//1.4, . . . , 2 кг конфет.

//Console.Write("Введите цену за 1 кг конфет ");
//int a = Convert.ToInt32(Console.ReadLine());
//for (double i = 1.2; i <= 2; i += 0.2)
//{
//    Console.WriteLine(i * a);
//}


//7. Даны два целых числа A и B (A < B). Найти сумму всех целых чисел
//от A до B включительно.

//Console.Write("Введите A ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите B ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a < b)
//{
//    int sum = 0;
//    for (int i = a; i <= b; i++)
//    {
//        Console.WriteLine(i);
//        sum += i;
//    }
//    Console.WriteLine("сумма всех чисел " + sum);
//}
//else
//{
//    Console.WriteLine("А должно быть меньше В");
//}


//8. Даны два целых числа A и B (A < B). Найти произведение всех целых
//чисел от A до B включительно.

//Console.Write("Введите A ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите B ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a < b)
//{
//    int com = 1;
//    for (int i = a; i <= b; i++)
//    {
//        Console.WriteLine(i);
//        com *= i;
//    }
//    Console.WriteLine("сумма всех чисел " + com);
//}
//else
//{
//    Console.WriteLine("А должно быть меньше В");
//}


//9. Даны два целых числа A и B (A < B). Найти сумму квадратов всех целых
//чисел от A до B включительно.

//Console.Write("Введите A ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите B ");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a < b)
//{
//    int sum = 0;
//    for (int i = a; i <= b; i++)
//    {
//        Console.WriteLine(i);
//        int c = (int)Math.Pow(i, 2);
//        sum += c;
//    }
//    Console.WriteLine("сумма всех чисел " + sum);
//}
//else
//{
//    Console.WriteLine("А должно быть меньше В");
//}