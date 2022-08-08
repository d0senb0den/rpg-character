

namespace RPGcharacters.Equipments;

public class Weapon : Item
{
    public int Damage { get; set; }
    public double AttackSpeed { get; set; }
    public double Dps { get; set; }
    public WeaponTypes Weapons { get; set; }

    public Weapon(int damage, double attackSpeed, WeaponTypes weapon)
    {
        Damage = damage;
        AttackSpeed = attackSpeed;
        Weapons = weapon;
        Dps = Damage * AttackSpeed;
    }
}
