public class Sword : Weapon
{
    Random generator = new Random();
    public Sword()
    {
        name = "Sword";
        dmg = generator.Next(4);
    }
}