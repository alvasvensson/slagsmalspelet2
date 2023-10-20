Weapon axe = new("Axe", 20);
Weapon sword = new("Sword", 10);

Weapon axe2 = new Axe();

List<Weapon> weapons = new();
weapons.Add(new Axe());


fighter Alva = new("alva", 10, axe);
fighter Helmi = new("helmi", 10, sword);

Alva.Attack(Helmi);
