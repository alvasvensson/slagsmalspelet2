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

    public void Attack(fighter target)
    {
        int dmgDone = weapon.Attack();
        target.hp -= dmgDone;
    }

}

