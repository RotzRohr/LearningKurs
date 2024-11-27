namespace QuizSystem;

public class Frage
{
    public string FrageStellung { get; set; }
    public Antwort RichtigeAntwort { get; set; }
    public Dictionary<Antwort, string> AlleAntworten { get; set; }

    public Frage(string FrageStellung)
    {
        this.FrageStellung = FrageStellung;
    }

    public void printAntworten()
    {
        foreach (var antwort in AlleAntworten)
        {
            Console.WriteLine(antwort.Key.ToString() + ": " +antwort.Value);
        }
    }
}