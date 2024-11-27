namespace Fahrzeuge;

class Program
{
    static void Main(string[] args)
    {
        Auto auto = new Auto()
        {
            Passagiere = 5,
            Sitze = 7,
            MaxGeschwindigkeit = 120
        };
        Console.WriteLine(auto);


        LKW lkw = new LKW()
        {
            LadeVolumen = 200,
            MaxGeschwindigkeit = 300
        };

        Console.WriteLine(lkw);
    }
}