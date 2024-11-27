namespace Fahrzeuge;

public class Auto : Fahrzeug
{
    public int Passagiere { get; set; }
    public int Sitze { get; set; }

    public override string ToString()
    {
        return $"MaxGeschwindigkeit: {GetMaxX2()}, Passagiere: {Passagiere}, Sitze: {Sitze}";
    }
}