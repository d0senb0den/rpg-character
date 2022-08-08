namespace RPGcharacters.Characters;

public class Rogue : Hero
{
    public Rogue(string name, int level)
    {
        Name = name;
        ClassName = "Rogue";
        Level = level;
        Damage = 0;
        Strength = 2;
        Dexterity = 6;
        Intelligence = 1;
        MainStat = Dexterity;
        OnLevelUp(1, 4, 1, Dexterity);
    }
    /// <summary>
    /// Displays the stats of a created class in the console.
    /// </summary>
    public void DisplayStats()
    {
        Console.Write($"{Name} ({ClassName})\nLevel: ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{Level}\n");
        Console.ResetColor();
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Dexterity: {MainStat}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Damage: {Damage}");
    }

    /// <summary>
    /// Equips weapon and armor if it meets the requirements. Otherise, exceptions will be thrown.
    /// If the dictionary contains an item, it gets replaced and the bonusStat will be deducted from damage(weapon) or mainstat(armor).
    /// </summary>
    /// <param name="item"></param>
    /// <exception cref="InvalidWeaponException"></exception>
    public override string ItemEquip(Item item)
    {
        if (typeof(Weapon) == item.GetType())
        {
            Weapon weapon = (Weapon)item;
            if (weapon.Weapons == WeaponTypes.Dagger ||
                weapon.Weapons == WeaponTypes.Sword)
            {
                if (weapon.RequiredLevel > Level)
                {
                    throw new InvalidWeaponException("Unable to equip weapon, level not high enough!");
                }
                if (weapon != null)
                {
                    if (equipment.ContainsKey(item.Slot))
                    {
                        var currentItemInSlot = (Weapon)equipment[item.Slot];
                        Damage -= currentItemInSlot.Damage;
                        equipment[item.Slot] = weapon;
                        Damage += weapon.Damage;
                        Console.WriteLine($"\nEquipped: {weapon.Name}");
                        Console.WriteLine($"Damage: {weapon.Damage}");
                        Console.WriteLine($"DPS: {weapon.Dps}");
                        Console.WriteLine($"Attack speed: {weapon.AttackSpeed}");
                        return "New weapon equipped";
                    }
                    else
                    {
                        equipment.Add(item.Slot, weapon);
                        Damage += weapon.Damage;
                        Console.WriteLine($"\nEquipped: {weapon.Name}");
                        Console.WriteLine($"Damage: {weapon.Damage}");
                        Console.WriteLine($"DPS: {weapon.Dps}");
                        Console.WriteLine($"Attack speed: {weapon.AttackSpeed}");
                        return "New weapon equipped";
                    }
                }
                else
                {
                    throw new InvalidWeaponException("Unable to equip weapon, level not high enough!");
                }
            }
            else
            {
                throw new InvalidWeaponException("This weapon cannot be equipped");
            }
        }
        if (typeof(Armor) == item.GetType())
        {
            Armor armor = (Armor)item;
            if (armor.Armors == ArmorTypes.Leather ||
                armor.Armors == ArmorTypes.Mail)
            {
                if (armor.RequiredLevel > Level)
                {
                    throw new InvalidArmorException("Unable to equip weapon, level not high enough!");
                }
                if (armor != null)
                {
                    if (equipment.ContainsKey(item.Slot))
                    {
                        var currentItemInSlot = (Armor)equipment[item.Slot];
                        MainStat -= currentItemInSlot.BonusStat;
                        equipment[item.Slot] = armor;
                        MainStat += armor.BonusStat;
                        Console.WriteLine($"Equipped {armor.Name}");
                        Console.WriteLine($"Required level: {armor.RequiredLevel}");
                        Console.WriteLine($"Slot: {armor.Slot}");
                        Console.WriteLine($"Main stat: +{armor.BonusStat}");
                        return "New armor equipped";
                    }
                    else
                    {
                        equipment.Add(item.Slot, armor);
                        MainStat += armor.BonusStat;
                        Console.WriteLine($"Equipped {armor.Name}");
                        Console.WriteLine($"Required level: {armor.RequiredLevel}");
                        Console.WriteLine($"Slot: {armor.Slot}");
                        Console.WriteLine($"Main stat: +{armor.BonusStat}");
                        return "New armor equipped";
                    }
                }
                else
                {
                    throw new InvalidArmorException("Unable to equip armor, level not high enough!");
                }
            }
            else
            {
                throw new InvalidArmorException("This armor cannot be equipped");
            }
        }
        return "";
    }
}

