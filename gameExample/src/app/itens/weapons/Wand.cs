using testeAbstractFactory.src.app.weapons;

namespace testeAbstractFactory.src.app.itens.weapons.basicWeapons;

public abstract class Wand : IWeapon
{
    public virtual void Attack()
    {
      Console.WriteLine("Atancdo com a varinha");
    }
}
