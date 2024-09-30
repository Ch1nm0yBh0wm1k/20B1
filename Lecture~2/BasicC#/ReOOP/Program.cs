// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//class + Object Initialization

//Person person = new Person();
//Console.WriteLine(person.age);
//class Person
//{
//    public string name;   //fields
//    public int age = 2;
//    //properties
//    public void PrintSomething() //metod
//    {
//        Console.WriteLine("Hi");
//    }
//}

//constructor
//Person person = new Person();
//Console.WriteLine(person.name);

//Person person2 = new Person("rahul", 10);
//Console.WriteLine(person2.name);

//class Person
//{
//    public string name;   //fields
//    public int age = 2;
//    //properties

//    public Person() //default constructor
//    {
//        name = "chinmoy";
//        age = 28;
//    }
//    public Person(string Name, int Age) //parametrized constructor
//    {
//        name = Name;
//        age = Age;
//    }
//    public void PrintSomething() //metod
//    {
//        Console.WriteLine("Hi");
//    }
//}


//Access Modifier

//public
//Person person = new Person();
//Console.WriteLine(person.age);
//Person person2 = new Person();
//Console.WriteLine(person2.GetPrivateVal());

//Person person3 = new Person();
//Console.WriteLine(person3.Pwd);

//class Person
//{
//    public string name;   //fields
//    public int age = 2;
//    private string pwd = "1234";

//    public string Pwd { get { return pwd; } set { pwd = value;  } }

//    public string GetPrivateVal()
//    { return pwd; }

//}

//static

//Person  person = new Person();
//Console.WriteLine(person.GetPrivateVal());

//Person person2 = new Person();
//Console.WriteLine(person2.GetPrivateVal());

//Person person3 = new Person();
//Console.WriteLine(person3.GetPrivateVal());
//class Person
//{

//    public static int a = 2;
//    public int GetPrivateVal()
//    { 
//        return ++a; 
//    }

//}

//inhitance
//Person2 person = new Person2();
//Console.WriteLine(person.a);
//class Person
//{

//    public int a = 2;


//}
//class Person2 : Person
//{

//    public int GetPrivateVal()
//    {
//        return ++a;
//    }

//}

//method overloading

//Person person = new Person();
//person.Sum(1, 2);
//person.Sum(1.1D, 2.2D);
//person.Sum(1.1F, 2.1F);

//class Person
//{

//    public void Sum(int a, int b)
//    {
//        Console.WriteLine("I am from int");
//    }
//    public void Sum(double a, double b)
//    {
//        Console.WriteLine("I am from double");
//    }
//    public void Sum(float a, float b)
//    {
//        Console.WriteLine("I am from float");
//    }


//}



//method overriding

//class Person
//{

//    virtual public void Sum(int a, int b)
//    {
//        Console.WriteLine("I am from main");
//    }



//}

//class Person2 : Person
//{
//    override public void Sum(int a, int b)
//    {
//        Console.WriteLine("I am from Overrided One");
//    }
//}

//abstraction


//abstract class Person
//{
//    public int ReturnSomething()
//    {
//        return 1;
//    }
//    abstract public void Print();

//}
//class P2 : Person
//{
//    override public void Print()
//    {
//        Console.WriteLine("");
//    }
//}

//Interface

interface IPerson
{
    public void Nothing();
}
interface IPerson2
{
    public void Nothing();
}


class P1 : IPerson
{
    public void Nothing()
    {
        
    }
}
class P2
{
    public void Nothing()
    {

    }
}
class p3 : IPerson, IPerson2
{
    public void Nothing()
    {
        throw new NotImplementedException();
    }
}


//multiple inheritance
//multilevel inheritance

