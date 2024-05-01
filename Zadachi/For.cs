using System;

//1. Даны целые числа K и N (N > 0). Вывести N раз число K

//Console.Write("Введите K: ");
//int k = int.Parse(Console.ReadLine());
//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine(k);
//}


//2.Даны два целых числа A и B (A < B). Вывести в порядке возрастания все
//целые числа, расположенные между A и B (включая сами числа A и B), а
//также количество N этих чисел.

//Console.Write("Введите A: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = int.Parse(Console.ReadLine());
//int j = 0;
//for (int i = a; i <= b; i++, j++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("количество чисел " + j);


//3. Даны два целых числа A и B (A < B). Вывести в порядке убывания все
//целые числа, расположенные между A и B (не включая числа A и B), а
//также количество N этих чисел.

//Console.Write("Введите A: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = int.Parse(Console.ReadLine());
//int j = 0;
//for (int i = b - 1; i > a; i--, j++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("количество чисел " + j);



//4. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1,
//2, . . . , 10 кг конфет.

//Console.Write("Введите цену за 1 кг конфет: ");
//double a = double.Parse(Console.ReadLine());
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(i * a);
//}


//5. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 0.1,
//0.2, . . . , 1 кг конфет.

//Console.Write("Введите цену за 1 кг конфет: ");
//double a = double.Parse(Console.ReadLine());
//for (double i = 0.1; i <= 1; i += 0.1)
//{
//    Console.WriteLine(i * a);
//}


//6. Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2,
//1.4, . . . , 2 кг конфет.

//Console.Write("Введите цену за 1 кг конфет: ");
//double a = double.Parse(Console.ReadLine());
//for (double i = 1.2; i <= 2; i += 0.2)
//{
//    Console.WriteLine(i * a);
//}


//7. Даны два целых числа A и B (A < B). Найти сумму всех целых чисел
//от A до B включительно.

//Console.Write("Введите A: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = a; i <= b; i++)
//{
//    Console.WriteLine(i);
//    sum += i;
//}
//Console.WriteLine("сумма всех чисел " + sum);


//8. Даны два целых числа A и B (A < B). Найти произведение всех целых
//чисел от A до B включительно.

//Console.Write("Введите A: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = int.Parse(Console.ReadLine());
//int product = 1;
//for (int i = a; i <= b; i++)
//{
//    Console.WriteLine(i);
//    product *= i;
//}
//Console.WriteLine("произведение всех чисел " + product);


//9. Даны два целых числа A и B (A < B). Найти сумму квадратов всех целых
//чисел от A до B включительно.

//Console.Write("Введите A: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = a; i <= b; i++)
//{
//    Console.WriteLine(i);
//    sum += i * i;
//}
//Console.WriteLine($"сумма квадратов всех чисел {sum}");


//10. Дано целое число N (> 0). Найти сумму 1 + 1 / 2 + 1 / 3 + . . . + 1 / N
//(вещественное число).

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double sum = 0;
//for (double i = 1; i <= n; i++)
//{
//    sum += 1 / i;
//}
//Console.WriteLine("сумма всех чисел " + sum);


//11. Дано целое число N (> 0). Найти сумму N^2 + (N + 1)^2 + (N + 2)^2 + . . . + (2·N)^2
//(целое число).

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 0; i <= n; i++)
//{
//    sum += (n + i) * (n + i);
//}
//Console.WriteLine("сумма всех чисел " + sum);


//12. Дано целое число N (> 0). Найти произведение 1.1 · 1.2 · 1.3 · ... (N сомножителей).

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double product = 1.1, j = 1.2;
//for (int i = 1; i < n; i++, j += 0.1) 
//{
//    product *= j;
//}
//Console.WriteLine("произведение всех чисел " + product);


//13. Дано целое число N (> 0). Найти значение выражения 1.1 − 1.2 + 1.3 − ...
//(N слагаемых, знаки чередуются).Условный оператор не использовать.

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double result = 0;
//int c = 1;
//for (double i = 1; i <= n; i++)
//{
//    result += c * (1 + i / 10);
//    c *= -1;
//}
//Console.WriteLine(result);


//14. Дано целое число N (> 0). Найти квадрат данного числа, используя для его вычисления следующую
//формулу: N^2 = 1 + 3 + 5 + ... + (2·N − 1). После добавления к сумме каждого слагаемого выводить
//текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//int result = 0;
//for (int i = 1; i <= n; i++)
//{
//    result += 2 * i - 1;
//}
//Console.WriteLine(result);


//15. Дано вещественное число A и целое число N (> 0). Найти A в степени N:
//A^N = A·A·...·A (числа A перемножаются N раз).

//Console.Write("Введите A: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double product = 1;
//for (int i = 1; i <= n; i++)
//{
//    product *= a;
//}
//Console.WriteLine(product);


//16. Дано вещественное число A и целое число N (> 0). Используя один
//цикл, вывести все целые степени числа A от 1 до N.

//Console.Write("Введите A: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double result = a;
//for (int i = 1; i <= n; i++)
//{
//    Console.Write(result + " ");
//    result *= a;
//}


//17. Дано вещественное число A и целое число N (> 0). Используя один цикл, найти сумму
// 1 + A + A^2 + A^3 + . . . + A^N

//Console.Write("Введите A: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double sum = 1, product = 1;
//for (int i = 0; i < n; i++)
//{
//    product *= a;
//    sum += product;
//}
//Console.WriteLine(sum);


//18. Дано вещественное число A и целое число N (> 0). Используя один цикл, найти значение выражения
//1 − A + A^2 − A^3 + . . . + (−1)^N ·A^N .
//Условный оператор не использовать.

//Console.Write("Введите A: ");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double result = 1, product = 1;
//for (int i = 0; i < n; i++)
//{
//    product *= a;
//    result -= product;
//}
//Console.WriteLine(result);


//19. Дано целое число N (> 0). Найти произведение N! = 1·2·...·N (N–факториал).
//Чтобы избежать целочисленного переполнения, вычислять это произведение с помощью вещественной переменной и вывести
//его как вещественное число.

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double factorial = 1;
//for (int i = 1; i <= n; i++)
//{
//    factorial *= i;
//}
//Console.WriteLine($"Факториал числа {n} равен: {factorial}");


//20. Дано целое число N (> 0). Используя один цикл, найти сумму 1! + 2! + 3! + . . . + N!
//(выражение N! — N–факториал — обозначает произведение всех целых чисел от 1 до N: N! = 1·2·. . .·N).
//Чтобы избежать целочисленного переполнения, проводить вычисления с помощью вещественных переменных
//и вывести результат как вещественное число.

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double sum = 0;
//double factorial = 1;
//for (int i = 1; i <= n; i++)
//{
//    factorial *= i;
//    sum += factorial;
//}
//Console.WriteLine($"Сумма 1! + 2! + ... + N! для числа {n} равна: {sum}");


//33. Дано целое число N (> 1). Последовательность чисел Фибоначчи FK
//(целого типа) определяется следующим образом: F1 = 1, F2 = 1, FK = FK−2 + FK−1, K = 3, 4, ... .
//Вывести элементы F1, F2, ..., FN .

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine()!);
//int f1 = 0, f2 = 1, f3 = 1;
//Console.Write($"{f1} {f2} {f3} ");
//for (int i = 3; i <= n; i++)
//{
//    f1 = f2;
//    f2 = f3;
//    f3 = f1 + f2;
//    Console.Write(f3 + " ");
//}


//36. Даны целые положительные числа N и K. Найти сумму 1^K + 2^K + . . . + N^K.

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//Console.Write("Введите K: ");
//int k = int.Parse(Console.ReadLine());
//double sum = 0;
//for (int i = 1; i <= n; i++)
//{
//    double degree = 1;
//    for (int j = 1; j <= k; j++)
//    {
//        degree *= i; //вложенный цикл нахождения степени
//    }
//    sum += degree;
//}
//Console.WriteLine(sum);


//37.Дано целое число N (> 0). Найти сумму 1^1 + 2^2 + . . . + N^N

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double sum = 0, degree = 1;
//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        degree *= i; //вложенный цикл нахождения степени
//    }
//    sum += degree;
//    degree = 1;
//}
//Console.WriteLine(sum);


//38.  Дано целое число N (> 0). Найти сумму 1^N + 2^N−1 + ... + N^1.

//Console.Write("Введите N: ");
//int n = int.Parse(Console.ReadLine());
//double sum = 0, degree = 1;
//for (int i = 1; i <= n; i++)
//{
//    for (int j = n; j >= i; j--)
//    {
//        degree *= i; //вложенный цикл нахождения степени
//    }
//    sum += degree;
//    degree = 1;
//}
//Console.WriteLine(sum);


//39. Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно;
//при этом каждое число должно выводиться столько раз, каково его значение.

//Console.Write("Введите A: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = int.Parse(Console.ReadLine());
//for (int i = a; i <= b; i++)
//{
//    for (int j = 0; j < i; j++)
//    {
//        Console.Write(i + " ");
//    }
//}
//Console.WriteLine();


//40. Даны целые числа A и B (A < B). Вывести все целые числа от A до B включительно;
//при этом число A должно выводиться 1 раз, число A + 1 должно выводиться 2 раза и т.д.

//Console.Write("Введите A: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("Введите B: ");
//int b = int.Parse(Console.ReadLine());
//for (int i = a; i <= b; i++)
//{
//    for (int j = 0; j < i - a + 1; j++)
//    {
//        Console.Write(i + " ");
//    }
//}