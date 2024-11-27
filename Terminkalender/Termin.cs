namespace Terminkalender;

public class Termin
{
    public string Datum { get; set; }
    public string Uhrzeit { get; set; }
    public string Beschreibung { get; set; }

    public Termin(string Datum, string Uhrzeit, string Beschreibung)
    {
        this.Datum = Datum;
        this.Uhrzeit = Uhrzeit;
        this.Beschreibung = Beschreibung;
    }

    public override string ToString()
    {
        return $"Datum: {Datum}, Uhrzeit: {Uhrzeit}, Beschreibung: {Beschreibung}";
    }
}