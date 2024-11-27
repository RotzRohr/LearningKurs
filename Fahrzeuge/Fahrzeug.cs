namespace Fahrzeuge;

public class Fahrzeug
{
    public int MaxGeschwindigkeit { get; set; }

    public virtual int GetMaxX2()
    {
        return MaxGeschwindigkeit * 2;
    }
}