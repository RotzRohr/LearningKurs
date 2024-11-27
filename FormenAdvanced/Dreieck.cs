namespace FormenAdvanced;

public class Dreieck : Form
{
    public Dreieck(int wert1, int wert2) : base(wert1, wert2)
    {
    }

    public override double BerechneFläche()
    {
        return 0.5 * wert1 * wert2;
    }

    public override double BerechneUmfang()
    {
        double halbeBasis = wert1 / 2.0;
        double schenkellänge = Math.Sqrt(halbeBasis * halbeBasis + wert2 * wert2);
        return wert1 + 2 * schenkellänge;
    }
}