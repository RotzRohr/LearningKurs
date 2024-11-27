namespace Fahrzeuge;

public class LKW : Fahrzeug
{
    public int LadeVolumen { get; set; }

    public override int GetMaxX2()
    {
        return Math.Min(base.GetMaxX2(),80);
    }

    public override string ToString()
    {
        return $"MaxGeschwindigkeit: {GetMaxX2()}, LadeVolumen: {LadeVolumen}";
    }
}