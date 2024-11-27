namespace FormenAdvanced;

public class Kreis : Form
{
    public Kreis(int wert1, int wert2) : base(wert1, wert2)
    {
    }

    public override double BerechneFläche()
    {
        return Math.PI * wert1 * wert1;
    }

    public override double BerechneUmfang()
    {
        return 2 * Math.PI * wert1;
    }
}