namespace ListeVerwalten;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine("+ oder - oder 0 oder exit");
            Console.Write("Ihre Wahl: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "+":
                    Console.Write("Element: ");
                    list.Add(Console.ReadLine());
                    break;
                case "-":
                    Console.Write("Index: ");
                    int index = Int32.Parse(Console.ReadLine());
                    if (index < 0 || index >= list.Count)
                    {
                        Console.WriteLine("Ungültiger Index.");
                        break;
                    }
                    string removedElement = list[index];
                    list.RemoveAt(index);
                    Console.WriteLine($"Element {removedElement} an Index {index} entfernt.");
                    break;
                case "0":
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine($"{i}: {list[i]}");
                    }
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Ungültige Eingabe.");
                    break;
            }
        }

    }
}