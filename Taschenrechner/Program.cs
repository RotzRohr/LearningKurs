namespace Taschenrechner;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Zahl1: ");
        int zahl1 = Int32.Parse(Console.ReadLine());
        Console.Write("Zahl2: ");
        int zahl2 = Int32.Parse(Console.ReadLine());
        Console.Write("Operator: ");
        string operation = Console.ReadLine();

        Console.Write("Ergebnis: ");

        switch (operation)
        {
            case "+":
                Console.WriteLine(zahl1 + zahl2);
                break;
            case "-":
                Console.WriteLine(zahl1 - zahl2);
                break;
            case "*":
                Console.WriteLine(zahl1 * zahl2);
                break;
            case "/":
                if(zahl1 == 0 || zahl2 == 0)
                {
                    Console.WriteLine("Division durch 0 ist nicht erlaubt.");
                    break;
                }
                Console.WriteLine(zahl1 / zahl2);
                break;
            default:
                Console.WriteLine("Ungültige Operation.");
                break;
        }

    }
}