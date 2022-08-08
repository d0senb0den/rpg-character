namespace RPGcharacters.Characters;
public abstract class Hero
{
    public Dictionary<Slot, Item> equipment = new();
    public string Name { get; set; } = "";
    public string ClassName { get; set; } = "";
    public int Level { get; set; } = 1;
    public double Damage { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Intelligence { get; set; }
    public double MainStat { get; set; }

    public void OnLevelUp(int strength, int dexterity, int intelligence, int mainStat)
    {
        for (int i = 1; i < Level; i++) // For every level
        {
            // Increase stats
            Strength += strength;
            Dexterity += dexterity;
            Intelligence += intelligence;
            MainStat += mainStat;
        }
    }
    public abstract string ItemEquip(Item item);

    /// <summary>
    /// Updates the characters damage with a Math.Round to round off the value. Returns the value as a double.
    /// </summary>
    /// <param name="weapon"></param>
    /// <returns></returns>
    public double UpdateCharacterDamage(Weapon weapon)
    {
        Damage = Math.Round(weapon.Dps * (1 + MainStat / 100), 2);
        return Damage;
    }

}
