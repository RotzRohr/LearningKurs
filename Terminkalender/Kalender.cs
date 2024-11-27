namespace Terminkalender;

public class Kalender
{
    public List<Termin> Termine { get; set; }

    public Kalender(List<Termin> Termine)
    {
        this.Termine = Termine;
    }

    public void addTermin(Termin termin)
    {
        Termine.Add(termin);
    }

    public void removeTermin(int index)
    {
        Termine.RemoveAt(index);
    }

    public void printTermine()
    {
        Console.WriteLine("Termine:");
        Console.WriteLine("--------");
        foreach (var termin in Termine)
        {
            Console.WriteLine(termin);
        }
        Console.WriteLine("--------");
    }
}