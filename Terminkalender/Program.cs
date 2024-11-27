namespace Terminkalender;

class Program
{
    static void Main(string[] args)
    {
        Kalender kalender = new Kalender(FileHelper.loadTermine());

        while (true)
        {
            Console.WriteLine("1. Termin hinzufügen");
            Console.WriteLine("2. Termin löschen");
            Console.WriteLine("3. Alle Termine anzeigen");
            Console.WriteLine("4. Beenden");

            int auswahl = Int32.Parse(Console.ReadLine());

            switch (auswahl)
            {
                case 1:
                    Console.Write("Datum: ");
                    string datum = Console.ReadLine();
                    Console.Write("Uhrzeit: ");
                    string uhrzeit = Console.ReadLine();
                    Console.Write("Beschreibung: ");
                    string beschreibung = Console.ReadLine();
                    kalender.addTermin(new Termin(datum, uhrzeit, beschreibung));
                    break;
                case 2:
                    Console.Write("Index: ");
                    int index = Int32.Parse(Console.ReadLine());
                    kalender.removeTermin(index-1);
                    break;
                case 3:
                    kalender.printTermine();
                    break;
                case 4:
                    FileHelper.saveTermine(kalender.Termine);
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;

            }

        }
    }
}