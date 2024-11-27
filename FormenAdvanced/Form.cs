namespace FormenAdvanced;

public class Form
{
    public int wert1 { get; set; }
    public int wert2 { get; set; }

    public Form(int wert1, int wert2)
    {
        this.wert1 = wert1;
        this.wert2 = wert2;
    }

    public virtual double BerechneFläche()
    {
        return wert1 * wert2;
    }

    public virtual double BerechneUmfang()
    {
        return 2 * (wert1 + wert2);
    }

    public override string ToString()
    {
        return $"Wert1: {wert1}, Wert2: {wert2}";
    }
}