namespace QuizSystem;

public class QuizSystem
{
    public List<Frage> Fragen { get; set; }
    public int RichtigeAntowrten { get; set; }
    public int FalscheAntowrten { get; set; }

    public QuizSystem()
    {
        this.Fragen = new List<Frage>();
    }

    public void addFrage(Frage frage)
    {
        Fragen.Add(frage);
    }

    public void StartQuiz()
    {
        foreach (var frage in Fragen)
        {
            Console.WriteLine(frage.FrageStellung);
            frage.printAntworten();
            Antwort antwort = Antwort.INVALID;
            while (true)
            {
                Console.WriteLine("Ihre Antwort:");
                antwort = ParseAntwort(Console.ReadLine());
                if(antwort == Antwort.INVALID)
                {
                    Console.WriteLine("Ungültige Antwort.");
                }
                else
                {
                    break;
                }
            }
            if (frage.RichtigeAntwort == antwort)
            {
                Console.WriteLine("Richtig!");
                RichtigeAntowrten++;
            }
            else
            {
                Console.WriteLine("Falsch!");
                Console.WriteLine("Richtige Antwort wäre gewesen: " + frage.RichtigeAntwort);
                FalscheAntowrten++;
            }
        }
    }

    public void PrintResult()
    {
        Console.WriteLine("Ergebnis:");
        Console.WriteLine("Richtige Antworten: " + RichtigeAntowrten);
        Console.WriteLine("Falsche Antworten: " + FalscheAntowrten);
    }

    private Antwort ParseAntwort(string readLine)
    {
        foreach (Antwort antwort in Antwort.GetValuesAsUnderlyingType<Antwort>())
        {
            if (antwort.ToString().Equals(readLine.ToUpper()))
            {
                return antwort;
            }
        }
        return Antwort.INVALID;
    }
}