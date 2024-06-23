// наследование - ключевой прицнцип ООП, заключается в том, что позволяет одному классу унаследовать функциональность другого

using System.Drawing;

People tom = new("Tom", 19, 293);
tom.Print();
Employee bob = new("Bob", 20, 224);
bob.Print();

class People
{
    public string name;
    public int age;
    private int cvv;

    public People(string name, int age, int cvv)
    {
        this.name = name;
        this.age = age;
        this.cvv = cvv;
    }

    public void Print()
    {
        Console.WriteLine($"Зовут {name}, возраст - {age}, CVV-код {cvv}");
    }
}

class Employee : People
{
    public Employee(string name, int age, int cvv) : base(name, age, cvv)
    {

    }
}

//||\\

//перегрузка методов позволяет создавать один и тот же метод с различными параметрами; осуществляется через сигнатуры

class Calculator
{
    public void Sub(int x, int y) //сигнатура - Sub(int, int)
    {
        int result = x - y;
    }
    public void Sub(int x, int y, int z) //сигнатура - Sub(int, int, int), количество значений другое, потому создается перегрузка
    {
        int result = x - y - z;
    }
    public void Sub(float x, float y) //сигнатура - Sub(float, float), типы данных значений другое, поэтому создается перегрузка
    {
        float result = x - y;
    }
    public void Div(int x, decimal y) { int result = (int)(x / y); } //сигнатура - Div(int, decimal)
    public void Div(decimal x, int y) { int result = (int)(x / y); } //сигнатура - Div(decimal, int), порядок разных типов данных другой, потому создается перегрузка
}

//||\\

//свойства обеспечивают доступ к полям класс классов и структур, узнать их значение и/или выполнить их установку

Car car = new Car();

car.speed = 60;
int carSpeed = car.speed;

int numOfWheels = car.NumOfWheels;

car.NumOfPassangers = 4;

Console.WriteLine(carSpeed);
Console.WriteLine(numOfWheels);

class Car
{
    public int numOfWheels = 4;
    public int numOfPassangers;
    public int speed //в это свойство можно внести значение при помощи set и прочитать с помощью get
    {
        get { return speed; }
        set { speed = value; }
    }
    public int NumOfWheels { get { return numOfWheels; } } //это свойство можно только прочитать, оно уже задано в классе
    public int NumOfPassangers { set { numOfPassangers = value; } } //в это свойство можно только внести значение
}

//||\\

//абстрактные классы необходимы для описания таких классов, которые будут иметь между собой что-то общее,
//но, чтобы создать экземпляр класса, НЕ используется конструктор абстрактного класса 
//абстрактными также могут быть методы, свойства, индексаторы и события и в таком случае они требуют перезаписи

Figure rec = new Rec("Прямоугольник");
Figure tri = new Tri("Треугольник");
Figure cir = new Cir("Круг");

rec.Print();
tri.Print();
cir.Print();
abstract class Figure
{
    public string Name { get; }
    public Figure(string name) { Name = name; }
    public abstract void Print();
}

class Rec : Figure
{
    public Rec(string name) : base(name) { }
    public override void Print()
    {
        Console.WriteLine($"У {Name} 4 угла"); ;
    }
}
class Tri : Figure
{
    public Tri(string name) : base(name) { }
    public override void Print()
    {
        Console.WriteLine($"У {Name} 3 угла"); ;
    }
}
class Cir : Figure
{
    public Cir(string name) : base(name) { }
    public override void Print()
    {
        Console.WriteLine($"У {Name} нет углов"); ;
    }
}

//||\\

//делегаты лямбды события

//делегатом является объект, который указывает на метод

//лямбда-выражения позволяют сокращать и упрощать запись анонимных методов, которые могут возвращать какие-то значения и которые можно передавать в качестве параметров в другие методы
//в лямбды необязательно передавать типы данных, если не используется неявная типизация (var), то есть, например - Op sum = (x, y) => Console.WriteLine($"{x + y}")

Supply sup; //делегату объявляется переменная
sup = Send; //переменной присваетвается адрес метода
sup(); //метод вызывается при помощи делегата

void Send() => Console.WriteLine("Отправлено");

delegate void Supply(); //создается делегает

//события сигнализируют системе, что произошло какое-либо действие; события используются для того, чтобы отследить эти
//действия и являются указателями на делегаты и использует заданный в делегат тип данных как выводные данные

class Company
{
    public delegate void Product(string selled); //создается делегат
    public event Product? IsSelled; //к делегату определяется событие с "?", не допускающий null значения
    public Company(int sum) => Sum = sum;
    public int Sum { get; set; }
    public void Sell(int sum)
    {
        Sum += sum;
        IsSelled?.Invoke($"Продукт был продан за {sum}"); //событие вызывается и выводит строку, т.к. в делегате указан string
    }
}


//||\\

//паттерн fabric позволяет облегчить создание классов, у которых совпадают 

static class ProductFabric
{
    public static Product Create(string name, int weight, int cost)
    {
        return new Product(name, weight, cost);
    }
}

class Product
{
    public int weight;

    public string Name;
    public int Cost;
    public Product(string name, int weight, int cost)
    {
        Name = name;
        this.weight = weight;
        Cost = cost;
    }
}

//||\\

//интерфейс является как бы родительским классом, он определяет без реализации методы, свойства, события, статические поля, константы и индексаторы для того, чтобы
//классы и структуры использовали и реализовывали весь функционал, применяя интерфейс

interface ICat
{
    const int ChromosomePairs = 19;
    string CoatColor { get; set; }
    void Meow();
}

class BritishShortHair : ICat
{
    private string color;
    public string CoatColor { get { return color; } set { color = value; } }
    public void Meow() => Console.WriteLine("Meow (a normal one)");
}

class Lion : ICat
{
    private string color;
    public string CoatColor { get { return color; } set { color = value; } }
    public void Meow() => Console.WriteLine("MReow (an angry one)");
}

//||\\

//обобщение облегчает работу с типами данных, не прибегая к использованию преобразований и проверок,
//если мы не уверены, какие именно типы данных будут использоваться или если метод будет работать одинаково с любым типом данных

void Swap<TAny>(TAny x, TAny y, TAny z) //в <> скобках указывается либо тип данных, либо универсальный тип (как сейчас)
{
    TAny temp = x; //такая программа будет работать с любым типом данных, будь то string, int или bool
    x = y;
    y = z;
    z = temp;
}