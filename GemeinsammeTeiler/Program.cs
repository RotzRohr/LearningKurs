namespace GemeinsammeTeiler;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Zahl1: ");
        int zahl1 = Int32.Parse(Console.ReadLine());
        Console.Write("Zahl2: ");
        int zahl2 = Int32.Parse(Console.ReadLine());

        List<int> teiler1 = Teiler(zahl1);
        List<int> teiler2 = Teiler(zahl2);

        List<int> gemeinsammeTeiler = new List<int>();
        foreach (int teiler in teiler1)
        {
            if (teiler2.Contains(teiler))
            {
                gemeinsammeTeiler.Add(teiler);
            }
        }
        if(gemeinsammeTeiler.Count == 0)
        {
            Console.WriteLine("Keine gemeinsamen Teiler.");
            return;
        }

        //größter gemeinsamer Teiler
        Console.WriteLine($"Größter gemeinsamer Teiler: {gemeinsammeTeiler.Max()}");

        //kleinster gemeinsamer Teiler
        Console.WriteLine($"Kleinster gemeinsamer Teiler: {gemeinsammeTeiler.Min()}");
    }

    private static List<int> Teiler(int zahl1)
    {
        List<int> teiler = new List<int>();
        for (int i = 2; i <= zahl1; i++)
        {
            if (zahl1 % i == 0)
            {
                teiler.Add(i);
            }
        }
        return teiler;
    }
}