namespace Zuul;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        new Program();
    }

    public Room currentRoom;

    public Program()
    {
        initRooms();
        Console.WriteLine("Welcome to the World of Zuul!");
        while (true)
        {
            currentRoom.printInfos();
            Console.Write("> ");
            string command = Console.ReadLine();
            string[] commandParts = command.Split(" ");
            string mergedCommand = string.Join(" ", commandParts[1..]);
            if (commandParts[0].Equals("switch"))
            {
                SwitchRoom switchRoom = new SwitchRoom("switch");
                switchRoom.execute(mergedCommand, currentRoom, this);
            }
            Console.WriteLine();
        }
    }

    private void initRooms()
    {
        Room room1 = new Room("Raum1","Raum1 Desc");
        Room room2 = new Room("Raum2","Raum2 Desc");
        Room room3 = new Room("Raum3","Raum3 Desc");
        Room room4 = new Room("Raum4","Raum4 Desc");
        room1.addExit("unten", room3);
        room1.addExit("rechts", room2);

        room2.addExit("links", room1);
        room2.addExit("unten", room4);

        room3.addExit("oben", room1);
        room3.addExit("rechts", room4);

        room4.addExit("links", room3);
        room4.addExit("oben", room2);

        currentRoom = room1;
    }
}