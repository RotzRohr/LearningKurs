using Zuul.items;

namespace Zuul;

public class ShowCommand : BasicCommand
{
    public ShowCommand(string Command) : base(Command)
    {
    }

    public override void Help(Zuul game)
    {
        Console.WriteLine("Shows Items in your Inventory");
    }

    public override Room Execute(string UserInput, Zuul game)
    {
        if (game.Inventory.Count > 0)
        {
            Console.WriteLine("You have the following Items:");
            foreach (Item item in game.Inventory)
            {
                Console.WriteLine(item.Name);
            }
        }
        else
        {
            Console.WriteLine("You have no Items in your Inventory");
        }
        return game.currentRoom;
    }

}