namespace Fahrkartenautomat;

class Program
{
    static void Main(string[] args)
    {
        Fahrkarte fahrkarte1 = new Fahrkarte("Hamburg", "Berlin", 11.12);
        Fahrkarte fahrkarte2 = new Fahrkarte("Hamburg", "Köln", 4.49);

        FahrkartenAutomat automat = new FahrkartenAutomat();
        automat.AddFahrkarte(fahrkarte1);
        automat.AddFahrkarte(fahrkarte2);

        while (true)
        {
            Console.WriteLine("Gib deinen Startbahnhof ein:");
            string start = Console.ReadLine();
            Console.WriteLine("Gib deinen Zielbahnhof ein:");
            string ziel = Console.ReadLine();

            Console.WriteLine("Bitte gib den Betrag ein den du zahlen willst:");
            double betrag = Convert.ToDouble(Console.ReadLine());
            FahrkartenResponse response = automat.KaufeFahrkarte(betrag, start, ziel);
            if (response.Valid)
            {
                Console.WriteLine($"Fahrkarte gekauft!");
                if(response.WechselGeld > 0)
                {
                    automat.GibKundeWechselgeld(response.WechselGeld);
                }
            }
            else
            {
                Console.WriteLine("Fahrkarte konnte nicht gekauft werden.");
                automat.GibKundeWechselgeld(response.WechselGeld);
            }
        }
    }
}