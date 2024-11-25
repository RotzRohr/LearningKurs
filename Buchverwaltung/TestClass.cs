namespace Buchverwaltung;

public class TestClass
{
    public static void Main2(string[] args)
    {
        MyClass myClass1 = new MyClass(); //123
        myClass1.text = "1";

        MyClass myClass2 = new MyClass(); //456
        myClass2.text = "2";

        doSomething(myClass2);


        Console.WriteLine("Was 1: " + myClass1.text); //1   1
        Console.WriteLine("Was 2: " + myClass2.text); //23  2
    }

    public static void doSomething(MyClass myClass) //456
    {
        Console.WriteLine(myClass.text); //456
        myClass = new MyClass(); //789
        myClass.text = "3";
        Console.WriteLine(myClass.text); //789
    }

    public class MyClass
    {
        public string text { get; set; }
    }
}