//литералы переменные константы типы данных
//литералы - неизменяемые значения, которые передаются переменным

using Store;
using System;

Console.WriteLine(15);
Console.WriteLine('a');
Console.WriteLine(true);
Console.WriteLine("popa");

//переменные являются именнованными областями памяти, которые содержат значение определенного типа

int a = 15;
int decrement;
string name;
name = "vladimir";
bool result = false;
double Result = 3.5;

//константой является переменная, которая обязательно должна быть инициализированна и остаётся неизменной 

const string CATNAME = "popa";

//тип данных определяет множество значений, которые может принимать переменная, и действия, которые можно совершать с переменной

bool int byte short int long float double decimal char string object var;

//||\\

//циклы массивы списки конструкции if else switch case

//циклы позволяют выполнять какое-либо действие множество раз
//for выполняет инструкцию пока его внутренний цикл работает
//foreach же будет выполняться столько раз, сколько какой-то объект находится в списке или массиве

for (int i = 0; i < 10; i++) { Console.WriteLine(i); }
foreach (int num in nums) { Console.WriteLine(num); }

//массив - набор однотипных данных фиксированного количества

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[,] words = { { "p", "o" }, { "p", "a" } };

//список тот же набор однотипных объектов

var pets = new List<string>(10) { "dog", "cat", "parrot" };
var petShop = new List<string>(pets) { "mice" };

//if else

int num1 = 5;
int num2 = 77;

if (num1 < num2)
{
    Console.WriteLine(num2);
}
else if (num1 > num2)
{
    Console.WriteLine(num1);
}
else { Console.WriteLine(num1 + num2); }

// switch case 

int w = Convert.ToInt32(Console.ReadLine());

switch (w)
{
    case 1:
        Console.WriteLine(w);
        break;
    case 2:
        Console.WriteLine(w);
        break;
    case 3:
        Console.WriteLine(w);
        break;
    case 4:
        Console.WriteLine(w);
        break;
    default:
        Console.WriteLine("undefined");
        break;
}

//функции хранят в себе набор инструкций, которые выполняют действие при вызове самой функции

void SayNum(int num) //здесь в функцию передано int значение - параметр; это значит, что при вызове функции в нее будет необходимо указать соответствующее значение дабы она сработала
{
    Console.WriteLine(num); //сама инструкция
}

void SayWord(string word) //то же самое, но параметр уже string
{
    Console.WriteLine(word);
}

void KeepSilence() //данная функция не требует входных параметров при её вызове, потому она просто выполнит инстркцию
{
    Console.WriteLine("you have nothing to say");
}

SayNum(20);
SayWord("mew");
KeepSilence();

//||\\

//классы объекты классов конструктор класса пространство имён

//класс является описанием объектов этого класса, как бы шаблон

//объектом класса считается экземпляр, созданный по шаблону класса

//конструктор класса - специальный метод, который называется как и класс; позволяет создавать и инициализировать объекты классов

//namespace позволяет отделять и объединять различные части кода и его функциональность, схожие одной темой, в специальные логические блоки

using Store;

Furniture wardrobe = new Furniture();

int wardrobeHeight = wardrobe.height;
int wardrobeWeight = wardrobe.weight;
bool isOpenable = wardrobe.openable;

wardrobe.height = 2;
wardrobe.weight = 40;
wardrobe.openable = true;

wardrobe.open();

namespace Store
{
    class Furniture
    {
        public int height;
        public int weight;

        public bool openable;

        public void open()
        {
            if (openable)
            {
                Console.WriteLine("Дверца открыта");
            }
            else { Console.WriteLine("Не может быть открыта"); }
        }
    }
}

//||\\

//статические члены и модификаторы доступа

//статический член относятся ко всем классу или структуре и не требуют создания класса или структуры для того, чтобы обратиться к ним

//модификатор доступа, в каком месте кода и файле может использоваться переменная или метод
//(private, private protected, internal, internal protected, protected, public (табличку сами учите))

Person pluh = new(15);

int personsAge = pluh.age;

class Person
{
    public int age;
    private int cardcvv;

    public static bool isExtrasense = false;

    public Person(int age) { this.age = age; } //возможен и static конструктор

    public void Print() { Console.WriteLine($"Этому человеку {age} лет"); }
    public static void Check()
    {
        if (!isExtrasense)
        {
            Console.WriteLine("Самый обычный человек");
        }
        else { Console.WriteLine("Вас обманули"); }
    }
}

//||\\

//преобразование типов необходима для ситуаций, когда некоторые операции в конечном результате дают отличный типа данных от изначальных

long zr = 15;
long b = zr + 15; //данный код выдаст ошибку, так как конечный результат будет int, а не long, для этого надо:

short br = 15;
short z = (short)(br + 15);

//||\\

//конструкция try catch позволяет обрабатывать исключения и вылавливать ошибки

try
{
    int dec = 5;
    int div = dec / 0;
    Console.WriteLine($"{div}");
}
catch
{
    Console.WriteLine("Возникло исключение");
}
