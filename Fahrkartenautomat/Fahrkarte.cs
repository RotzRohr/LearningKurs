namespace Fahrkartenautomat;

public class Fahrkarte
{
    public string Start { get; set; }
    public string Ziel { get; set; }
    public double Preis { get; set; }

    public Fahrkarte(string Start, string Ziel, double Preis)
    {
        this.Start = Start;
        this.Ziel = Ziel;
        this.Preis = Preis;
    }
}