using Zuul.items;

namespace Zuul;

public class Zuul
{
    private List<BasicCommand> commands = new List<BasicCommand>();
    public List<Item> Inventory = new List<Item>();
    public Room currentRoom;
    public Room newRoom;
    public Zuul()
    {
        addCommands();
        createRooms();

        while (true)
        {
            if (newRoom != currentRoom)
            {
                if (newRoom != null)
                {
                    Console.WriteLine();
                    currentRoom = newRoom;
                }
                currentRoom.printInfo();
            }
            Console.Write("[User]: ");
            string UserInput = Console.ReadLine();
            string[] SplitInput = UserInput.Split(' ');

            string userInput = SplitInput.Length > 1 ? SplitInput[1] : "";
            if (SplitInput[0].Equals("help"))
            {
                foreach (BasicCommand command in commands)
                {
                    Console.WriteLine($"{command.GetType().Name} \"{command.Command}\"");
                    command.Help(this);
                    Console.WriteLine("-------------------------");
                }
            }
            else
            {
                foreach (BasicCommand command in commands)
                {
                    if (SplitInput[0].Equals(command.Command))
                    {
                        newRoom = command.Execute(userInput, this);
                    }
                }
            }
        }
    }

    private void addCommands()
    {
        commands.Add(new GoCommand("go"));
        commands.Add(new ExitCommand("exit"));
        commands.Add(new PickupCommand("pickup"));
        commands.Add(new SearchCommand("search"));
        commands.Add(new ShowCommand("show"));
    }


    private void createRooms()
    {
        Room CampusPub = new Room()
        {
            Name = "Campus",
            Description = "Hallo Campus"
        };


        Room MainEntrance = new Room()
        {
            Name = "Main Entrance",
            Description = "Hallo Entrance"
        };

        Room LectureTheatre = new Room()
        {
            Name = "Lecture Theatre",
            Description = "Welcome"
        };

        Room ComputingLab = new Room()
        {
            Name = "Computing Lab",
            Description = "Hallo Entrance"
        };

        Room ComputingAdmin = new Room()
        {
            Name = "Computing Admin",
            Description = "Hallo Entrance"
        };

        MainEntrance.addExit("left", CampusPub);
        ComputingAdmin.addExit("left", ComputingLab);
        LectureTheatre.addExit("left", MainEntrance);
        ComputingLab.addExit("over", MainEntrance);
        CampusPub.addExit("right", MainEntrance);
        MainEntrance.addExit("right", LectureTheatre);
        MainEntrance.addExit("under", ComputingLab);
        ComputingLab.addExit("right", ComputingAdmin);

        Item book = new Item("Book", "book");
        LectureTheatre.addItem(book);
        currentRoom = CampusPub;
    }
}