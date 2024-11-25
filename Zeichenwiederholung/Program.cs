namespace Zeichenwiederholung;

class Program
{
    static void Main(string[] args)
    {
        //int count = Int32.Parse(Console.ReadLine());
        //ZeicheLinie(count);


        ZeicheWeihnachtsBaumBlätter(1,21);

    }

    private static char charToReapeat = '*';

    public static void ZeicheWeihnachtsBaumBaum(int max)
    {
        int spaces = (max - 1) / 2;
        for (int i = 0; i < spaces; i++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("|");
    }



    public static void ZeicheWeihnachtsBaumBlätter(int current, int max)
    {
        if(current > max)
        {
            ZeicheWeihnachtsBaumBaum(max);
            return;
        }
        int spaces = (max - current) / 2;
        for (int i = 0; i < spaces; i++)
        {
            Console.Write(" ");
        }
        for (int i = 0; i < current; i++)
        {
            Console.Write(charToReapeat);
        }

        Console.WriteLine();
        ZeicheWeihnachtsBaumBlätter(current+2, max);
    }

    public static void ZeicheLinie(int count)
    {
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