namespace Fahrkartenautomat;

public class FahrkartenAutomat
{
    public List<Fahrkarte> Fahrkarten { get; set; }
    public FahrkartenAutomat()
    {
        Fahrkarten = new List<Fahrkarte>();
    }

    public void AddFahrkarte(Fahrkarte fahrkarte)
    {
        Fahrkarten.Add(fahrkarte);
    }

    public FahrkartenResponse KaufeFahrkarte(double geld, string start, string ziel)
    {
        Fahrkarte fahrkarte = Fahrkarten.FirstOrDefault(f => f.Start == start && f.Ziel == ziel);
        if (fahrkarte == null)
        {
            return new FahrkartenResponse(false, geld);
        }
        if (fahrkarte.Preis > geld)
        {
            return new FahrkartenResponse(false, geld);
        }
        return new FahrkartenResponse(true, geld - fahrkarte.Preis);
    }


    public void GibKundeWechselgeld(double geld)
    {
        Console.WriteLine("Ihr Wechselgeld:");
        Console.WriteLine("(" + geld + ")€");
        //gib geld in münzen zurück und scheinen
        //Scheine 5€
        //Münzen 2€, 1€, 50ct, 20ct, 10ct, 5ct, 2ct, 1ct

        double[] scheine = { 5.00 };
        double[] münzen = {2.00, 1.00, 0.50, 0.20, 0.10, 0.05, 0.02, 0.01};

        foreach (double schein in scheine)
        {
            int anzahl = (int)(geld / schein);
            Console.WriteLine($"{anzahl}x {schein}€ Schein");
            geld -= anzahl * schein;
        }

        foreach (double münze in münzen)
        {
            int anzahl = (int)(geld / münze);
            Console.WriteLine($"{anzahl}x {münze}€ Münze");
            geld -= anzahl * münze;
        }


        Console.WriteLine("Danke für ihren Einkauf.");
    }

}