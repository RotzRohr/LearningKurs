namespace Buchverwaltung;

class Program
{
    static void Main(string[] args)
    {
        Buch buch1 = new Buch("Harry Potter1", "J.K. Rowling", Guid.NewGuid().ToString()); //1
        Buch buch2 = new Buch("Harry Potter2", "J.K. Rowling", Guid.NewGuid().ToString()); //2
        Buch buch3 = new Buch("Harry Potter3", "J.K. Rowling", Guid.NewGuid().ToString()); //3
        List<Buch> buchListe = new List<Buch> { buch1, buch2, buch3 };

        Console.WriteLine("Hallo und willkommen zur Buchverwaltung!");
        while (true)
        {
            Console.WriteLine("Optionen:");
            Console.WriteLine("1: Buch hinzufügen");
            Console.WriteLine("2: Buch ausleihen");
            Console.WriteLine("3: Buch zurückgeben");
            Console.WriteLine("4: Buchliste anzeigen");
            Console.WriteLine("5: Programm beenden");

            Console.Write("Ihre Wahl: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.Write("Titel: ");
                    string titel = Console.ReadLine();
                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();
                    Buch buch = new Buch(titel, autor, Guid.NewGuid().ToString());
                    buchListe.Add(buch);
                    Console.WriteLine("Buch hinzugefügt.");
                    break;
                case "2":
                    Console.Write("ID: ");
                    string id = Console.ReadLine();
                    Buch buchToLend = buchListe.Find(b => b.ISBN.ToLower().StartsWith(id.ToLower()));
                    if (buchToLend == null)
                    {
                        Console.WriteLine("Buch nicht gefunden.");
                        break;
                    }
                    if (!buchToLend.Verfügbar)
                    {
                        Console.WriteLine("Buch ist bereits ausgeliehen.");
                        break;
                    }
                    ausleihen(buchToLend);
                    Console.WriteLine("Buch ausgeliehen.");
                    break;
                case "3":
                    Console.Write("ID: ");
                    id = Console.ReadLine();
                    Buch buchToReturn = buchListe.Find(b => b.ISBN.ToLower().StartsWith(id.ToLower()));
                    if (buchToReturn == null)
                    {
                        Console.WriteLine("Buch nicht gefunden.");
                        break;
                    }
                    if (buchToReturn.Verfügbar)
                    {
                        Console.WriteLine("Buch ist nicht ausgeliehen.");
                        break;
                    }
                    buchToReturn.Verfügbar = true;
                    Console.WriteLine("Buch zurückgegeben.");
                    break;
                case "4":
                    foreach (Buch b in buchListe)
                    {
                        Console.WriteLine(b);
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }
        }
    }

    public static void ausleihen(Buch buch)
    {
        buch.Verfügbar = false;
    }
}