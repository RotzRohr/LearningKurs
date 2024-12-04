namespace Zuul.items;

public class Item
{
    public string Name { get; set; }
    public string PickupName { get; set; }


    public Item(string Name, string PickupName)
    {
        this.Name = Name;
        this.PickupName = PickupName;
    }
}