namespace Buchverwaltung;

public class Buch
{
    public string Titel { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public bool Verfügbar { get; set; }

    public Buch(string Titel, string Autor, string ISBN)
    {
        this.Titel = Titel;
        this.Autor = Autor;
        this.ISBN = ISBN;
        this.Verfügbar = true;
    }

    public override string ToString()
    {
        return $"Titel: {Titel}, Autor: {Autor}, ISBN: {ISBN}, Verfügbar: {Verfügbar}";
    }
}