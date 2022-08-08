Warrior warrior = new(name: "Hercules", level: 2);


Weapon axe = new(3, 1, WeaponTypes.Axe);
axe.Name = "Rusted Axe";
axe.RequiredLevel = 5;
axe.Slot = Slot.Weapon;
warrior.ItemEquip(axe);

Item head = new Armor(ArmorTypes.Plate, 3);
head.Name = "Helmet";
head.RequiredLevel = 1;
head.Slot = Slot.Head;
warrior.ItemEquip(head);

Item chest = new Armor(ArmorTypes.Plate, 5);
chest.Name = "Chestplate";
chest.RequiredLevel = 1;
chest.Slot = Slot.Body;
warrior.ItemEquip(chest);

Item legs = new Armor(ArmorTypes.Plate, 4);
legs.Name = "Chestplate";
legs.RequiredLevel = 1;
legs.Slot = Slot.Legs;
warrior.ItemEquip(legs);

warrior.UpdateCharacterDamage(axe);

warrior.DisplayStats();
Console.WriteLine(warrior.MainStat);