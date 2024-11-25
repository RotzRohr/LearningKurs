namespace GeradeUngerade;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gib eine Zahl ein:");
        int zahl = Convert.ToInt32(Console.ReadLine());
        if(zahl % 2 == 0)
        {
            Console.WriteLine("Die Zahl ist gerade.");
        }
        else
        {
            Console.WriteLine("Die Zahl ist ungerade.");
        }
    }
}