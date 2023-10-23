// Weapon axe = new("Axe", 20);
// Weapon sword = new("Sword", 10);

Weapon axe = new Axe();
Weapon sword = new Sword();

List<Weapon> weapons = new();
weapons.Add(new Axe());
weapons.Add(new Sword());

fighter Alva = new("alva", 10, axe);
fighter Helmi = new("helmi", 10, sword);
bool alvasTurn = true;


while (Alva.hp > 0 && Helmi.hp > 0)
{
    if (alvasTurn == true)
    {
        Alva.Attack(Helmi);
        alvasTurn = false;
        Console.WriteLine($"{Alva.name} does {Alva.weapon.dmg} to {Helmi.name}, who now has {Helmi.hp}");
        Console.ReadLine();
    }
    else if (alvasTurn == false)
    {
        Helmi.Attack(Alva);
        alvasTurn = true;
        Console.WriteLine($"{Helmi.name} does {Helmi.weapon.dmg} to {Alva.name}, who now has {Alva.hp}");
        Console.ReadLine();
    }

}

if (Alva.hp > 0)
{
    Console.WriteLine($"{Alva.name} has won!");
}

else if (Helmi.hp > 0)
{
    Console.WriteLine($"{Helmi.name} has won!");
}

else
{
    Console.WriteLine("there is no winner");
}
Console.ReadLine();