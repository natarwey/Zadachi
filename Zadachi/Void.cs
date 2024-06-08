using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadachi
{
    public class Void
    {
        static void Main()
        {
            SayHello("Alex");
            Console.WriteLine(SumMathPow(5, 2));
            SayHello("Ivan");
            Console.WriteLine(Sum(1,2,3,4,5,6,7,8));

        }
        static double Sum(double a, double b) => a + b;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(params int[] nums) => nums.Sum();

        //static void SayHello()
        //{
        //    //Console.WriteLine("Hello");
        //}

        /// <summary>
        /// Says Helo to everybody
        /// </summary>
        /// <param name="name"></param>
        static void SayHello(string name = "")
        {
            Console.WriteLine($"Hello {name}");
        }

        static int MathPow(int a, int b)
        {
            int product = 1;
            for (int i = 1; i <= b; i++)
            {
                product *= a;
            }
            return product;
        }

        static int Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        
        static int SumFactorial(int n) //сумма факториалов до n-го числа
        {
            int sum = 0, factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial;
            }
            return sum;
        }

        static int Fibonachi(int n)
        {
            int f1 = 0, f2 = 1, f3 = 0;
            for (int i = 3; i <= n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f3;
        }

        static int Remains(int a, int b) //остаток от деления a/b нацело
        {
            int result = 0, reminder = a;
            while (reminder >= b)
            {
                reminder -= b;
                result++;
            }
            return reminder;
        }

        static int QuantityBetween(int a, int b) //количество чисел от a до b включительно
        {
            int quantity = 0;
            for (int i = a; i <= b; i++)
            {
                quantity++;
            }
            return quantity;
        }

        static int SumBetween(int a, int b) //сумма всех целых чисел от a до b включительно
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        static int MultiplicationBetween(int a, int b) //произведение всех целых чисел от a до b включительно
        {
            int multiplication = 1;
            for (int i = a; i <= b; i++)
            {
                multiplication *= i;
            }
            return multiplication;
        }

        static int SumMathPow(int n, int k) //сумма 1^K + 2^K + . . . + N^K
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int degree = 1;
                for (int j = 1; j <= k; j++)
                {
                    degree *= i; //вложенный цикл нахождения степени
                }
                sum += degree;
            }
            return sum;
        }
    }
}
