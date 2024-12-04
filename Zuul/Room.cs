using Zuul.items;

namespace Zuul;

public class Room
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Dictionary<string, Room> Exits { get; set; }
    public List<Item> Items { get; set; }

    public Room()
    {
        Exits = new Dictionary<string, Room>();
        Items = new List<Item>();
    }

    public void addItem(Item item)
    {
        Items.Add(item);
    }

    public void addExit(string direction, Room room)
    {
        Exits.Add(direction, room);
    }

    public void printInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine("You have the following Options:");
        foreach (KeyValuePair<string,Room> keyValuePair in Exits)
        {
            Console.WriteLine(keyValuePair.Key);
        }
    }
}