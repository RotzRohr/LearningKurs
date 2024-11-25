namespace FormenBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Width: ");
        int zahl1 = Int32.Parse(Console.ReadLine());
        Console.Write("Height: ");
        int zahl2 = Int32.Parse(Console.ReadLine());

        Rechteck rechteck = new Rechteck(zahl1, zahl2);
        Console.WriteLine($"Fläche: {rechteck.BerechneFläche()}");
        Console.WriteLine($"Umfang: {rechteck.BerechneUmfang()}");
    }
}