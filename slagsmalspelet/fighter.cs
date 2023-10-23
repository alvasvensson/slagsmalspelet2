public class fighter
{
    // Random generator = new Random();
    public int hp;
    public string name;
    public Weapon weapon;

    public fighter(string nameo, int hpo, Weapon choice)
    {
        name = nameo;
        hp = hpo;
        weapon = choice;
    }

    public void Attack(fighter attacker, fighter target)
    {
        int dmgDone = weapon.Attack();
        target.hp -= dmgDone;
        Console.WriteLine($"{attacker.name} does {dmgDone} to {target.name}, who now has {target.hp}");
    }

}

