namespace FormenBasic;

public class Rechteck
{
    public int height { get; set; }
    public int width { get; set; }

    public Rechteck(int height, int width)
    {
        this.height = height;
        this.width = width;
    }

    public int BerechneFläche()
    {
        return height * width;
    }

    public int BerechneUmfang()
    {
        return 2 * (height + width);
    }

}