namespace FormenAdvanced;

public class Cube : Form
{
    public Cube(int wert1) : base(wert1,wert1)
    {
    }

    public override string ToString()
    {
        return $"Wert: {wert1}";
    }
}