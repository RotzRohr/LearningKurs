namespace Buchverwaltung;

public class TestClass2
{
    private static List<MyClass> objeList = new List<MyClass>();
    public static void Main(string[] args)
    {
        MyClass myClass1 = new MyClass(); //123
        myClass1.text = "1";

        MyClass myClass2 = new MyClass(); //456
        myClass2.text = "2";

        objeList.Add(myClass1);//0
        objeList.Add(myClass2);//1

        doSomething();


        Console.WriteLine("myClass1: " + myClass1.text);//
        Console.WriteLine("myClass2: " + myClass2.text);//
    }

    public static void doSomething()
    {
        //objeList[0]; 123
        MyClass obj = objeList[0]; //123
        obj.text = "3";
    }

    public class MyClass
    {
        public string text { get; set; }
    }
}