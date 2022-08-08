

namespace RPGcharactersTests;

public class EquipmentTest
{
    [Fact]
    public void ItemEquip_TooHighLevelWeapon_ThrowError()
    {
        Warrior warrior = new(name: "Hercules", level: 1);

        Weapon axe = new(3, 1, WeaponTypes.Axe)
        {
            Name = "Rusted Axe",
            RequiredLevel = 5,
            Slot = Slot.Weapon
        };

        Assert.Throws<InvalidWeaponException>(() => warrior.ItemEquip(axe));
    }

    [Fact]
    public void ItemEquip_TooHighLevelArmor_ThrowError()
    {
        Warrior warrior = new(name: "Hercules", level: 1);

        Item chest = new Armor(ArmorTypes.Plate, 5)
        {
            Name = "Chestplate",
            RequiredLevel = 7,
            Slot = Slot.Body
        };

        Assert.Throws<InvalidArmorException>(() => warrior.ItemEquip(chest));
    }

    [Fact]
    public void ItemEquip_WrongArmorType_ThrowError()
    {
        Warrior warrior = new(name: "Hercules", level: 10);

        
        Weapon staff = new(3, 1, WeaponTypes.Staff)
        {
            Name = "Ruby Staff",
            RequiredLevel = 5,
            Slot = Slot.Weapon
        };

        Assert.Throws<InvalidWeaponException>(() => warrior.ItemEquip(staff));
    }

    [Fact]
    public void ItemEquip_WrongWeaponType_ThrowError()
    {
        Warrior warrior = new(name: "Hercules", level: 10);

        Item chest = new Armor(ArmorTypes.Cloth, 5)
        {
            Name = "Chestplate",
            RequiredLevel = 7,
            Slot = Slot.Body
        };

        Assert.Throws<InvalidArmorException>(() => warrior.ItemEquip(chest));
    }

    [Fact]
    public void ItemEquip_ValidArmorPiece_Success()
    {
        Ranger ranger = new(name: "Ragnar", level: 14);

        Item chest = new Armor(ArmorTypes.Leather, 10)
        {
            Name = "Leather Chestguard",
            RequiredLevel = 11,
            Slot = Slot.Body
        };

        var expected = "New armor equipped";
        var actual = ranger.ItemEquip(chest);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ItemEquip_ValidWeaponPiece_Success()
    {
        Ranger ranger = new(name: "Ragnar", level: 14);

        Weapon bow = new(3, 1, WeaponTypes.Bow)
        {
            Name = "Fiery Bow",
            RequiredLevel = 5,
            Slot = Slot.Weapon
        };

        var expected = "New weapon equipped";
        var actual = ranger.ItemEquip(bow);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CalculateDamage_NoWeaponEquipped()
    {
        Warrior warrior = new(name: "Hercules", level: 1);

        var expected = 1;
        var actual = warrior.Damage;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CalculateDamage_ValidWeaponEquipped()
    {
        Warrior warrior = new(name: "Hercules", level: 1);

        Weapon axe = new(7, 1.1, WeaponTypes.Axe)
        {
            Name = "Rusted Axe",
            RequiredLevel = 1,
            Slot = Slot.Weapon
        };

        warrior.ItemEquip(axe);

        warrior.UpdateCharacterDamage(axe);


        var expected = 8.09;
        var actual = warrior.Damage;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void CalculateDamage_ValidArmorAndWeaponEquipped()
    {
        Warrior warrior = new(name: "Hercules", level: 1);

        Weapon axe = new(7, 1.1, WeaponTypes.Axe)
        {
            Name = "Rusted Axe",
            RequiredLevel = 1,
            Slot = Slot.Weapon
        };
        Item chest = new Armor(ArmorTypes.Plate, 1)
        {
            Name = "Chestplate",
            RequiredLevel = 1,
            Slot = Slot.Body
        };

        warrior.ItemEquip(axe);
        warrior.ItemEquip(chest);

        warrior.UpdateCharacterDamage(axe);


        var expected = 8.16;
        var actual = warrior.Damage;

        Assert.Equal(expected, actual);
    }
}