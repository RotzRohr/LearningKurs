namespace Fahrkartenautomat;

public class FahrkartenResponse
{
    public bool Valid { get; set; }
    public double WechselGeld { get; set; }

    public FahrkartenResponse(bool Valid, double WechselGeld)
    {
        this.Valid = Valid;
        this.WechselGeld = WechselGeld;
    }
}