using Zuul.items;

namespace Zuul;

public class SearchCommand : BasicCommand
{
    public SearchCommand(string Command) : base(Command)
    {
    }

    public override void Help(Zuul game)
    {
        Console.WriteLine("Finds hidden Items in the Room");
    }

    public override Room Execute(string UserInput, Zuul game)
    {
        if(game.currentRoom.Items.Count > 0)
        {
            Console.WriteLine("You found the following Items:");
            foreach (Item item in game.currentRoom.Items)
            {
                Console.WriteLine(item.Name + " - " + item.PickupName);
            }
        }
        else
        {
            Console.WriteLine("There are no Items in this Room");
        }
        return game.currentRoom;
    }
}