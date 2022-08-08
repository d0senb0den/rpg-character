namespace RPGcharacters.Equipments;

public class Armor : Item
{
    public int BonusStat { get; set; }
    public ArmorTypes Armors { get; set; }

    public Armor(ArmorTypes armor, int bonusStat)
    {
        BonusStat = bonusStat;
        Armors = armor;
    }
}
