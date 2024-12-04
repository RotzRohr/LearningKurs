using Zuul.items;

namespace Zuul;

public class PickupCommand : BasicCommand
{
    public PickupCommand(string Command) : base(Command)
    {
    }

    public override void Help(Zuul game)
    {
        Console.WriteLine("Pickup an Item in the Room");
    }

    public override Room Execute(string UserInput, Zuul game)
    {
        if (game.currentRoom.Items.Any(item => item.PickupName.Equals(UserInput)))
        {
            Item item = game.currentRoom.Items.First(item => item.PickupName.Equals(UserInput));
            game.currentRoom.Items.Remove(item);
            game.Inventory.Add(item);
            Console.WriteLine($"You picked up {item.Name}");
        }
        else
        {
            Console.WriteLine("There is no such Item in this Room");
        }
        return game.currentRoom;
    }
}