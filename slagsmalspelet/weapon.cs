public class Weapon
{

    public int dmg;
    public string name;
    Random generator = new();

    public virtual int Attack()
    {
        return generator.Next(dmg);
    }


    // public Weapon(string nameo, int dmgo)
    // {
    //     name = nameo;
    //     dmg = dmgo;
    // }
}