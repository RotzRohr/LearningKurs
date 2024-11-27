namespace QuizSystem;

class Program
{
    static void Main(string[] args)
    {
        Frage frage1 = new Frage("Wie viele Planeten hat unser Sonnensystem?")
        {
            RichtigeAntwort = Antwort.B,
            AlleAntworten = new Dictionary<Antwort, string>()
            {
                { Antwort.A, "5" },
                { Antwort.B, "8" },
                { Antwort.C, "10" },
                { Antwort.D, "12" }
            }
        };

        Frage frage2 = new Frage("Wie viele Kontinente gibt es?")
        {
            RichtigeAntwort = Antwort.C,
            AlleAntworten = new Dictionary<Antwort, string>()
            {
                { Antwort.A, "3" },
                { Antwort.B, "5" },
                { Antwort.C, "7" },
                { Antwort.D, "9" }
            }
        };

        QuizSystem quiz = new QuizSystem();
        quiz.addFrage(frage1);
        quiz.addFrage(frage2);

        quiz.StartQuiz();
        quiz.PrintResult();
    }
}