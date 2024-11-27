namespace FormenAdvanced;

class Program
{
    static void Main(string[] args)
    {
        Rechteck rechteck = new Rechteck(5, 10);
        Console.WriteLine("Rechteck: " + rechteck);
        Console.WriteLine($"Fläche: {rechteck.BerechneFläche()}");
        Console.WriteLine($"Umfang: {rechteck.BerechneUmfang()}");
        Console.WriteLine();

        Cube cube = new Cube(5);
        Console.WriteLine("Cube: " + cube);
        Console.WriteLine($"Fläche: {cube.BerechneFläche()}");
        Console.WriteLine($"Umfang: {cube.BerechneUmfang()}");
        Console.WriteLine();

        Kreis kreis = new Kreis(5, 10);
        Console.WriteLine("Kreis:" + kreis);
        Console.WriteLine($"Fläche: {kreis.BerechneFläche()}");
        Console.WriteLine($"Umfang: {kreis.BerechneUmfang()}");
        Console.WriteLine();

        Dreieck dreieck = new Dreieck(5, 10);
        Console.WriteLine("Dreieck:" + dreieck);
        Console.WriteLine($"Fläche: {dreieck.BerechneFläche()}");
        Console.WriteLine($"Umfang: {dreieck.BerechneUmfang()}");
    }
}