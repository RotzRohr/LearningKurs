namespace Schachspiel.data;

public class Pair<A, B, C>
{
    public A First { get; set; }
    public B Second { get; set; }
    public C Third { get; set; }

    public Pair(A First, B Second, C Third)
    {
        this.First = First;
        this.Second = Second;
        this.Third = Third;
    }
}