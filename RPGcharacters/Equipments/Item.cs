namespace RPGcharacters.Equipments;

public abstract class Item
{
    public string Name { get; set; } = "";
    public int RequiredLevel { get; set; }

    public Slot Slot { get; set; }

}
