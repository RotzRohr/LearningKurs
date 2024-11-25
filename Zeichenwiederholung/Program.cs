namespace Zeichenwiederholung;

class Program
{
    static void Main(string[] args)
    {
        int count = Int32.Parse(Console.ReadLine());
        ZeicheLinie(count);
    }

    public static void ZeicheLinie(int count)
    {
        char charToReapeat = '*';
        for (int i = 0; i < count; i++)
        {
            Console.Write(charToReapeat);
        }
        Console.WriteLine();
        if(count > 0)
        {
            ZeicheLinie(count - 1);
        }
    }
}