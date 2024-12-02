namespace Zuul;

public class Room
{
    public Dictionary<string,Room> exits;
    private string name;
    private string description;

    public Room(string name, string description)
    {
        this.name = name;
        this.description = description;
        exits = new Dictionary<string, Room>();
    }

    public void addExit(string exit, Room room)
    {
        exits.Add(exit, room);
    }

    public void printInfos()
    {
        //name desc exits
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Description: " + description);
        Console.WriteLine("Exits:");
        foreach (var exit in exits)
        {
            Console.WriteLine(exit.Key);
        }
    }
}