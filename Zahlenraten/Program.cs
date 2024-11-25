namespace Zahlenraten;

class Program
{
    static void Main(string[] args)
    {
        int randomNumber = new Random().Next(1, 11);
        int guess = 0;
        int attempts = 0;
        while(true)
        {
            Console.WriteLine("Gib eine Zahl zwischen 1 und 10 ein:");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;
            if (guess == randomNumber)
            {
                break;
            }
            else
            {
                Console.WriteLine("Falsch!");
            }
        }
        Console.WriteLine($"Du hast die Zahl erraten! ({attempts} Versuche)");
    }
}