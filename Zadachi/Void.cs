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
            Console.WriteLine(MultiplicationBetween(2, 8));


        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static void SayHello(string name)
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
    }
}
