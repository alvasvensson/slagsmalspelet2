public class Axe : Weapon
{
    Random generator = new Random();
    public Axe()
    {
        name = "Axe";
        dmg = generator.Next(2, 4);
    }

}